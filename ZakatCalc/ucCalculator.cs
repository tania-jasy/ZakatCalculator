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

        public ucCalculator(string userRole, int userID)
        {
            InitializeComponent();
            try
            {
                this.userRole = userRole;
                this.userID = userID;

                Da = new DataAccess();

                Permission();
                metalPrices();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            try
            {
                string query = "SELECT * FROM METAL_PRICES WHERE Id = 1";
                DataTable dt = Da.ExecuteQueryTable(query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txtGoldPerGram.Text = dt.Rows[0]["GoldPrice"].ToString();
                    txtSilverPerGram.Text = dt.Rows[0]["SilverPrice"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtGoldPerGram.Text) || string.IsNullOrWhiteSpace(txtSilverPerGram.Text)))
            {
                MessageBox.Show("Fill up the prices");
                return;
            }

            try
            {
                string query = "UPDATE METAL_PRICES SET GoldPrice = " + txtGoldPerGram.Text + ", SilverPrice = " + txtSilverPerGram.Text + ", LastUpdated = GETDATE() WHERE Id = 1;";
                int dt = Da.ExecuteQuery(query);

                if (dt == 1)
                {
                    metalPrices();
                    MessageBox.Show("Prices set successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                return 0m;
            }
        }

        public void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // ASSETS
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

                if (!rbGold.Checked && !rbSilver.Checked)
                {
                    MessageBox.Show("Please select a Nisab standard (Gold or Silver).", "Input Required");
                    return;
                }

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

                decimal totalAssets = cashSavings + bankBalance + goldSilverValue +
                                      stocksValue + businessInventory + receivables + rentalIncome;

                decimal totalLiabilities = debts + loansPayable + billsDue;

                decimal netWealth = totalAssets - totalLiabilities;
                finalZakatableAmount = netWealth > 0 ? netWealth : 0;

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

                if (finalZakatableAmount >= nisabThreshold)
                {
                    zakatDue = finalZakatableAmount * 0.025m;
                }
                else
                {
                    zakatDue = 0;
                }

                lblZakatable.Text = $"Zakatable Amount - {finalZakatableAmount}";
                lblNisab.Text = $"Nisab at time - {nisabThreshold}";
                lblDue.Text = $"Zakat Due - {zakatDue}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.FindForm() is FormAdmin mainForm)
                {
                    var donationScreen = new ucDonations(zakatDue, userID, mainForm, null);
                    mainForm.LoadControl(donationScreen);
                }
                else if (this.FindForm() is FormDonor mainForm2)
                {
                    var donationScreen = new ucDonations(zakatDue, userID, null, mainForm2);
                    mainForm2.LoadControl(donationScreen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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