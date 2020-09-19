using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbezDotEu.License.Generator.WinForms
{
    public partial class FrmMain : Form
    {
        // 100000 = Still kind of acceptable before WinForms UI starts to give in.
        private const uint MAXKEYS = 100000;
        private const int RESULTINGSUM_SHUT = 70;
        private const int RESULTINGSUM_SCRONEPRO = 68;
        private const int RESULTINGSUM_EISAT = 66;
        private const int RESULTINGSUM_VOCAB = 64;
        private const string DIVIDER = "-";
        private static uint numberOfKeys;
        private static int resultingsum;
        private HashSet<string> excluded;
        private static ConcurrentBag<string> keys;

        public FrmMain()
        {
            InitializeComponent();
            tbNumberOfSerials.PlaceholderText = $"max. {MAXKEYS}";
        }

        private void TbNumberOfSerials_TextChanged(object sender, EventArgs e)
        {
            this.ValidateInputAndSetNumberOfKeys();
        }

        private async void BtnGenerateSerialNumber_Click(object sender, EventArgs e)
        {
            this.PrepareUiForNewKeys();
            this.SetResultingSum();
            var generatedKeys = await this.GenerateKeys(tbDoNotInclude.Lines);
            this.PrepareUiWithNewKeys(generatedKeys.ToArray());
        }

        private void SetResultingSum()
        {
            if (rbEisat.Checked)
                resultingsum = RESULTINGSUM_EISAT;
            else if (rbScreenshotOne.Checked)
                resultingsum = RESULTINGSUM_SCRONEPRO;
            else if (rbShutdown.Checked)
                resultingsum = RESULTINGSUM_SHUT;
            else if (rbVocabulary.Checked)
                resultingsum = RESULTINGSUM_VOCAB;
        }

        private void PrepareUiWithNewKeys(string[] generatedKeys)
        {
            tbSerials.Lines = generatedKeys;
            this.ToggleUI();
        }

        private void PrepareUiForNewKeys()
        {
            this.ToggleUI();
        }

        private void ToggleUI()
        {
            var state = !btnGenerateSerials.Enabled;
            btnGenerateSerials.Enabled = state;
            tbNumberOfSerials.Enabled = state;
            tbDoNotInclude.Enabled = state;
            rbEisat.Enabled = state;
            rbScreenshotOne.Enabled = state;
            rbShutdown.Enabled = state;
            rbVocabulary.Enabled = state;
            pbProgress.Visible = !state;
            if (pbProgress.Visible)
                tbSerials.Clear();
        }

        public async Task<ConcurrentBag<string>> GenerateKeys(params string[] excludedKeys)
        {
            excluded = new HashSet<string>(excludedKeys.Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => x.Trim()));
            keys = new ConcurrentBag<string>();
            var tasks = CreateTasks();
            for (int i = default; i < numberOfKeys; i++) tasks[i] = new Task(async () => await AddKeyToKeys());
            Parallel.ForEach(tasks, task => task.Start());
            await Task.WhenAll(tasks);
            return keys;
        }

        private Task[] CreateTasks()
        {
            ConcurrentBag<Task> tasks = new ConcurrentBag<Task>();
            Parallel.For(default, numberOfKeys, x =>
            {
                tasks.Add(new Task(async () => await AddKeyToKeys()));
            });

            return tasks.ToArray();
        }

        private Task AddKeyToKeys()
        {
            var key = this.GenerateKey();
            if (!keys.Contains(key) && !excluded.Contains(key))
            {
                keys.Add(key);
            }

            return Task.CompletedTask;
        }

        private string GenerateKey()
        {
            var seq1 = GetSequence();
            var seq2 = GetSequence();
            var seq3 = GetSequence();
            var seq4 = GetSequence();
            var seq5 = GetSequence();

            var pt1 = $"{((char)seq1[0])}{((char)seq2[0])}{((char)seq3[0])}{((char)seq4[0])}{((char)seq5[0])}";
            var pt2 = $"{((char)seq1[1])}{((char)seq2[1])}{((char)seq3[1])}{((char)seq4[1])}{((char)seq5[1])}";
            var pt3 = $"{((char)seq1[2])}{((char)seq2[2])}{((char)seq3[2])}{((char)seq4[2])}{((char)seq5[2])}";
            var pt4 = $"{((char)seq1[3])}{((char)seq2[3])}{((char)seq3[3])}{((char)seq4[3])}{((char)seq5[3])}";
            var pt5 = $"{((char)seq1[4])}{((char)seq2[4])}{((char)seq3[4])}{((char)seq4[4])}{((char)seq5[4])}";
            var key = pt1 + DIVIDER + pt2 + DIVIDER + pt3 + DIVIDER + pt4 + DIVIDER + pt5;
            return key;
        }

        private int[] GetSequence()
        {
            int tempResult = 0, n0 = 0, n1 = 0, n2 = 0, n3 = 0, n4 = 0;
            while (tempResult != resultingsum)
            {
                // For "Next" parameters (numbers) exlanation, see ASCII code table.
                n0 = new Random(Guid.NewGuid().GetHashCode()).Next(48, 53);
                n1 = new Random(Guid.NewGuid().GetHashCode()).Next(n0 + 2, 57);
                n2 = new Random(Guid.NewGuid().GetHashCode()).Next(65, 76);
                n3 = new Random(Guid.NewGuid().GetHashCode()).Next(n2 + 2, 85);
                n4 = new Random(Guid.NewGuid().GetHashCode()).Next(n3 + 2, 90);

                // Sequence has to match the following formula.
                tempResult = ((n0 + n2 + n4) - (n1 + n3));
            }

            return new int[] { n0, n1, n2, n3, n4 };
        }

        private void ValidateInputAndSetNumberOfKeys()
        {
            var isAcceptableInput = uint.TryParse(tbNumberOfSerials.Text, out uint value);
            if (isAcceptableInput && value > uint.MinValue && value <= MAXKEYS) //uint.MaxValue)
            {
                numberOfKeys = value;
                btnGenerateSerials.Enabled = true;
            }
            else
            {
                btnGenerateSerials.Enabled = false;
            }
        }
    }
}
