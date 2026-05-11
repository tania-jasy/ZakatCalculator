namespace ZakatCalc
{
    partial class ucCalculator
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
            lblAssets = new System.Windows.Forms.Label();
            lblLiabilities = new System.Windows.Forms.Label();
            lblVar = new System.Windows.Forms.Label();
            gbCalculate = new System.Windows.Forms.GroupBox();
            btnCalculate = new System.Windows.Forms.Button();
            rbSilver = new System.Windows.Forms.RadioButton();
            rbGold = new System.Windows.Forms.RadioButton();
            lblSelection = new System.Windows.Forms.Label();
            lblReport = new System.Windows.Forms.Label();
            lblZakatable = new System.Windows.Forms.Label();
            lblNisab = new System.Windows.Forms.Label();
            lblDue = new System.Windows.Forms.Label();
            txtCash = new System.Windows.Forms.TextBox();
            txtBank = new System.Windows.Forms.TextBox();
            txtGoldSilverValue = new System.Windows.Forms.TextBox();
            txtStocks = new System.Windows.Forms.TextBox();
            txtInventory = new System.Windows.Forms.TextBox();
            txtRecievables = new System.Windows.Forms.TextBox();
            txtRental = new System.Windows.Forms.TextBox();
            txtBillsDue = new System.Windows.Forms.TextBox();
            txtLoans = new System.Windows.Forms.TextBox();
            txtDebts = new System.Windows.Forms.TextBox();
            txtSilverPerGram = new System.Windows.Forms.TextBox();
            txtGoldPerGram = new System.Windows.Forms.TextBox();
            btnSet = new System.Windows.Forms.Button();
            lblGold = new System.Windows.Forms.Label();
            lblSilver = new System.Windows.Forms.Label();
            btnDonate = new System.Windows.Forms.Button();
            gbCalculate.SuspendLayout();
            SuspendLayout();
            // 
            // lblAssets
            // 
            lblAssets.AutoSize = true;
            lblAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAssets.Location = new System.Drawing.Point(27, 27);
            lblAssets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAssets.Name = "lblAssets";
            lblAssets.Size = new System.Drawing.Size(83, 25);
            lblAssets.TabIndex = 0;
            lblAssets.Text = "Assets";
            // 
            // lblLiabilities
            // 
            lblLiabilities.AutoSize = true;
            lblLiabilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLiabilities.Location = new System.Drawing.Point(27, 332);
            lblLiabilities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLiabilities.Name = "lblLiabilities";
            lblLiabilities.Size = new System.Drawing.Size(107, 25);
            lblLiabilities.TabIndex = 1;
            lblLiabilities.Text = "Liablities";
            // 
            // lblVar
            // 
            lblVar.AutoSize = true;
            lblVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblVar.Location = new System.Drawing.Point(422, 27);
            lblVar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVar.Name = "lblVar";
            lblVar.Size = new System.Drawing.Size(151, 25);
            lblVar.TabIndex = 2;
            lblVar.Text = "Current Price";
            // 
            // gbCalculate
            // 
            gbCalculate.Controls.Add(btnCalculate);
            gbCalculate.Controls.Add(rbSilver);
            gbCalculate.Controls.Add(rbGold);
            gbCalculate.Controls.Add(lblSelection);
            gbCalculate.Location = new System.Drawing.Point(428, 170);
            gbCalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbCalculate.Name = "gbCalculate";
            gbCalculate.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbCalculate.Size = new System.Drawing.Size(317, 113);
            gbCalculate.TabIndex = 3;
            gbCalculate.TabStop = false;
            gbCalculate.Enter += gbCalculate_Enter;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = System.Drawing.Color.DimGray;
            btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = System.Drawing.Color.White;
            btnCalculate.Location = new System.Drawing.Point(7, 62);
            btnCalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(303, 44);
            btnCalculate.TabIndex = 18;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // rbSilver
            // 
            rbSilver.AutoSize = true;
            rbSilver.Location = new System.Drawing.Point(97, 40);
            rbSilver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbSilver.Name = "rbSilver";
            rbSilver.Size = new System.Drawing.Size(53, 19);
            rbSilver.TabIndex = 20;
            rbSilver.TabStop = true;
            rbSilver.Text = "Silver";
            rbSilver.UseVisualStyleBackColor = true;
            // 
            // rbGold
            // 
            rbGold.AutoSize = true;
            rbGold.Location = new System.Drawing.Point(18, 40);
            rbGold.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbGold.Name = "rbGold";
            rbGold.Size = new System.Drawing.Size(50, 19);
            rbGold.TabIndex = 19;
            rbGold.TabStop = true;
            rbGold.Text = "Gold";
            rbGold.UseVisualStyleBackColor = true;
            // 
            // lblSelection
            // 
            lblSelection.AutoSize = true;
            lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSelection.Location = new System.Drawing.Point(7, 12);
            lblSelection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSelection.Name = "lblSelection";
            lblSelection.Size = new System.Drawing.Size(183, 16);
            lblSelection.TabIndex = 21;
            lblSelection.Text = "Select Nisab as per your wish";
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblReport.Location = new System.Drawing.Point(422, 332);
            lblReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReport.Name = "lblReport";
            lblReport.Size = new System.Drawing.Size(82, 25);
            lblReport.TabIndex = 4;
            lblReport.Text = "Report";
            // 
            // lblZakatable
            // 
            lblZakatable.AutoSize = true;
            lblZakatable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblZakatable.Location = new System.Drawing.Point(425, 384);
            lblZakatable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblZakatable.Name = "lblZakatable";
            lblZakatable.Size = new System.Drawing.Size(160, 18);
            lblZakatable.TabIndex = 5;
            lblZakatable.Text = "Zakatable Amount - 0.0";
            // 
            // lblNisab
            // 
            lblNisab.AutoSize = true;
            lblNisab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblNisab.Location = new System.Drawing.Point(425, 419);
            lblNisab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNisab.Name = "lblNisab";
            lblNisab.Size = new System.Drawing.Size(127, 18);
            lblNisab.TabIndex = 6;
            lblNisab.Text = "Nisab at time - 0.0";
            // 
            // lblDue
            // 
            lblDue.AutoSize = true;
            lblDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDue.Location = new System.Drawing.Point(425, 455);
            lblDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDue.Name = "lblDue";
            lblDue.Size = new System.Drawing.Size(109, 18);
            lblDue.TabIndex = 7;
            lblDue.Text = "Zakat Due - 0.0";
            // 
            // txtCash
            // 
            txtCash.Location = new System.Drawing.Point(33, 80);
            txtCash.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCash.Name = "txtCash";
            txtCash.PlaceholderText = "Cash Savings";
            txtCash.Size = new System.Drawing.Size(204, 23);
            txtCash.TabIndex = 8;
            // 
            // txtBank
            // 
            txtBank.Location = new System.Drawing.Point(33, 110);
            txtBank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtBank.Name = "txtBank";
            txtBank.PlaceholderText = "Bank Balance";
            txtBank.Size = new System.Drawing.Size(204, 23);
            txtBank.TabIndex = 9;
            // 
            // txtGoldSilverValue
            // 
            txtGoldSilverValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtGoldSilverValue.Location = new System.Drawing.Point(33, 140);
            txtGoldSilverValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtGoldSilverValue.Name = "txtGoldSilverValue";
            txtGoldSilverValue.PlaceholderText = "Gold/Silver values";
            txtGoldSilverValue.Size = new System.Drawing.Size(204, 23);
            txtGoldSilverValue.TabIndex = 10;
            // 
            // txtStocks
            // 
            txtStocks.Location = new System.Drawing.Point(33, 170);
            txtStocks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtStocks.Name = "txtStocks";
            txtStocks.PlaceholderText = "Stocks Value";
            txtStocks.Size = new System.Drawing.Size(204, 23);
            txtStocks.TabIndex = 11;
            // 
            // txtInventory
            // 
            txtInventory.Location = new System.Drawing.Point(33, 200);
            txtInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtInventory.Name = "txtInventory";
            txtInventory.PlaceholderText = "Business Inventory";
            txtInventory.Size = new System.Drawing.Size(204, 23);
            txtInventory.TabIndex = 12;
            // 
            // txtRecievables
            // 
            txtRecievables.Location = new System.Drawing.Point(33, 230);
            txtRecievables.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtRecievables.Name = "txtRecievables";
            txtRecievables.PlaceholderText = "Recievables";
            txtRecievables.Size = new System.Drawing.Size(204, 23);
            txtRecievables.TabIndex = 13;
            txtRecievables.TextChanged += textBox5_TextChanged;
            // 
            // txtRental
            // 
            txtRental.Location = new System.Drawing.Point(33, 260);
            txtRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtRental.Name = "txtRental";
            txtRental.PlaceholderText = "Rental Income";
            txtRental.Size = new System.Drawing.Size(204, 23);
            txtRental.TabIndex = 14;
            // 
            // txtBillsDue
            // 
            txtBillsDue.Location = new System.Drawing.Point(33, 445);
            txtBillsDue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtBillsDue.Name = "txtBillsDue";
            txtBillsDue.PlaceholderText = "Bills Due";
            txtBillsDue.Size = new System.Drawing.Size(204, 23);
            txtBillsDue.TabIndex = 17;
            // 
            // txtLoans
            // 
            txtLoans.Location = new System.Drawing.Point(33, 415);
            txtLoans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtLoans.Name = "txtLoans";
            txtLoans.PlaceholderText = "Loans Payable";
            txtLoans.Size = new System.Drawing.Size(204, 23);
            txtLoans.TabIndex = 16;
            // 
            // txtDebts
            // 
            txtDebts.Location = new System.Drawing.Point(33, 385);
            txtDebts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDebts.Name = "txtDebts";
            txtDebts.PlaceholderText = "Debts";
            txtDebts.Size = new System.Drawing.Size(204, 23);
            txtDebts.TabIndex = 15;
            // 
            // txtSilverPerGram
            // 
            txtSilverPerGram.Location = new System.Drawing.Point(435, 107);
            txtSilverPerGram.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSilverPerGram.Name = "txtSilverPerGram";
            txtSilverPerGram.Size = new System.Drawing.Size(204, 23);
            txtSilverPerGram.TabIndex = 19;
            // 
            // txtGoldPerGram
            // 
            txtGoldPerGram.Location = new System.Drawing.Point(435, 77);
            txtGoldPerGram.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtGoldPerGram.Name = "txtGoldPerGram";
            txtGoldPerGram.Size = new System.Drawing.Size(204, 23);
            txtGoldPerGram.TabIndex = 18;
            // 
            // btnSet
            // 
            btnSet.Location = new System.Drawing.Point(435, 136);
            btnSet.Name = "btnSet";
            btnSet.Size = new System.Drawing.Size(75, 23);
            btnSet.TabIndex = 23;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.ForeColor = System.Drawing.SystemColors.WindowFrame;
            lblGold.Location = new System.Drawing.Point(646, 80);
            lblGold.Name = "lblGold";
            lblGold.Size = new System.Drawing.Size(113, 15);
            lblGold.TabIndex = 24;
            lblGold.Text = "Gold Price per Gram";
            // 
            // lblSilver
            // 
            lblSilver.AutoSize = true;
            lblSilver.ForeColor = System.Drawing.SystemColors.WindowFrame;
            lblSilver.Location = new System.Drawing.Point(648, 110);
            lblSilver.Name = "lblSilver";
            lblSilver.Size = new System.Drawing.Size(116, 15);
            lblSilver.TabIndex = 25;
            lblSilver.Text = "Silver Price per Gram";
            // 
            // btnDonate
            // 
            btnDonate.BackColor = System.Drawing.Color.DimGray;
            btnDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDonate.ForeColor = System.Drawing.Color.White;
            btnDonate.Location = new System.Drawing.Point(33, 524);
            btnDonate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDonate.Name = "btnDonate";
            btnDonate.Size = new System.Drawing.Size(706, 61);
            btnDonate.TabIndex = 22;
            btnDonate.Text = "Donate";
            btnDonate.UseVisualStyleBackColor = false;
            btnDonate.Click += btnDonate_Click;
            // 
            // ucCalculator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblSilver);
            Controls.Add(lblGold);
            Controls.Add(btnSet);
            Controls.Add(btnDonate);
            Controls.Add(txtSilverPerGram);
            Controls.Add(txtGoldPerGram);
            Controls.Add(txtBillsDue);
            Controls.Add(txtLoans);
            Controls.Add(txtDebts);
            Controls.Add(txtRental);
            Controls.Add(txtRecievables);
            Controls.Add(txtInventory);
            Controls.Add(txtStocks);
            Controls.Add(txtGoldSilverValue);
            Controls.Add(txtBank);
            Controls.Add(txtCash);
            Controls.Add(lblDue);
            Controls.Add(lblNisab);
            Controls.Add(lblZakatable);
            Controls.Add(lblReport);
            Controls.Add(gbCalculate);
            Controls.Add(lblVar);
            Controls.Add(lblLiabilities);
            Controls.Add(lblAssets);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ucCalculator";
            Size = new System.Drawing.Size(790, 620);
            gbCalculate.ResumeLayout(false);
            gbCalculate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssets;
        private System.Windows.Forms.Label lblLiabilities;
        private System.Windows.Forms.Label lblVar;
        private System.Windows.Forms.GroupBox gbCalculate;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblZakatable;
        private System.Windows.Forms.Label lblNisab;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtGoldSilverValue;
        private System.Windows.Forms.TextBox txtStocks;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtRecievables;
        private System.Windows.Forms.TextBox txtRental;
        private System.Windows.Forms.TextBox txtBillsDue;
        private System.Windows.Forms.TextBox txtLoans;
        private System.Windows.Forms.TextBox txtDebts;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rbSilver;
        private System.Windows.Forms.RadioButton rbGold;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.TextBox txtSilverPerGram;
        private System.Windows.Forms.TextBox txtGoldPerGram;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblSilver;
        private System.Windows.Forms.Button btnDonate;
    }
}
