namespace BarbezDotEu.License.Generator.WinForms
{
    partial class FrmValidator
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValidator));
            BtnPaste = new System.Windows.Forms.Button();
            TbSerial1 = new System.Windows.Forms.TextBox();
            TbSerial2 = new System.Windows.Forms.TextBox();
            TbSerial3 = new System.Windows.Forms.TextBox();
            TbSerial4 = new System.Windows.Forms.TextBox();
            TbSerial5 = new System.Windows.Forms.TextBox();
            BtnOk = new System.Windows.Forms.Button();
            BtnClose = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // BtnPaste
            // 
            BtnPaste.Font = new System.Drawing.Font("Wingdings 2", 11F);
            BtnPaste.Location = new System.Drawing.Point(13, 13);
            BtnPaste.Name = "BtnPaste";
            BtnPaste.Size = new System.Drawing.Size(40, 29);
            BtnPaste.TabIndex = 0;
            BtnPaste.Text = "2";
            BtnPaste.UseVisualStyleBackColor = true;
            BtnPaste.Click += BtnPaste_Click;
            // 
            // TbSerial1
            // 
            TbSerial1.Location = new System.Drawing.Point(68, 17);
            TbSerial1.Name = "TbSerial1";
            TbSerial1.Size = new System.Drawing.Size(53, 23);
            TbSerial1.TabIndex = 1;
            TbSerial1.TextChanged += TbSerial1_TextChanged;
            // 
            // TbSerial2
            // 
            TbSerial2.Location = new System.Drawing.Point(127, 17);
            TbSerial2.Name = "TbSerial2";
            TbSerial2.Size = new System.Drawing.Size(53, 23);
            TbSerial2.TabIndex = 1;
            TbSerial2.TextChanged += TbSerial2_TextChanged;
            // 
            // TbSerial3
            // 
            TbSerial3.Location = new System.Drawing.Point(186, 17);
            TbSerial3.Name = "TbSerial3";
            TbSerial3.Size = new System.Drawing.Size(53, 23);
            TbSerial3.TabIndex = 1;
            TbSerial3.TextChanged += TbSerial3_TextChanged;
            // 
            // TbSerial4
            // 
            TbSerial4.Location = new System.Drawing.Point(245, 17);
            TbSerial4.Name = "TbSerial4";
            TbSerial4.Size = new System.Drawing.Size(53, 23);
            TbSerial4.TabIndex = 1;
            TbSerial4.TextChanged += TbSerial4_TextChanged;
            // 
            // TbSerial5
            // 
            TbSerial5.Location = new System.Drawing.Point(304, 17);
            TbSerial5.Name = "TbSerial5";
            TbSerial5.Size = new System.Drawing.Size(53, 23);
            TbSerial5.TabIndex = 1;
            // 
            // BtnOk
            // 
            BtnOk.Location = new System.Drawing.Point(363, 13);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new System.Drawing.Size(40, 29);
            BtnOk.TabIndex = 0;
            BtnOk.Text = "&OK";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnClose
            // 
            BtnClose.Location = new System.Drawing.Point(418, 62);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new System.Drawing.Size(10, 10);
            BtnClose.TabIndex = 2;
            BtnClose.Text = "Quit";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // FrmValidator
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = BtnClose;
            ClientSize = new System.Drawing.Size(418, 58);
            Controls.Add(BtnClose);
            Controls.Add(BtnOk);
            Controls.Add(TbSerial5);
            Controls.Add(TbSerial4);
            Controls.Add(TbSerial3);
            Controls.Add(TbSerial2);
            Controls.Add(TbSerial1);
            Controls.Add(BtnPaste);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmValidator";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Barbez.eu License Key Validator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BtnPaste;
        private System.Windows.Forms.TextBox TbSerial1;
        private System.Windows.Forms.TextBox TbSerial2;
        private System.Windows.Forms.TextBox TbSerial3;
        private System.Windows.Forms.TextBox TbSerial4;
        private System.Windows.Forms.TextBox TbSerial5;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnClose;
    }
}
