using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZakatCalc
{
    public partial class FormAdmin : Form
    {

        private FormLoginReg prevForm;
        private string name;
        public FormAdmin()
        {
            InitializeComponent();
        }

        public FormAdmin(string username, FormLoginReg Form1)
        {
            InitializeComponent();
            this.prevForm = Form1;
            this.name = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome\n " + name;
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            prevForm.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }
    }
}
