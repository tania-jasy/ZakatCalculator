using FormStart;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ZakatCalc
{
    public partial class ucCalculator : UserControl
    {
        private string userRole;
        private int userID;

        private decimal goldPrice = 0;
        private decimal silverPrice = 0;

        public decimal finalZakatableAmount = 0;
        public decimal nisabThreshold = 0;
        public decimal zakatDue = 0;

        private DataAccess Da { get; set; }

        public ucCalculator(string userRole, int userID )
        {
            InitializeComponent();

            this.userRole = userRole;
            this.userID = userID;

            Da = new DataAccess();

            Permission();
            metalPrices();

        }

        private void Permission()
        {
            if (userRole == "donor")
            {
                btnSet.Enabled = false;
                txtGoldPerGram.ReadOnly = true;
                txtSilverPerGram.ReadOnly = true;
            }
        }

        private void metalPrices()
        {
            string query = "SELECT * FROM METAL_PRICES WHERE Id = 1";
            DataTable dt = Da.ExecuteQueryTable(query); // brings the table 
            txtGoldPerGram.Text = dt.Rows[0]["GoldPrice"].ToString();
            txtSilverPerGram.Text = dt.Rows[0]["SilverPrice"].ToString();
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtGoldPerGram.Text) || string.IsNullOrWhiteSpace(txtSilverPerGram.Text)))
            {
                MessageBox.Show("Fill up the prices");
                return;
            }

            string query = "UPDATE METAL_PRICES SET GoldPrice = " + txtGoldPerGram.Text + ", SilverPrice = " + txtSilverPerGram.Text + ", LastUpdated = GETDATE() WHERE Id = 1;";
            int dt = Da.ExecuteQuery(query);

            if (dt == 1)
            {
                metalPrices();
                MessageBox.Show("Prices set successfully!");
            }
        }
        public decimal ParseInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0m;
            }

            if (decimal.TryParse(input.Trim(), out decimal result))
            {
                return result;
            }
            else
            {
                return 0m; // Returns 0 even if the user typed text like "abc"
            }
        }
        public void btnCalculate_Click(object sender, EventArgs e)
        {
            // ASSETS
            // Any empty field returns 0 via the ParseInput helper
            decimal cashSavings = ParseInput(txtCash.Text);
            decimal bankBalance = ParseInput(txtBank.Text);
            decimal goldSilverValue = ParseInput(txtGoldSilverValue.Text);
            decimal stocksValue = ParseInput(txtStocks.Text);
            decimal businessInventory = ParseInput(txtInventory.Text);
            decimal receivables = ParseInput(txtRecievables.Text);
            decimal rentalIncome = ParseInput(txtRental.Text);

            // LIABILITIES
            decimal debts = ParseInput(txtDebts.Text);
            decimal loansPayable = ParseInput(txtLoans.Text);
            decimal billsDue = ParseInput(txtBillsDue.Text);

            // Selecting nisab as per my wish
            if (!rbGold.Checked && !rbSilver.Checked)
            {
                MessageBox.Show("Please select a Nisab standard (Gold or Silver).", "Input Required");
                return;
            }

            // Check if the relevant metal price was entered
            if (rbGold.Checked && ParseInput(txtGoldPerGram.Text) <= 0)
            {
                MessageBox.Show("Please enter the current Gold price per gram.", "Missing Price");
                return;
            }
            else if (rbSilver.Checked && ParseInput(txtSilverPerGram.Text) <= 0)
            {
                MessageBox.Show("Please enter the current Silver price per gram.", "Missing Price");
                return;
            }

            // CALCULATIONS
            decimal totalAssets = cashSavings + bankBalance + goldSilverValue +
                                  stocksValue + businessInventory + receivables + rentalIncome;

            decimal totalLiabilities = debts + loansPayable + billsDue;

            // Zakatable Amount 
            decimal netWealth = totalAssets - totalLiabilities;


            if (netWealth > 0)
            {
                finalZakatableAmount = netWealth;
            }
            else
            {
                finalZakatableAmount = 0;
            }

            // Determine Nisab Threshold

            if (rbGold.Checked)
            {
                goldPrice = ParseInput(txtGoldPerGram.Text);
                nisabThreshold = 85m * goldPrice;
            }
            else
            {
                silverPrice = ParseInput(txtSilverPerGram.Text);
                nisabThreshold = 595m * silverPrice;
            }

            // Final Zakat Calculation

            if (finalZakatableAmount >= nisabThreshold)
            {
                zakatDue = finalZakatableAmount * 0.025m; // 2.5%
            }
            else
            {
                zakatDue = 0; // Wealth is below Nisab
            }

            // 6. UPDATE THE UI
            lblZakatable.Text = $"Zakatable Amount - {finalZakatableAmount}";
            lblNisab.Text = $"Nisab at time - {nisabThreshold}";
            lblDue.Text = $"Zakat Due - {zakatDue}";
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            // 1. Try to find the "Container" (the Main Window)
            if (this.FindForm() is FormAdmin mainForm)
            {
                // 2. Create the new screen we want to show
                var donationScreen = new ucDonations(zakatDue, userID, mainForm, null);

                // 3. Tell the Main Window to display it
                mainForm.LoadControl(donationScreen);
                return;
            }
            else if (this.FindForm() is FormDonor mainForm2)    
            {
                var donationScreen = new ucDonations(zakatDue, userID, null ,mainForm2);
                mainForm2.LoadControl(donationScreen);
                return;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbCalculate_Enter(object sender, EventArgs e)
        {

        }


    }
}
