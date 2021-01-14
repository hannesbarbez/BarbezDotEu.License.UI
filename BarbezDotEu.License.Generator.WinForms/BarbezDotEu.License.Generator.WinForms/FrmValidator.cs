// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Windows.Forms;
using BarbezDotEu.License.Verification;

namespace BarbezDotEu.License.Generator.WinForms
{
    public partial class FrmValidator : Form
    {
        private readonly KeyVerificator keyVerificator;

        public FrmValidator(int resultingsum)
        {
            InitializeComponent();
            this.keyVerificator = new KeyVerificator(resultingsum, "-");
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var invalidMsg = "Invalid license key. Please try again.";
            var invalidTitle = "Invalid license key";
            try
            {
                var validKey = keyVerificator.VerifyKey(TbSerial1.Text, TbSerial2.Text, TbSerial3.Text, TbSerial4.Text, TbSerial5.Text);
                if (!validKey)
                {
                    MessageBox.Show(invalidMsg, invalidTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Fantastic! This is a valid license key.", "Valid license key", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show(invalidMsg, invalidTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbSerial1_TextChanged(object sender, EventArgs e)
        {
            if (TbSerial1.Text.Length == 5)
                TbSerial2.Focus();
        }

        private void TbSerial2_TextChanged(object sender, EventArgs e)
        {
            if (TbSerial2.Text.Length == 5)
                TbSerial3.Focus();
        }

        private void TbSerial3_TextChanged(object sender, EventArgs e)
        {
            if (TbSerial3.Text.Length == 5)
                TbSerial4.Focus();
        }

        private void TbSerial4_TextChanged(object sender, EventArgs e)
        {
            if (TbSerial4.Text.Length == 5)
                TbSerial5.Focus();
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string ser = Clipboard.GetText().Replace("-", "").Replace(" ", "").Replace("\r", "").Replace("\n", "");
                if (ser.Length == 25)
                {
                    TbSerial1.Text = ser.Substring(0, 5);
                    TbSerial2.Text = ser.Substring(5, 5);
                    TbSerial3.Text = ser.Substring(10, 5);
                    TbSerial4.Text = ser.Substring(15, 5);
                    TbSerial5.Text = ser.Substring(20, 5);
                }
            }
        }
    }
}
