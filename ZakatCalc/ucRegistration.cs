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
    public partial class ucRegistration : UserControl
    {
        private DataAccess Da { get; set; }
        public ucRegistration()
        {
            InitializeComponent();
            Da = new DataAccess();
        }


        private void btnSignUp_Click(object sender, EventArgs e)
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
            
                string sql = $"INSERT INTO USERS (username, password, contact_no, role, is_active) VALUES ('{username}', '{password}', '{contact}', 'donor', 1)";

                //not returning any table
                //returning number(s) of table affected by the given query
                int rows = Da.ExecuteQuery(sql);

                if (rows > 0)
                {
                    MessageBox.Show("Registration successful!");
                    ((FormLoginReg)this.FindForm()).LoadControl(new ucLogin());
                }
                else
                {
                    MessageBox.Show("Registration failed. Try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
