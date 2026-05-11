namespace ZakatCalc
{
    partial class FormAdmin
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
            this.pnlButtonsContainer = new System.Windows.Forms.Panel();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOrgs = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.pnlHolder = new System.Windows.Forms.Panel();
            this.pnlButtonsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtonsContainer
            // 
            this.pnlButtonsContainer.Controls.Add(this.btnStats);
            this.pnlButtonsContainer.Controls.Add(this.btnSignOut);
            this.pnlButtonsContainer.Controls.Add(this.btnLogout);
            this.pnlButtonsContainer.Controls.Add(this.btnOrgs);
            this.pnlButtonsContainer.Controls.Add(this.lblWelcome);
            this.pnlButtonsContainer.Controls.Add(this.btnUsers);
            this.pnlButtonsContainer.Controls.Add(this.btnCalc);
            this.pnlButtonsContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtonsContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonsContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButtonsContainer.Name = "pnlButtonsContainer";
            this.pnlButtonsContainer.Size = new System.Drawing.Size(210, 537);
            this.pnlButtonsContainer.TabIndex = 1;
            // 
            // btnStats
            // 
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(9, 394);
            this.btnStats.Margin = new System.Windows.Forms.Padding(2);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(188, 39);
            this.btnStats.TabIndex = 12;
            this.btnStats.Text = "Statements";
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(64, 497);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(88, 29);
            this.btnSignOut.TabIndex = 11;
            this.btnSignOut.Text = "<- Log out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(68, 552);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 25);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnOrgs
            // 
            this.btnOrgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrgs.Location = new System.Drawing.Point(9, 333);
            this.btnOrgs.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrgs.Name = "btnOrgs";
            this.btnOrgs.Size = new System.Drawing.Size(188, 39);
            this.btnOrgs.TabIndex = 10;
            this.btnOrgs.Text = "Organizations";
            this.btnOrgs.UseVisualStyleBackColor = true;
            this.btnOrgs.Click += new System.EventHandler(this.btnOrgs_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(60, 31);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(122, 29);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(9, 277);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(188, 39);
            this.btnUsers.TabIndex = 9;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(9, 223);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(188, 39);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculator";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // pnlHolder
            // 
            this.pnlHolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHolder.Location = new System.Drawing.Point(211, 0);
            this.pnlHolder.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHolder.Name = "pnlHolder";
            this.pnlHolder.Size = new System.Drawing.Size(677, 537);
            this.pnlHolder.TabIndex = 2;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(888, 537);
            this.Controls.Add(this.pnlHolder);
            this.Controls.Add(this.pnlButtonsContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmin";
            this.Text = "Admin Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.pnlButtonsContainer.ResumeLayout(false);
            this.pnlButtonsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtonsContainer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHolder;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnOrgs;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblWelcome;
    }
}