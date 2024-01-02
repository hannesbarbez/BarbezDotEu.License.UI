// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarbezDotEu.License.Generation;

namespace BarbezDotEu.License.Generator.WinForms
{
    public partial class FrmGenerator : Form
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
        private Stopwatch stopWatch;

        public FrmGenerator()
        {
            InitializeComponent();
            rbScreenshotOne.Checked = true;
            SetResultingSum();
            tbNumberOfSerials.PlaceholderText = $"max. {MAXKEYS}";
        }

        private void TbNumberOfSerials_TextChanged(object sender, EventArgs e)
        {
            this.ValidateInputAndSetNumberOfKeys();
        }

        private async void BtnGenerateSerialNumber_Click(object sender, EventArgs e)
        {
            this.PrepareUiForNewKeys();
            var keyGenerator = new KeyGenerator(resultingsum, DIVIDER);
            this.stopWatch = Stopwatch.StartNew();
            var generatedKeys = await Task.Run(() => keyGenerator.GenerateKeys(numberOfKeys, tbDoNotInclude.Lines));
            this.stopWatch.Stop();
            this.ToggleUI(generatedKeys);
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

        private void ToggleUI(IEnumerable<string> generatedKeys)
        {
            tbSerials.Lines = generatedKeys.ToArray();
            lblStatistics.Text = $"Generated {generatedKeys.Count()} keys in {this.stopWatch.ElapsedMilliseconds} milliseconds.";
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
            BtnTest.Enabled = state;
            pbProgress.Visible = !state;
            if (pbProgress.Visible)
            {
                tbSerials.Clear();
                lblStatistics.Text = string.Empty;
            }
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

        private void BtnTest_Click(object sender, EventArgs e)
        {
            var validator = new FrmValidator(resultingsum);
            validator.ShowDialog();
        }

        private void rbScreenshotOne_CheckedChanged(object sender, EventArgs e)
        {
            SetResultingSum();
        }

        private void rbEisat_CheckedChanged(object sender, EventArgs e)
        {
            SetResultingSum();
        }

        private void rbVocabulary_CheckedChanged(object sender, EventArgs e)
        {
            SetResultingSum();
        }

        private void rbShutdown_CheckedChanged(object sender, EventArgs e)
        {
            SetResultingSum();
        }
    }
}
