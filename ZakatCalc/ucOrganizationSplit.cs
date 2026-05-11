using FormStart;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace ZakatCalc
{
    public partial class ucOrganizationSplit : UserControl
    {
        DataAccess Da;
        FormAdmin Fa;
        FormDonor Fd;
        int DonationId;
        decimal Amount;
        string trnxID;

        public ucOrganizationSplit(FormAdmin admin = null, FormDonor donor = null, int donationId = 0, decimal amount = 0, string trnxID = "")
        {
            InitializeComponent();
            try
            {
                Da = new DataAccess();

                DonationId = donationId;
                Amount = amount;
                this.trnxID = trnxID;

                if (admin != null) { Fa = admin; }
                if (donor != null) { Fd = donor; }

                Da.PopulateGridView("SELECT org_id, name, category, bank_details FROM Organizations", "organizations", dgvOrgSplit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (Fa != null) { Fa.LoadControl(new ucDonations()); }
                else if (Fd != null) { Fd.LoadControl(new ucDonations()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This runs when the Auto Split checkbox is checked or unchecked
        private void cbAutoSplit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // If they unchecked the box, just stop and do nothing
                if (cbAutoSplit.Checked == false)
                {
                    return;
                }

                // Create a list to hold all the rows the user checked
                List<DataGridViewRow> checkedRows = new List<DataGridViewRow>();

                // Loop through every single row in the grid
                foreach (DataGridViewRow row in dgvOrgSplit.Rows)
                {
                    // Get the value of the "Select" checkbox cell
                    object cellValue = row.Cells["Select"].Value;
                    bool isSelected = Convert.ToBoolean(cellValue);

                    // If it is checked, add it to our list
                    if (isSelected == true)
                    {
                        checkedRows.Add(row);
                    }
                }

                // If they checked the Auto Split box but didn't select any organizations, warn them
                if (checkedRows.Count == 0)
                {
                    MessageBox.Show("Please select at least one organization before using Auto Split.");
                    cbAutoSplit.Checked = false; // Uncheck the box automatically
                    return;
                }

                // Clear out any old numbers from the percentage column for all rows
                foreach (DataGridViewRow row in dgvOrgSplit.Rows)
                {
                    row.Cells["Percentage"].Value = "";
                }

                // Figure out what the equal piece of the pie is (100 divided by number of selected rows)
                decimal countDecimal = Convert.ToDecimal(checkedRows.Count);
                decimal equalAmount = 100m / countDecimal;
                decimal roundedEqualAmount = Math.Round(equalAmount, 2);

                // Keep track of how much percentage we have handed out so far
                decimal totalAssignedSoFar = 0;

                // Loop through the selected rows to hand out the percentages
                for (int i = 0; i < checkedRows.Count; i++)
                {
                    DataGridViewRow currentRow = checkedRows[i];

                    // If this is the very last row, give it whatever is leftover so we hit exactly 100%
                    if (i == checkedRows.Count - 1)
                    {
                        decimal leftOver = 100m - totalAssignedSoFar;
                        decimal roundedLeftOver = Math.Round(leftOver, 2);
                        currentRow.Cells["Percentage"].Value = roundedLeftOver.ToString("0.##");
                    }
                    else
                    {
                        // If it's not the last row, just give it the normal equal amount
                        currentRow.Cells["Percentage"].Value = roundedEqualAmount.ToString("0.##");
                        totalAssignedSoFar = totalAssignedSoFar + roundedEqualAmount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This runs when the Donate button is clicked
        private void btnDonate_Click(object sender, EventArgs e)
        {
            try
            {
                // Instead of a complex tuple, let's use two simple lists to store our data
                List<int> selectedOrgIds = new List<int>();
                List<decimal> selectedPercentages = new List<decimal>();

                // Step 1: Loop through the grid to find all selected rows
                foreach (DataGridViewRow row in dgvOrgSplit.Rows)
                {
                    object selectCellValue = row.Cells["Select"].Value;
                    bool isSelected = Convert.ToBoolean(selectCellValue);

                    // Only look at the rows that are checked
                    if (isSelected == true)
                    {
                        // Get the text from the percentage box
                        object pctCellValue = row.Cells["Percentage"].Value;

                        // If the cell is totally blank, show an error
                        if (pctCellValue == null)
                        {
                            MessageBox.Show("All selected rows must add up to 100%.");
                            return;
                        }

                        // Convert it to a string and remove any blank spaces
                        string rawPct = pctCellValue.ToString();
                        rawPct = rawPct.Trim();

                        // If it's an empty string, show an error
                        if (rawPct == "")
                        {
                            MessageBox.Show("All selected rows must add up to 100%.");
                            return;
                        }

                        // Try to turn the text into an actual decimal number
                        decimal pctNumber;
                        bool isNumber = decimal.TryParse(rawPct, out pctNumber);

                        // If it wasn't a valid number, or if it is 0 or less, show an error
                        if (isNumber == false || pctNumber <= 0)
                        {
                            MessageBox.Show("All selected rows must add up to 100%.");
                            return;
                        }

                        // Get the ID of the organization
                        int orgId = Convert.ToInt32(row.Cells["org_id"].Value);

                        // Add the data to our lists
                        selectedOrgIds.Add(orgId);
                        selectedPercentages.Add(pctNumber);
                    }
                }

                // Step 2: Make sure they actually selected at least one organization
                if (selectedOrgIds.Count == 0)
                {
                    MessageBox.Show("Please select at least one organization.");
                    return;
                }

                // Step 3: If Auto Split is off, we have to manually check if they add up to 100%
                if (cbAutoSplit.Checked == false)
                {
                    decimal totalPercentage = 0;

                    // Add up all the percentages in our list
                    for (int i = 0; i < selectedPercentages.Count; i++)
                    {
                        totalPercentage = totalPercentage + selectedPercentages[i];
                    }

                    // Math.Abs makes sure we get a positive difference, in case of weird decimal math
                    decimal difference = Math.Abs(totalPercentage - 100m);

                    // If the total is off by more than 0.01, reject it
                    if (difference > 0.01m)
                    {
                        string errorMessage = "Percentages must add up to 100%. Current total: " + totalPercentage.ToString("0.##") + "%";
                        MessageBox.Show(errorMessage);
                        return;
                    }
                }

                // Step 4: Save the splits to the database
                for (int i = 0; i < selectedOrgIds.Count; i++)
                {
                    int currentOrgId = selectedOrgIds[i];
                    decimal currentPercentage = selectedPercentages[i];

                    // Calculate how much actual money this percentage represents
                    decimal moneyToGive = Amount * (currentPercentage / 100m);
                    decimal roundedMoney = Math.Round(moneyToGive, 2);

                    // Build the SQL query
                    string query = "INSERT INTO DONATION_SPLITS (donation_id, org_id, amount, percentage) VALUES (";
                    query = query + DonationId + ", ";
                    query = query + currentOrgId + ", ";
                    query = query + roundedMoney + ", ";
                    query = query + currentPercentage + ")";

                    // Run the query
                    Da.ExecuteQuery(query);
                }

                // Step 5: Save a receipt to the database
                string receiptQuery = "INSERT INTO RECEIPTS (donation_id, transaction_id, issued_at) VALUES (";
                receiptQuery = receiptQuery + DonationId + ", ";
                receiptQuery = receiptQuery + "'" + trnxID + "', GETDATE()); ";
                receiptQuery = receiptQuery + "SELECT SCOPE_IDENTITY();"; // This asks SQL for the ID it just created

                // Get the new Receipt ID from the database
                object newReceiptIdObject = Da.ExecuteScalar(receiptQuery);
                if (newReceiptIdObject == null) throw new Exception("Failed to generate receipt ID.");

                int receiptId = Convert.ToInt32(newReceiptIdObject);

                // Tell the user everything went well
                MessageBox.Show("Donation split saved successfully!");

                // Step 6: Open up the final receipt screen
                FormReciept receiptScreen = new FormReciept(DonationId, Amount, receiptId, trnxID);
                this.Hide();
                receiptScreen.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvOrgSplit_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }

        private void dgvOrgSplit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvOrgSplit_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}