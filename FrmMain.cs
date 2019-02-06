using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Serial_Number_Generator
{
    public partial class FrmMain : Form
    {
        private const int REQUIREDSMALLSERIALLENGTH = 5;
        private const int RESULTINGSUM_SHUT = 70;
        private const int RESULTINGSUM_SCRONEPRO = 68;
        private const int RESULTINGSUM_EISAT = 66;
        private const int RESULTINGSUM_VOCAB = 64;
        private const string DIVIDER = "-";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGenerateSerialNumber_Click(object sender, EventArgs e)
        {
            List<string> doNotInclude = new List<string>(tbDoNotInclude.Lines);
            for (int i = 0; i < doNotInclude.Count; i++)
                doNotInclude[i] = doNotInclude[i].Trim(new char[] { ' ', '\r', '\n' });

            int amountOfSerialNumbers = 1;
            int.TryParse(tbNumberOfSerials.Text, out amountOfSerialNumbers);
            int reqBigSerialLength = REQUIREDSMALLSERIALLENGTH * 5;
            tbSerials.Clear();
            List<string> collection = new List<string>();

            for (int i = 0; i < amountOfSerialNumbers; i++)
            {
                int[] seq1 = GetSequence();
                int[] seq2 = GetSequence();
                int[] seq3 = GetSequence();
                int[] seq4 = GetSequence();
                int[] seq5 = GetSequence();

                string smallSerial1 = ((char)seq1[0]).ToString() + ((char)seq2[0]).ToString() + ((char)seq3[0]).ToString() + ((char)seq4[0]).ToString() + ((char)seq5[0]).ToString();
                string smallSerial2 = ((char)seq1[1]).ToString() + ((char)seq2[1]).ToString() + ((char)seq3[1]).ToString() + ((char)seq4[1]).ToString() + ((char)seq5[1]).ToString();
                string smallSerial3 = ((char)seq1[2]).ToString() + ((char)seq2[2]).ToString() + ((char)seq3[2]).ToString() + ((char)seq4[2]).ToString() + ((char)seq5[2]).ToString();
                string smallSerial4 = ((char)seq1[3]).ToString() + ((char)seq2[3]).ToString() + ((char)seq3[3]).ToString() + ((char)seq4[3]).ToString() + ((char)seq5[3]).ToString();
                string smallSerial5 = ((char)seq1[4]).ToString() + ((char)seq2[4]).ToString() + ((char)seq3[4]).ToString() + ((char)seq4[4]).ToString() + ((char)seq5[4]).ToString();

                string serial = smallSerial1 + DIVIDER + smallSerial2 + DIVIDER + smallSerial3 + DIVIDER + smallSerial4 + DIVIDER + smallSerial5;
                if (!collection.Contains(serial) && !doNotInclude.Contains(serial))
                {
                    collection.Add(serial);
                    tbSerials.Text += serial + Environment.NewLine;
                }
            }
        }

        private int[] GetSequence()
        {
            int resultingsum = 0;
            if (rbEisat.Checked)
                resultingsum = RESULTINGSUM_EISAT;
            else if (rbScreenshotOne.Checked)
                resultingsum = RESULTINGSUM_SCRONEPRO;
            else if (rbShutdown.Checked)
                resultingsum = RESULTINGSUM_SHUT;
            else if (rbVocabulary.Checked)
                resultingsum = RESULTINGSUM_VOCAB;

            int tempResult = 0, n0 = 0, n1 = 0, n2 = 0, n3 = 0, n4 = 0;
            while (tempResult != resultingsum)
            {
                n0 = new Random(Guid.NewGuid().GetHashCode()).Next(48, 53);
                n1 = new Random(Guid.NewGuid().GetHashCode()).Next(n0 + 2, 57);
                n2 = new Random(Guid.NewGuid().GetHashCode()).Next(65, 76); //For "Next" numbers, refer to ASCII code table
                n3 = new Random(Guid.NewGuid().GetHashCode()).Next(n2 + 2, 85);
                n4 = new Random(Guid.NewGuid().GetHashCode()).Next(n3 + 2, 90);

                //Small Serial has to match the following formula
                tempResult = ((n0 + n2 + n4) - (n1 + n3));
            }

            return new int[] { n0, n1, n2, n3, n4 };
        }
    }
}