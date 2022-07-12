using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaFe.AllUserControls
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (num == 0)
            {
                label2.Location = new Point(58,354);
                label2.ForeColor = Color.Navy;
                num++;
            }
            else if (num == 1)
            {
                label2.Location = new Point(200,457);
                label2.ForeColor = Color.Red;
                num++;
            }
           
            else if (num == 2)
            {
                label2.Location = new Point(300,355);
                label2.ForeColor = Color.Gold;
                num = 0;
            }
        }
    }
}
