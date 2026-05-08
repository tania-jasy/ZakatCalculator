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
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            
            //Form Validation

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            // Pulling from DataAccess Class Metho
            string userRole = Da.LoginOnUserRole(username, password);

            if (userRole != null)
            {
                //holding the parent form here, in a variable
                FormLoginReg loginForm = (FormLoginReg)this.FindForm();

                if (userRole == "admin")
                {
                    FormAdmin adminWindow = new FormAdmin(username, (FormLoginReg)this.FindForm());
                    loginForm.Hide();
                    adminWindow.Show();
                }
                else if (userRole == "donor")
                {
                    FormDonor donorWindow = new FormDonor(username, (FormLoginReg)this.FindForm());
                    loginForm.Hide();
                    donorWindow.Show();
                }
                else
                {
                    MessageBox.Show($"Login successful, but role '{userRole}' is not recognized.");
                    this.FindForm().Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
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
