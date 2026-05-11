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
    public partial class FormDonor : Form
    {
        private FormLoginReg prevForm;
        private string name;
        private string userRole;
        public FormDonor()
        {
            InitializeComponent();
        }

        public FormDonor(string username, FormLoginReg Form1, string userRole)
        {
            InitializeComponent();
            this.prevForm = Form1;
            this.name = username;
            this.userRole = userRole;


            LoadControl(new ucCalculator(userRole));
        }
        public void LoadControl(UserControl control)
        {
            pnlLoader.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlLoader.Controls.Add(control);
        }

        private void FormDonor_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome\n " + name;
        }

        private void FormDonor_FormClosing(object sender, FormClosingEventArgs e)
        {
            prevForm.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            LoadControl(new ucCalculator(userRole));
        }

        private void btnLog_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadControl(new ucDonorProfile(name, prevForm, this));
        }
    }
}
