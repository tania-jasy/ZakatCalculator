using FormStart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZakatCalc
{
    public partial class ucDonorProfile : UserControl
    {
        private FormLoginReg prevForm;
        private FormDonor container;
        private DataAccess Da { get; set; }
        private string name;
        public ucDonorProfile(string username, FormLoginReg prevForm, FormDonor container)
        {
            InitializeComponent();
            Da = new DataAccess();
            name = username;
            this.prevForm = prevForm;
            this.container = container;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPass.Text.Trim();
            string contact = txtContact.Text.Trim();
            //Form Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                DataAccess Da = new DataAccess();

                string sql = $"UPDATE USERS SET username = '{username}', password = '{password}', contact_no = '{contact}' WHERE username = '{name}'";

                //not returning any table
                //returning number(s) of table affected by the given query
                int rows = Da.ExecuteQuery(sql);

                if (rows > 0)
                {
                    MessageBox.Show("Your profile information changed successfully");

                    prevForm.Show();
                    container.Hide();
                }
                else
                {
                    MessageBox.Show("failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void ucDonorProfile_Load(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT user_id, username, password, contact_no FROM users WHERE Username = '{name}'";
                DataTable dt = Da.ExecuteQueryTable(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    txtID.Text = row["user_id"].ToString();
                    txtContact.Text = row["contact_no"].ToString();
                    txtUsername.Text = row["Username"].ToString();
                    txtPass.Text = row["password"].ToString();
                }
                else
                {
                    MessageBox.Show("No profile data found.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user data: " + ex.Message);
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            { txtPass.UseSystemPasswordChar = false; }
            else
            { txtPass.UseSystemPasswordChar = true; }
        }
    }
}
