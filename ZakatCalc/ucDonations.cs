using FormStart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZakatCalc
{
    public partial class ucDonations : UserControl
    {
        private DataAccess Da { get; set; }
        private ucCalculator calc { get; set; }
        private FormAdmin Fa;
        private FormDonor Fd;
        decimal amount;
        private int userID;

        public ucDonations(decimal amount, int userID, FormAdmin admin = null, FormDonor donor = null)
        {
            InitializeComponent();
            Da = new DataAccess();

            this.amount = amount;
            this.userID = userID;


            if (admin != null)
            {
                Fa = admin;
            }
            if (donor != null)
            {
                Fd = donor;
            }
        }

        private void tnCancel_Click(object sender, EventArgs e)
        {
    
            if (Fa != null)
            {
                Fa.LoadControl(new ucCalculator("admin", userID));
            }
            else if (Fd != null)
            {
                Fd.LoadControl(new ucCalculator("donor", userID));
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {


            if (cbPayment.SelectedItem == null || string.IsNullOrEmpty(txtAmount.Text) || Convert.ToDecimal(txtAmount.Text) <= 0)
            {
                MessageBox.Show("Please select a payment method and enter a valid amount.");
                return;
            }

            decimal amount = Convert.ToDecimal(txtAmount.Text);
            string method = cbPayment.SelectedItem.ToString();
            string trnxID = txtTrnxID.Text.ToString();

            string query = "INSERT INTO DONATIONS (user_id, total_amount, payment_method, transaction_ref) VALUES ("+this.userID+", "+amount+", '"+method+"', '"+trnxID+"');";
            int count = Da.ExecuteQuery(query);

            if (count == 1)
            {
                MessageBox.Show("Donation recorded successfully!");

                //Clearing out the selection inputs
                txtAmount.Clear();
                cbPayment.SelectedIndex = -1;
                txtTrnxID.Clear();

            }
            else
            {
                MessageBox.Show("An error occurred while recording the donation. Please try again.");
            }
        }

        private void ucDonations_Load(object sender, EventArgs e)
        {
            txtAmount.Text = amount.ToString();
        }


    }
}
