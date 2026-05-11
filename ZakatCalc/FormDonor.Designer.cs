namespace ZakatCalc
{
    partial class FormDonor
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
            pnlHolder = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            pnlLoader = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            pnlButtonsContainer = new System.Windows.Forms.Panel();
            btnHistory = new System.Windows.Forms.Button();
            btnLog = new System.Windows.Forms.Button();
            btnProfile = new System.Windows.Forms.Button();
            btnCalc = new System.Windows.Forms.Button();
            lblWelcome = new System.Windows.Forms.Label();
            btnLogout = new System.Windows.Forms.Button();
            pnlHolder.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlButtonsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHolder
            // 
            pnlHolder.Controls.Add(panel1);
            pnlHolder.Controls.Add(panel2);
            pnlHolder.Dock = System.Windows.Forms.DockStyle.Right;
            pnlHolder.Location = new System.Drawing.Point(246, 0);
            pnlHolder.Margin = new System.Windows.Forms.Padding(2);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new System.Drawing.Size(790, 620);
            pnlHolder.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlLoader);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(790, 620);
            panel1.TabIndex = 4;
            // 
            // pnlLoader
            // 
            pnlLoader.Location = new System.Drawing.Point(2, 2);
            pnlLoader.Margin = new System.Windows.Forms.Padding(2);
            pnlLoader.Name = "pnlLoader";
            pnlLoader.Size = new System.Drawing.Size(790, 620);
            pnlLoader.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label1);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(630, 620);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.Location = new System.Drawing.Point(85, 575);
            button1.Margin = new System.Windows.Forms.Padding(2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(64, 33);
            button1.TabIndex = 5;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button2.Location = new System.Drawing.Point(79, 637);
            button2.Margin = new System.Windows.Forms.Padding(2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(96, 29);
            button2.TabIndex = 4;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button3.Location = new System.Drawing.Point(10, 456);
            button3.Margin = new System.Windows.Forms.Padding(2);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(219, 45);
            button3.TabIndex = 3;
            button3.Text = "History";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button4.Location = new System.Drawing.Point(10, 391);
            button4.Margin = new System.Windows.Forms.Padding(2);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(219, 45);
            button4.TabIndex = 2;
            button4.Text = "Profile";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button5.Location = new System.Drawing.Point(10, 329);
            button5.Margin = new System.Windows.Forms.Padding(2);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(219, 45);
            button5.TabIndex = 1;
            button5.Text = "Calculator";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(70, 37);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 29);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // pnlButtonsContainer
            // 
            pnlButtonsContainer.Controls.Add(btnHistory);
            pnlButtonsContainer.Controls.Add(btnLog);
            pnlButtonsContainer.Controls.Add(btnProfile);
            pnlButtonsContainer.Controls.Add(btnCalc);
            pnlButtonsContainer.Controls.Add(lblWelcome);
            pnlButtonsContainer.Controls.Add(btnLogout);
            pnlButtonsContainer.Dock = System.Windows.Forms.DockStyle.Left;
            pnlButtonsContainer.Location = new System.Drawing.Point(0, 0);
            pnlButtonsContainer.Margin = new System.Windows.Forms.Padding(2);
            pnlButtonsContainer.Name = "pnlButtonsContainer";
            pnlButtonsContainer.Size = new System.Drawing.Size(245, 620);
            pnlButtonsContainer.TabIndex = 3;
            // 
            // btnHistory
            // 
            btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnHistory.Location = new System.Drawing.Point(13, 461);
            btnHistory.Margin = new System.Windows.Forms.Padding(2);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new System.Drawing.Size(219, 45);
            btnHistory.TabIndex = 11;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click_1;
            // 
            // btnLog
            // 
            btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLog.Location = new System.Drawing.Point(77, 562);
            btnLog.Margin = new System.Windows.Forms.Padding(2);
            btnLog.Name = "btnLog";
            btnLog.Size = new System.Drawing.Size(103, 33);
            btnLog.TabIndex = 10;
            btnLog.Text = "<- Log out";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click_1;
            // 
            // btnProfile
            // 
            btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnProfile.Location = new System.Drawing.Point(13, 398);
            btnProfile.Margin = new System.Windows.Forms.Padding(2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new System.Drawing.Size(219, 45);
            btnProfile.TabIndex = 8;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnCalc
            // 
            btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCalc.Location = new System.Drawing.Point(13, 337);
            btnCalc.Margin = new System.Windows.Forms.Padding(2);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new System.Drawing.Size(219, 45);
            btnCalc.TabIndex = 7;
            btnCalc.Text = "Calculator";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblWelcome.Location = new System.Drawing.Point(60, 27);
            lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(122, 29);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Welcome";
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
            // FormDonor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1036, 620);
            Controls.Add(pnlHolder);
            Controls.Add(pnlButtonsContainer);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "FormDonor";
            Text = "Donor Dashboard";
            FormClosing += FormDonor_FormClosing;
            Load += FormDonor_Load;
            pnlHolder.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlButtonsContainer.ResumeLayout(false);
            pnlButtonsContainer.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHolder;
        private System.Windows.Forms.Panel pnlButtonsContainer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLoader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnHistory;
    }
}