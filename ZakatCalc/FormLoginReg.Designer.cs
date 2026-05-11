namespace ZakatCalc
{
    partial class FormLoginReg
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
            pnlRegLogin = new System.Windows.Forms.Panel();
            cbReg = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // pnlRegLogin
            // 
            pnlRegLogin.Location = new System.Drawing.Point(10, 93);
            pnlRegLogin.Margin = new System.Windows.Forms.Padding(2);
            pnlRegLogin.Name = "pnlRegLogin";
            pnlRegLogin.Size = new System.Drawing.Size(320, 362);
            pnlRegLogin.TabIndex = 0;
            // 
            // cbReg
            // 
            cbReg.AutoSize = true;
            cbReg.Location = new System.Drawing.Point(124, 69);
            cbReg.Margin = new System.Windows.Forms.Padding(2);
            cbReg.Name = "cbReg";
            cbReg.Size = new System.Drawing.Size(89, 19);
            cbReg.TabIndex = 1;
            cbReg.Text = "Registration";
            cbReg.UseVisualStyleBackColor = true;
            cbReg.CheckedChanged += cbReg_CheckedChanged;
            // 
            // FormLoginReg
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonFace;
            ClientSize = new System.Drawing.Size(341, 467);
            Controls.Add(cbReg);
            Controls.Add(pnlRegLogin);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "FormLoginReg";
            Text = "Login and Registration";
            Load += FormLoginReg_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegLogin;
        private System.Windows.Forms.CheckBox cbReg;
    }
}

