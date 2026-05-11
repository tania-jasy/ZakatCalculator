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
            this.lblAssets = new System.Windows.Forms.Label();
            this.lblLiabilities = new System.Windows.Forms.Label();
            this.lblVar = new System.Windows.Forms.Label();
            this.gbCalculate = new System.Windows.Forms.GroupBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblZakatable = new System.Windows.Forms.Label();
            this.lbalNisab = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtGoldSilverValue = new System.Windows.Forms.TextBox();
            this.txtStocks = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtInventories = new System.Windows.Forms.TextBox();
            this.txtRental = new System.Windows.Forms.TextBox();
            this.txtBillsDue = new System.Windows.Forms.TextBox();
            this.txtLoans = new System.Windows.Forms.TextBox();
            this.txtDebts = new System.Windows.Forms.TextBox();
            this.rbSilver = new System.Windows.Forms.RadioButton();
            this.rbGold = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSelection = new System.Windows.Forms.Label();
            this.txtSilverPerGram = new System.Windows.Forms.TextBox();
            this.txtGoldPerGram = new System.Windows.Forms.TextBox();
            this.btnDonate = new System.Windows.Forms.Button();
            this.gbCalculate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAssets
            // 
            this.lblAssets.AutoSize = true;
            this.lblAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssets.Location = new System.Drawing.Point(23, 23);
            this.lblAssets.Name = "lblAssets";
            this.lblAssets.Size = new System.Drawing.Size(83, 25);
            this.lblAssets.TabIndex = 0;
            this.lblAssets.Text = "Assets";
            // 
            // lblLiabilities
            // 
            this.lblLiabilities.AutoSize = true;
            this.lblLiabilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiabilities.Location = new System.Drawing.Point(23, 288);
            this.lblLiabilities.Name = "lblLiabilities";
            this.lblLiabilities.Size = new System.Drawing.Size(107, 25);
            this.lblLiabilities.TabIndex = 1;
            this.lblLiabilities.Text = "Liablities";
            // 
            // lblVar
            // 
            this.lblVar.AutoSize = true;
            this.lblVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVar.Location = new System.Drawing.Point(362, 23);
            this.lblVar.Name = "lblVar";
            this.lblVar.Size = new System.Drawing.Size(151, 25);
            this.lblVar.TabIndex = 2;
            this.lblVar.Text = "Current Price";
            // 
            // gbCalculate
            // 
            this.gbCalculate.Controls.Add(this.btnCalculate);
            this.gbCalculate.Controls.Add(this.rbSilver);
            this.gbCalculate.Controls.Add(this.rbGold);
            this.gbCalculate.Controls.Add(this.lblSelection);
            this.gbCalculate.Location = new System.Drawing.Point(367, 147);
            this.gbCalculate.Name = "gbCalculate";
            this.gbCalculate.Size = new System.Drawing.Size(272, 98);
            this.gbCalculate.TabIndex = 3;
            this.gbCalculate.TabStop = false;
            this.gbCalculate.Enter += new System.EventHandler(this.gbCalculate_Enter);
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(362, 288);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(82, 25);
            this.lblReport.TabIndex = 4;
            this.lblReport.Text = "Report";
            // 
            // lblZakatable
            // 
            this.lblZakatable.AutoSize = true;
            this.lblZakatable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZakatable.Location = new System.Drawing.Point(364, 333);
            this.lblZakatable.Name = "lblZakatable";
            this.lblZakatable.Size = new System.Drawing.Size(160, 18);
            this.lblZakatable.TabIndex = 5;
            this.lblZakatable.Text = "Zakatable Amount - 0.0";
            // 
            // lbalNisab
            // 
            this.lbalNisab.AutoSize = true;
            this.lbalNisab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbalNisab.Location = new System.Drawing.Point(364, 363);
            this.lbalNisab.Name = "lbalNisab";
            this.lbalNisab.Size = new System.Drawing.Size(127, 18);
            this.lbalNisab.TabIndex = 6;
            this.lbalNisab.Text = "Nisab at time - 0.0";
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.Location = new System.Drawing.Point(364, 394);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(109, 18);
            this.lblDue.TabIndex = 7;
            this.lblDue.Text = "Zakat Due - 0.0";
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(28, 69);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(175, 20);
            this.txtCash.TabIndex = 8;
            this.txtCash.Text = "Cash Savings";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(28, 95);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(175, 20);
            this.txtBank.TabIndex = 9;
            this.txtBank.Text = "Bank Balance";
            // 
            // txtGoldSilverValue
            // 
            this.txtGoldSilverValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGoldSilverValue.Location = new System.Drawing.Point(28, 121);
            this.txtGoldSilverValue.Name = "txtGoldSilverValue";
            this.txtGoldSilverValue.Size = new System.Drawing.Size(175, 20);
            this.txtGoldSilverValue.TabIndex = 10;
            this.txtGoldSilverValue.Text = "Gold/Silver values";
            // 
            // txtStocks
            // 
            this.txtStocks.Location = new System.Drawing.Point(28, 147);
            this.txtStocks.Name = "txtStocks";
            this.txtStocks.Size = new System.Drawing.Size(175, 20);
            this.txtStocks.TabIndex = 11;
            this.txtStocks.Text = "Stocks Value";
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(28, 173);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(175, 20);
            this.txtInventory.TabIndex = 12;
            this.txtInventory.Text = "Business Inventory";
            // 
            // txtInventories
            // 
            this.txtInventories.Location = new System.Drawing.Point(28, 199);
            this.txtInventories.Name = "txtInventories";
            this.txtInventories.Size = new System.Drawing.Size(175, 20);
            this.txtInventories.TabIndex = 13;
            this.txtInventories.Text = "Recievables";
            this.txtInventories.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtRental
            // 
            this.txtRental.Location = new System.Drawing.Point(28, 225);
            this.txtRental.Name = "txtRental";
            this.txtRental.Size = new System.Drawing.Size(175, 20);
            this.txtRental.TabIndex = 14;
            this.txtRental.Text = "Rental Income";
            // 
            // txtBillsDue
            // 
            this.txtBillsDue.Location = new System.Drawing.Point(28, 386);
            this.txtBillsDue.Name = "txtBillsDue";
            this.txtBillsDue.Size = new System.Drawing.Size(175, 20);
            this.txtBillsDue.TabIndex = 17;
            this.txtBillsDue.Text = "Bills Due";
            // 
            // txtLoans
            // 
            this.txtLoans.Location = new System.Drawing.Point(28, 360);
            this.txtLoans.Name = "txtLoans";
            this.txtLoans.Size = new System.Drawing.Size(175, 20);
            this.txtLoans.TabIndex = 16;
            this.txtLoans.Text = "Loans Payable";
            // 
            // txtDebts
            // 
            this.txtDebts.Location = new System.Drawing.Point(28, 334);
            this.txtDebts.Name = "txtDebts";
            this.txtDebts.Size = new System.Drawing.Size(175, 20);
            this.txtDebts.TabIndex = 15;
            this.txtDebts.Text = "Debts";
            // 
            // rbSilver
            // 
            this.rbSilver.AutoSize = true;
            this.rbSilver.Location = new System.Drawing.Point(83, 35);
            this.rbSilver.Name = "rbSilver";
            this.rbSilver.Size = new System.Drawing.Size(51, 17);
            this.rbSilver.TabIndex = 20;
            this.rbSilver.TabStop = true;
            this.rbSilver.Text = "Silver";
            this.rbSilver.UseVisualStyleBackColor = true;
            // 
            // rbGold
            // 
            this.rbGold.AutoSize = true;
            this.rbGold.Location = new System.Drawing.Point(15, 35);
            this.rbGold.Name = "rbGold";
            this.rbGold.Size = new System.Drawing.Size(47, 17);
            this.rbGold.TabIndex = 19;
            this.rbGold.TabStop = true;
            this.rbGold.Text = "Gold";
            this.rbGold.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DimGray;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(6, 54);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(260, 38);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.Location = new System.Drawing.Point(6, 10);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(183, 16);
            this.lblSelection.TabIndex = 21;
            this.lblSelection.Text = "Select Nisab as per your wish";
            // 
            // txtSilverPerGram
            // 
            this.txtSilverPerGram.Location = new System.Drawing.Point(373, 95);
            this.txtSilverPerGram.Name = "txtSilverPerGram";
            this.txtSilverPerGram.Size = new System.Drawing.Size(175, 20);
            this.txtSilverPerGram.TabIndex = 19;
            this.txtSilverPerGram.Text = "Silver value per gram";
            // 
            // txtGoldPerGram
            // 
            this.txtGoldPerGram.Location = new System.Drawing.Point(373, 69);
            this.txtGoldPerGram.Name = "txtGoldPerGram";
            this.txtGoldPerGram.Size = new System.Drawing.Size(175, 20);
            this.txtGoldPerGram.TabIndex = 18;
            this.txtGoldPerGram.Text = "Gold value per gram";
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.DimGray;
            this.btnDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonate.ForeColor = System.Drawing.Color.White;
            this.btnDonate.Location = new System.Drawing.Point(28, 454);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(605, 53);
            this.btnDonate.TabIndex = 22;
            this.btnDonate.Text = "Donate";
            this.btnDonate.UseVisualStyleBackColor = false;
            // 
            // ucCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.txtSilverPerGram);
            this.Controls.Add(this.txtGoldPerGram);
            this.Controls.Add(this.txtBillsDue);
            this.Controls.Add(this.txtLoans);
            this.Controls.Add(this.txtDebts);
            this.Controls.Add(this.txtRental);
            this.Controls.Add(this.txtInventories);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtStocks);
            this.Controls.Add(this.txtGoldSilverValue);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.lbalNisab);
            this.Controls.Add(this.lblZakatable);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.gbCalculate);
            this.Controls.Add(this.lblVar);
            this.Controls.Add(this.lblLiabilities);
            this.Controls.Add(this.lblAssets);
            this.Name = "ucCalculator";
            this.Size = new System.Drawing.Size(677, 537);
            this.gbCalculate.ResumeLayout(false);
            this.gbCalculate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssets;
        private System.Windows.Forms.Label lblLiabilities;
        private System.Windows.Forms.Label lblVar;
        private System.Windows.Forms.GroupBox gbCalculate;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblZakatable;
        private System.Windows.Forms.Label lbalNisab;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtGoldSilverValue;
        private System.Windows.Forms.TextBox txtStocks;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtInventories;
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
        private System.Windows.Forms.Button btnDonate;
    }
}
