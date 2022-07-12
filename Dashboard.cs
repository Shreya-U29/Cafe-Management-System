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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String user)
        {
            InitializeComponent();
            if(user == "Guest")
            {
                additembutton.Hide();
                updatebutton.Hide();
                removebutton.Hide();
            }
            else if(user == "Admin")
            {
                additembutton.Show();
                updatebutton.Show();
                removebutton.Show();
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Add1.Visible = false;
            uC_Place1.Visible = false;
            uC_Remove1.Visible = false;
            uC_Update1.Visible = false;

        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Login_Form form = new Login_Form();
            form.Show();
            this.Hide();
        }

        private void additembutton_Click(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(uC_Add1);
            uC_Add1.Visible=true;
            uC_Add1.BringToFront();
        }

        private void placeorderbutton_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_Place1);
            uC_Place1.Visible=true;
            uC_Place1.BringToFront();
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(uC_Remove1);
            uC_Remove1.Visible = true;
            uC_Remove1.BringToFront();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(uC_Update1);
            uC_Update1.Visible=true;
            uC_Update1.BringToFront();
        }
    }
}
