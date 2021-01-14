// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using BarbezDotEu.License.Generation;
using System;
using System.Windows.Forms;

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
            var generatedKeys = await keyGenerator.GenerateKeys(numberOfKeys, tbDoNotInclude.Lines);
            this.PrepareUiWithNewKeys(generatedKeys);
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
            BtnTest.Enabled = state;
            pbProgress.Visible = !state;
            if (pbProgress.Visible)
                tbSerials.Clear();
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
