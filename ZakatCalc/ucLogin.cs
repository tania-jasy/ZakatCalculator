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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ZakatCalc
{
    public partial class ucLogin : UserControl
    {
        private DataAccess Da { get; set; }
        public ucLogin()
        {
            InitializeComponent();
            Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text.Trim();
            string password = this.txtPassword.Text;

            // Form Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                // Attempting to retrieve user role via DataAccess
                string userRole = Da.LoginOnUserRole(username, password);

                if (userRole != null)
                {
                    // Fetching UserID separately
                    string sqlQuery = $"SELECT user_id FROM Users WHERE username = '{username}' AND password = '{password}'";
                    DataTable dt = Da.ExecuteQueryTable(sqlQuery);

                    // Check if the DataTable returned any rows before accessing
                    if (dt == null || dt.Rows.Count == 0)
                    {
                        MessageBox.Show("User details could not be retrieved.");
                        return;
                    }

                    int userID = Convert.ToInt32(dt.Rows[0]["user_id"]);
                    FormLoginReg loginForm = (FormLoginReg)this.FindForm();

                    // Logic for navigating to specific dashboards based on role
                    if (userRole.Equals("admin", StringComparison.OrdinalIgnoreCase))
                    {
                        FormAdmin adminWindow = new FormAdmin(username, loginForm, userRole, userID);
                        loginForm.Hide();
                        adminWindow.Show();
                    }
                    else if (userRole.Equals("donor", StringComparison.OrdinalIgnoreCase))
                    {
                        FormDonor donorWindow = new FormDonor(username, loginForm, userRole, userID);
                        loginForm.Hide();
                        donorWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show($"Role '{userRole}' is not recognized.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPass.Checked) 
                { txtPassword.UseSystemPasswordChar = false; }
                else    
                { txtPassword.UseSystemPasswordChar = true; }
        }
    }
}
