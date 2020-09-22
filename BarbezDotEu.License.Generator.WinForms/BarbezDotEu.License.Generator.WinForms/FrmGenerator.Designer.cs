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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateSerials = new System.Windows.Forms.Button();
            this.rbScreenshotOne = new System.Windows.Forms.RadioButton();
            this.rbEisat = new System.Windows.Forms.RadioButton();
            this.rbVocabulary = new System.Windows.Forms.RadioButton();
            this.rbShutdown = new System.Windows.Forms.RadioButton();
            this.tbNumberOfSerials = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDoNotInclude = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSerials = new System.Windows.Forms.TextBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.BtnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "# of license keys to generate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "License keys to exclude:";
            // 
            // btnGenerateSerials
            // 
            this.btnGenerateSerials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateSerials.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGenerateSerials.Enabled = false;
            this.btnGenerateSerials.Location = new System.Drawing.Point(457, 12);
            this.btnGenerateSerials.Name = "btnGenerateSerials";
            this.btnGenerateSerials.Size = new System.Drawing.Size(127, 37);
            this.btnGenerateSerials.TabIndex = 2;
            this.btnGenerateSerials.Text = "&Generate keys";
            this.btnGenerateSerials.UseVisualStyleBackColor = true;
            this.btnGenerateSerials.Click += new System.EventHandler(this.BtnGenerateSerialNumber_Click);
            // 
            // rbScreenshotOne
            // 
            this.rbScreenshotOne.AutoSize = true;
            this.rbScreenshotOne.Checked = true;
            this.rbScreenshotOne.Location = new System.Drawing.Point(50, 49);
            this.rbScreenshotOne.Name = "rbScreenshotOne";
            this.rbScreenshotOne.Size = new System.Drawing.Size(129, 19);
            this.rbScreenshotOne.TabIndex = 3;
            this.rbScreenshotOne.TabStop = true;
            this.rbScreenshotOne.Text = "&Screenshot One Pro";
            this.rbScreenshotOne.UseVisualStyleBackColor = true;
            this.rbScreenshotOne.CheckedChanged += new System.EventHandler(this.rbScreenshotOne_CheckedChanged);
            // 
            // rbEisat
            // 
            this.rbEisat.AutoSize = true;
            this.rbEisat.Location = new System.Drawing.Point(185, 49);
            this.rbEisat.Name = "rbEisat";
            this.rbEisat.Size = new System.Drawing.Size(245, 19);
            this.rbEisat.TabIndex = 4;
            this.rbEisat.Text = "&Experience Index System Assessment Tool";
            this.rbEisat.UseVisualStyleBackColor = true;
            this.rbEisat.CheckedChanged += new System.EventHandler(this.rbEisat_CheckedChanged);
            // 
            // rbVocabulary
            // 
            this.rbVocabulary.AutoSize = true;
            this.rbVocabulary.Location = new System.Drawing.Point(51, 75);
            this.rbVocabulary.Name = "rbVocabulary";
            this.rbVocabulary.Size = new System.Drawing.Size(99, 19);
            this.rbVocabulary.TabIndex = 5;
            this.rbVocabulary.Text = "&Vocabulary++";
            this.rbVocabulary.UseVisualStyleBackColor = true;
            this.rbVocabulary.CheckedChanged += new System.EventHandler(this.rbVocabulary_CheckedChanged);
            // 
            // rbShutdown
            // 
            this.rbShutdown.AutoSize = true;
            this.rbShutdown.Location = new System.Drawing.Point(157, 75);
            this.rbShutdown.Name = "rbShutdown";
            this.rbShutdown.Size = new System.Drawing.Size(79, 19);
            this.rbShutdown.TabIndex = 6;
            this.rbShutdown.Text = "S&hutdown";
            this.rbShutdown.UseVisualStyleBackColor = true;
            this.rbShutdown.CheckedChanged += new System.EventHandler(this.rbShutdown_CheckedChanged);
            // 
            // tbNumberOfSerials
            // 
            this.tbNumberOfSerials.Location = new System.Drawing.Point(185, 13);
            this.tbNumberOfSerials.Name = "tbNumberOfSerials";
            this.tbNumberOfSerials.PlaceholderText = "max. 100000";
            this.tbNumberOfSerials.Size = new System.Drawing.Size(80, 23);
            this.tbNumberOfSerials.TabIndex = 1;
            this.tbNumberOfSerials.TextChanged += new System.EventHandler(this.TbNumberOfSerials_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "App:";
            // 
            // tbDoNotInclude
            // 
            this.tbDoNotInclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDoNotInclude.Location = new System.Drawing.Point(12, 127);
            this.tbDoNotInclude.Multiline = true;
            this.tbDoNotInclude.Name = "tbDoNotInclude";
            this.tbDoNotInclude.PlaceholderText = "Type or paste any license keys to exclude from the list of generated license keys" +
    " (one per line).";
            this.tbDoNotInclude.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDoNotInclude.Size = new System.Drawing.Size(571, 73);
            this.tbDoNotInclude.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Generated license keys:";
            // 
            // tbSerials
            // 
            this.tbSerials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSerials.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbSerials.Location = new System.Drawing.Point(12, 230);
            this.tbSerials.Multiline = true;
            this.tbSerials.Name = "tbSerials";
            this.tbSerials.PlaceholderText = "Your generated license keys will appear here.";
            this.tbSerials.ReadOnly = true;
            this.tbSerials.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSerials.Size = new System.Drawing.Size(571, 188);
            this.tbSerials.TabIndex = 8;
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(458, 55);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(125, 23);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbProgress.TabIndex = 11;
            this.pbProgress.Visible = false;
            // 
            // BtnTest
            // 
            this.BtnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTest.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnTest.Location = new System.Drawing.Point(459, 424);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(125, 37);
            this.BtnTest.TabIndex = 2;
            this.BtnTest.Text = "&Test a key";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // FrmGenerator
            // 
            this.AcceptButton = this.btnGenerateSerials;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 473);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.tbSerials);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDoNotInclude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNumberOfSerials);
            this.Controls.Add(this.rbShutdown);
            this.Controls.Add(this.rbVocabulary);
            this.Controls.Add(this.rbEisat);
            this.Controls.Add(this.rbScreenshotOne);
            this.Controls.Add(this.btnGenerateSerials);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FrmGenerator";
            this.Text = "Barbez.eu License Key Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

