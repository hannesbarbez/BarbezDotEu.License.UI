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
            this.BtnPaste = new System.Windows.Forms.Button();
            this.TbSerial1 = new System.Windows.Forms.TextBox();
            this.TbSerial2 = new System.Windows.Forms.TextBox();
            this.TbSerial3 = new System.Windows.Forms.TextBox();
            this.TbSerial4 = new System.Windows.Forms.TextBox();
            this.TbSerial5 = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPaste
            // 
            this.BtnPaste.Font = new System.Drawing.Font("Wingdings 2", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPaste.Location = new System.Drawing.Point(13, 13);
            this.BtnPaste.Name = "BtnPaste";
            this.BtnPaste.Size = new System.Drawing.Size(40, 29);
            this.BtnPaste.TabIndex = 0;
            this.BtnPaste.Text = "2";
            this.BtnPaste.UseVisualStyleBackColor = true;
            this.BtnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // TbSerial1
            // 
            this.TbSerial1.Location = new System.Drawing.Point(68, 17);
            this.TbSerial1.Name = "TbSerial1";
            this.TbSerial1.Size = new System.Drawing.Size(53, 23);
            this.TbSerial1.TabIndex = 1;
            this.TbSerial1.TextChanged += new System.EventHandler(this.TbSerial1_TextChanged);
            // 
            // TbSerial2
            // 
            this.TbSerial2.Location = new System.Drawing.Point(127, 17);
            this.TbSerial2.Name = "TbSerial2";
            this.TbSerial2.Size = new System.Drawing.Size(53, 23);
            this.TbSerial2.TabIndex = 1;
            this.TbSerial2.TextChanged += new System.EventHandler(this.TbSerial2_TextChanged);
            // 
            // TbSerial3
            // 
            this.TbSerial3.Location = new System.Drawing.Point(186, 17);
            this.TbSerial3.Name = "TbSerial3";
            this.TbSerial3.Size = new System.Drawing.Size(53, 23);
            this.TbSerial3.TabIndex = 1;
            this.TbSerial3.TextChanged += new System.EventHandler(this.TbSerial3_TextChanged);
            // 
            // TbSerial4
            // 
            this.TbSerial4.Location = new System.Drawing.Point(245, 17);
            this.TbSerial4.Name = "TbSerial4";
            this.TbSerial4.Size = new System.Drawing.Size(53, 23);
            this.TbSerial4.TabIndex = 1;
            this.TbSerial4.TextChanged += new System.EventHandler(this.TbSerial4_TextChanged);
            // 
            // TbSerial5
            // 
            this.TbSerial5.Location = new System.Drawing.Point(304, 17);
            this.TbSerial5.Name = "TbSerial5";
            this.TbSerial5.Size = new System.Drawing.Size(53, 23);
            this.TbSerial5.TabIndex = 1;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(363, 13);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(40, 29);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "&OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(418, 62);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(10, 10);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Quit";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmValidator
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(418, 58);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TbSerial5);
            this.Controls.Add(this.TbSerial4);
            this.Controls.Add(this.TbSerial3);
            this.Controls.Add(this.TbSerial2);
            this.Controls.Add(this.TbSerial1);
            this.Controls.Add(this.BtnPaste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmValidator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Barbez.eu License Key Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

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
