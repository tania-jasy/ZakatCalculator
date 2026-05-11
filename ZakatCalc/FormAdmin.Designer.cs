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
            pnlButtonsContainer = new System.Windows.Forms.Panel();
            btnStats = new System.Windows.Forms.Button();
            btnSignOut = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            btnOrgs = new System.Windows.Forms.Button();
            lblWelcome = new System.Windows.Forms.Label();
            btnUsers = new System.Windows.Forms.Button();
            btnCalc = new System.Windows.Forms.Button();
            pnlHolder = new System.Windows.Forms.Panel();
            pnlButtonsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlButtonsContainer
            // 
            pnlButtonsContainer.Controls.Add(btnStats);
            pnlButtonsContainer.Controls.Add(btnSignOut);
            pnlButtonsContainer.Controls.Add(btnLogout);
            pnlButtonsContainer.Controls.Add(btnOrgs);
            pnlButtonsContainer.Controls.Add(lblWelcome);
            pnlButtonsContainer.Controls.Add(btnUsers);
            pnlButtonsContainer.Controls.Add(btnCalc);
            pnlButtonsContainer.Dock = System.Windows.Forms.DockStyle.Left;
            pnlButtonsContainer.Location = new System.Drawing.Point(0, 0);
            pnlButtonsContainer.Margin = new System.Windows.Forms.Padding(2);
            pnlButtonsContainer.Name = "pnlButtonsContainer";
            pnlButtonsContainer.Size = new System.Drawing.Size(245, 620);
            pnlButtonsContainer.TabIndex = 1;
            // 
            // btnStats
            // 
            btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnStats.Location = new System.Drawing.Point(10, 455);
            btnStats.Margin = new System.Windows.Forms.Padding(2);
            btnStats.Name = "btnStats";
            btnStats.Size = new System.Drawing.Size(219, 45);
            btnStats.TabIndex = 12;
            btnStats.Text = "Statements";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSignOut.Location = new System.Drawing.Point(75, 573);
            btnSignOut.Margin = new System.Windows.Forms.Padding(2);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new System.Drawing.Size(103, 33);
            btnSignOut.TabIndex = 11;
            btnSignOut.Text = "<- Log out";
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += button1_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLogout.Location = new System.Drawing.Point(79, 637);
            btnLogout.Margin = new System.Windows.Forms.Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(96, 29);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnOrgs
            // 
            btnOrgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnOrgs.Location = new System.Drawing.Point(10, 384);
            btnOrgs.Margin = new System.Windows.Forms.Padding(2);
            btnOrgs.Name = "btnOrgs";
            btnOrgs.Size = new System.Drawing.Size(219, 45);
            btnOrgs.TabIndex = 10;
            btnOrgs.Text = "Organizations";
            btnOrgs.UseVisualStyleBackColor = true;
            btnOrgs.Click += btnOrgs_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblWelcome.Location = new System.Drawing.Point(70, 36);
            lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(122, 29);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "Welcome";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // btnUsers
            // 
            btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUsers.Location = new System.Drawing.Point(10, 320);
            btnUsers.Margin = new System.Windows.Forms.Padding(2);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new System.Drawing.Size(219, 45);
            btnUsers.TabIndex = 9;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnCalc
            // 
            btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCalc.Location = new System.Drawing.Point(10, 257);
            btnCalc.Margin = new System.Windows.Forms.Padding(2);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new System.Drawing.Size(219, 45);
            btnCalc.TabIndex = 8;
            btnCalc.Text = "Calculator";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // pnlHolder
            // 
            pnlHolder.Dock = System.Windows.Forms.DockStyle.Right;
            pnlHolder.Location = new System.Drawing.Point(246, 0);
            pnlHolder.Margin = new System.Windows.Forms.Padding(2);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new System.Drawing.Size(790, 620);
            pnlHolder.TabIndex = 2;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Tan;
            ClientSize = new System.Drawing.Size(1036, 620);
            Controls.Add(pnlHolder);
            Controls.Add(pnlButtonsContainer);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "FormAdmin";
            Text = "Admin Dashboard";
            FormClosing += FormAdmin_FormClosing;
            Load += FormAdmin_Load;
            pnlButtonsContainer.ResumeLayout(false);
            pnlButtonsContainer.PerformLayout();
            ResumeLayout(false);

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