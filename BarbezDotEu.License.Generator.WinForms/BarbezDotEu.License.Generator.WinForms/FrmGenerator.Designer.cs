namespace BarbezDotEu.License.Generator.WinForms
{
    partial class FrmGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnGenerateSerials = new System.Windows.Forms.Button();
            rbScreenshotOne = new System.Windows.Forms.RadioButton();
            rbEisat = new System.Windows.Forms.RadioButton();
            rbVocabulary = new System.Windows.Forms.RadioButton();
            rbShutdown = new System.Windows.Forms.RadioButton();
            tbNumberOfSerials = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            tbDoNotInclude = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            tbSerials = new System.Windows.Forms.TextBox();
            pbProgress = new System.Windows.Forms.ProgressBar();
            BtnTest = new System.Windows.Forms.Button();
            lblStatistics = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 15);
            label1.TabIndex = 0;
            label1.Text = "# of license keys to generate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 109);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 15);
            label2.TabIndex = 1;
            label2.Text = "License keys to exclude:";
            // 
            // btnGenerateSerials
            // 
            btnGenerateSerials.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnGenerateSerials.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnGenerateSerials.Enabled = false;
            btnGenerateSerials.Location = new System.Drawing.Point(457, 12);
            btnGenerateSerials.Name = "btnGenerateSerials";
            btnGenerateSerials.Size = new System.Drawing.Size(127, 37);
            btnGenerateSerials.TabIndex = 2;
            btnGenerateSerials.Text = "&Generate keys";
            btnGenerateSerials.UseVisualStyleBackColor = true;
            btnGenerateSerials.Click += BtnGenerateSerialNumber_Click;
            // 
            // rbScreenshotOne
            // 
            rbScreenshotOne.AutoSize = true;
            rbScreenshotOne.Checked = true;
            rbScreenshotOne.Location = new System.Drawing.Point(50, 49);
            rbScreenshotOne.Name = "rbScreenshotOne";
            rbScreenshotOne.Size = new System.Drawing.Size(129, 19);
            rbScreenshotOne.TabIndex = 3;
            rbScreenshotOne.TabStop = true;
            rbScreenshotOne.Text = "&Screenshot One Pro";
            rbScreenshotOne.UseVisualStyleBackColor = true;
            rbScreenshotOne.CheckedChanged += rbScreenshotOne_CheckedChanged;
            // 
            // rbEisat
            // 
            rbEisat.AutoSize = true;
            rbEisat.Location = new System.Drawing.Point(185, 49);
            rbEisat.Name = "rbEisat";
            rbEisat.Size = new System.Drawing.Size(245, 19);
            rbEisat.TabIndex = 4;
            rbEisat.Text = "&Experience Index System Assessment Tool";
            rbEisat.UseVisualStyleBackColor = true;
            rbEisat.CheckedChanged += rbEisat_CheckedChanged;
            // 
            // rbVocabulary
            // 
            rbVocabulary.AutoSize = true;
            rbVocabulary.Location = new System.Drawing.Point(51, 75);
            rbVocabulary.Name = "rbVocabulary";
            rbVocabulary.Size = new System.Drawing.Size(99, 19);
            rbVocabulary.TabIndex = 5;
            rbVocabulary.Text = "&Vocabulary++";
            rbVocabulary.UseVisualStyleBackColor = true;
            rbVocabulary.CheckedChanged += rbVocabulary_CheckedChanged;
            // 
            // rbShutdown
            // 
            rbShutdown.AutoSize = true;
            rbShutdown.Location = new System.Drawing.Point(157, 75);
            rbShutdown.Name = "rbShutdown";
            rbShutdown.Size = new System.Drawing.Size(79, 19);
            rbShutdown.TabIndex = 6;
            rbShutdown.Text = "S&hutdown";
            rbShutdown.UseVisualStyleBackColor = true;
            rbShutdown.CheckedChanged += rbShutdown_CheckedChanged;
            // 
            // tbNumberOfSerials
            // 
            tbNumberOfSerials.Location = new System.Drawing.Point(185, 13);
            tbNumberOfSerials.Name = "tbNumberOfSerials";
            tbNumberOfSerials.PlaceholderText = "max. 100000";
            tbNumberOfSerials.Size = new System.Drawing.Size(80, 23);
            tbNumberOfSerials.TabIndex = 1;
            tbNumberOfSerials.TextChanged += TbNumberOfSerials_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 51);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 15);
            label3.TabIndex = 8;
            label3.Text = "App:";
            // 
            // tbDoNotInclude
            // 
            tbDoNotInclude.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbDoNotInclude.Location = new System.Drawing.Point(12, 127);
            tbDoNotInclude.Multiline = true;
            tbDoNotInclude.Name = "tbDoNotInclude";
            tbDoNotInclude.PlaceholderText = "Type or paste any license keys to exclude from the list of generated license keys (one per line).";
            tbDoNotInclude.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            tbDoNotInclude.Size = new System.Drawing.Size(571, 73);
            tbDoNotInclude.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 212);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(129, 15);
            label4.TabIndex = 10;
            label4.Text = "Generated license keys:";
            // 
            // tbSerials
            // 
            tbSerials.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbSerials.BackColor = System.Drawing.SystemColors.ControlLight;
            tbSerials.Location = new System.Drawing.Point(12, 230);
            tbSerials.Multiline = true;
            tbSerials.Name = "tbSerials";
            tbSerials.PlaceholderText = "Your generated license keys will appear here.";
            tbSerials.ReadOnly = true;
            tbSerials.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            tbSerials.Size = new System.Drawing.Size(571, 188);
            tbSerials.TabIndex = 8;
            // 
            // pbProgress
            // 
            pbProgress.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pbProgress.Location = new System.Drawing.Point(458, 55);
            pbProgress.Name = "pbProgress";
            pbProgress.Size = new System.Drawing.Size(125, 23);
            pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            pbProgress.TabIndex = 11;
            pbProgress.Visible = false;
            // 
            // BtnTest
            // 
            BtnTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BtnTest.DialogResult = System.Windows.Forms.DialogResult.OK;
            BtnTest.Location = new System.Drawing.Point(459, 424);
            BtnTest.Name = "BtnTest";
            BtnTest.Size = new System.Drawing.Size(125, 37);
            BtnTest.TabIndex = 2;
            BtnTest.Text = "&Test a key";
            BtnTest.UseVisualStyleBackColor = true;
            BtnTest.Click += BtnTest_Click;
            // 
            // lblStatistics
            // 
            lblStatistics.AutoSize = true;
            lblStatistics.Location = new System.Drawing.Point(12, 435);
            lblStatistics.Name = "lblStatistics";
            lblStatistics.Size = new System.Drawing.Size(0, 15);
            lblStatistics.TabIndex = 12;
            // 
            // FrmGenerator
            // 
            AcceptButton = btnGenerateSerials;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(595, 473);
            Controls.Add(lblStatistics);
            Controls.Add(BtnTest);
            Controls.Add(pbProgress);
            Controls.Add(tbSerials);
            Controls.Add(label4);
            Controls.Add(tbDoNotInclude);
            Controls.Add(label3);
            Controls.Add(tbNumberOfSerials);
            Controls.Add(rbShutdown);
            Controls.Add(rbVocabulary);
            Controls.Add(rbEisat);
            Controls.Add(rbScreenshotOne);
            Controls.Add(btnGenerateSerials);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new System.Drawing.Size(500, 400);
            Name = "FrmGenerator";
            Text = "Barbez.eu License Key Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateSerials;
        private System.Windows.Forms.RadioButton rbScreenshotOne;
        private System.Windows.Forms.RadioButton rbEisat;
        private System.Windows.Forms.RadioButton rbVocabulary;
        private System.Windows.Forms.RadioButton rbShutdown;
        private System.Windows.Forms.TextBox tbNumberOfSerials;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDoNotInclude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSerials;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Label lblStatistics;
    }
}

