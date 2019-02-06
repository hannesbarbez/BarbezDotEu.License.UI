namespace Serial_Number_Generator
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnGenerateSerials = new System.Windows.Forms.Button();
            this.tbSerials = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumberOfSerials = new System.Windows.Forms.TextBox();
            this.rbScreenshotOne = new System.Windows.Forms.RadioButton();
            this.rbEisat = new System.Windows.Forms.RadioButton();
            this.rbVocabulary = new System.Windows.Forms.RadioButton();
            this.rbShutdown = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDoNotInclude = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerateSerials
            // 
            this.btnGenerateSerials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateSerials.Location = new System.Drawing.Point(393, 12);
            this.btnGenerateSerials.Name = "btnGenerateSerials";
            this.btnGenerateSerials.Size = new System.Drawing.Size(119, 23);
            this.btnGenerateSerials.TabIndex = 0;
            this.btnGenerateSerials.Text = "Generate Serials";
            this.btnGenerateSerials.UseVisualStyleBackColor = true;
            this.btnGenerateSerials.Click += new System.EventHandler(this.btnGenerateSerialNumber_Click);
            // 
            // tbSerials
            // 
            this.tbSerials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSerials.Location = new System.Drawing.Point(12, 86);
            this.tbSerials.Multiline = true;
            this.tbSerials.Name = "tbSerials";
            this.tbSerials.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSerials.Size = new System.Drawing.Size(500, 183);
            this.tbSerials.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "# of serials to generate:";
            // 
            // tbNumberOfSerials
            // 
            this.tbNumberOfSerials.Location = new System.Drawing.Point(136, 14);
            this.tbNumberOfSerials.MaxLength = 5;
            this.tbNumberOfSerials.Name = "tbNumberOfSerials";
            this.tbNumberOfSerials.Size = new System.Drawing.Size(44, 20);
            this.tbNumberOfSerials.TabIndex = 3;
            // 
            // rbScreenshotOne
            // 
            this.rbScreenshotOne.AutoSize = true;
            this.rbScreenshotOne.Location = new System.Drawing.Point(15, 40);
            this.rbScreenshotOne.Name = "rbScreenshotOne";
            this.rbScreenshotOne.Size = new System.Drawing.Size(121, 17);
            this.rbScreenshotOne.TabIndex = 4;
            this.rbScreenshotOne.Text = "Screenshot One Pro";
            this.rbScreenshotOne.UseVisualStyleBackColor = true;
            // 
            // rbEisat
            // 
            this.rbEisat.AutoSize = true;
            this.rbEisat.Location = new System.Drawing.Point(142, 40);
            this.rbEisat.Name = "rbEisat";
            this.rbEisat.Size = new System.Drawing.Size(227, 17);
            this.rbEisat.TabIndex = 5;
            this.rbEisat.Text = "Experience Index System Assessment Tool";
            this.rbEisat.UseVisualStyleBackColor = true;
            // 
            // rbVocabulary
            // 
            this.rbVocabulary.AutoSize = true;
            this.rbVocabulary.Location = new System.Drawing.Point(15, 63);
            this.rbVocabulary.Name = "rbVocabulary";
            this.rbVocabulary.Size = new System.Drawing.Size(90, 17);
            this.rbVocabulary.TabIndex = 6;
            this.rbVocabulary.Text = "Vocabulary++";
            this.rbVocabulary.UseVisualStyleBackColor = true;
            // 
            // rbShutdown
            // 
            this.rbShutdown.AutoSize = true;
            this.rbShutdown.Checked = true;
            this.rbShutdown.Location = new System.Drawing.Point(142, 63);
            this.rbShutdown.Name = "rbShutdown";
            this.rbShutdown.Size = new System.Drawing.Size(73, 17);
            this.rbShutdown.TabIndex = 7;
            this.rbShutdown.TabStop = true;
            this.rbShutdown.Text = "Shutdown";
            this.rbShutdown.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Do not include:";
            // 
            // tbDoNotInclude
            // 
            this.tbDoNotInclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDoNotInclude.Location = new System.Drawing.Point(12, 288);
            this.tbDoNotInclude.MaxLength = 2048000;
            this.tbDoNotInclude.Multiline = true;
            this.tbDoNotInclude.Name = "tbDoNotInclude";
            this.tbDoNotInclude.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDoNotInclude.Size = new System.Drawing.Size(500, 137);
            this.tbDoNotInclude.TabIndex = 9;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 437);
            this.Controls.Add(this.tbDoNotInclude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbShutdown);
            this.Controls.Add(this.rbVocabulary);
            this.Controls.Add(this.rbEisat);
            this.Controls.Add(this.rbScreenshotOne);
            this.Controls.Add(this.tbNumberOfSerials);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSerials);
            this.Controls.Add(this.btnGenerateSerials);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "MicroHann Serial Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateSerials;
        private System.Windows.Forms.TextBox tbSerials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumberOfSerials;
        private System.Windows.Forms.RadioButton rbScreenshotOne;
        private System.Windows.Forms.RadioButton rbEisat;
        private System.Windows.Forms.RadioButton rbVocabulary;
        private System.Windows.Forms.RadioButton rbShutdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDoNotInclude;
    }
}

