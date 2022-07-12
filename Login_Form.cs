using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaFe
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard dashboard = new Dashboard("Guest");
            dashboard.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(usertextbox.Text == "abc" && passwordtextbox.Text == "123")
            { 
                Dashboard dash = new Dashboard("Admin");
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
                usertextbox.Clear();
                passwordtextbox.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                passwordtextbox.UseSystemPasswordChar = false;
            }
            else
                passwordtextbox.UseSystemPasswordChar = true;
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            passwordtextbox.UseSystemPasswordChar = true;
        }
    }
}
