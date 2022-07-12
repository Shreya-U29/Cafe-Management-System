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
    public partial class UC_Add : UserControl
    {
        function fn = new function();
        string query;
        public UC_Add()
        {
            
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if ((itemnamebox.Text == "") && (categorybox.Text == "") && (pricebox.Text == ""))
            {
                query = "insert into items values('" + itemnamebox.Text + "','" + categorybox.Text + "','" + pricebox.Text + "')";
                fn.setData(query);
                clearall();
            }
            else
            {               
                MessageBox.Show("Incomplete information");
            }
        }
        public void clearall()
        {
            categorybox.SelectedIndex = -1;
            itemnamebox.Clear();
            pricebox.Clear();
        }

        private void itemnamebox_Leave(object sender, EventArgs e)
        {
            
        }

        private void UC_Add_Leave(object sender, EventArgs e)
        {
            clearall();
        }
    }
}
