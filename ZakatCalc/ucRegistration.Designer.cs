namespace ZakatCalc
{
    partial class ucRegistration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSignUp = new System.Windows.Forms.Button();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(168, 215);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(56, 22);
            this.btnSignUp.TabIndex = 17;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(130, 185);
            this.cbShowPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(102, 17);
            this.cbShowPass.TabIndex = 16;
            this.cbShowPass.Text = "Show Password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(115, 155);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(110, 20);
            this.txtPass.TabIndex = 15;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(115, 123);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(110, 20);
            this.txtUsername.TabIndex = 14;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(41, 155);
            this.lblPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 13;
            this.lblPass.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(39, 125);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(115, 90);
            this.txtContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(110, 20);
            this.txtContact.TabIndex = 19;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(39, 93);
            this.lblContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(61, 13);
            this.lblContact.TabIndex = 18;
            this.lblContact.Text = "Contact No";
            // 
            // ucRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsername);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucRegistration";
            this.Size = new System.Drawing.Size(274, 314);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
    }
}
