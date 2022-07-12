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
    public partial class UC_Update : UserControl
    {
        function fn = new function();
        String query;
        public UC_Update()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        

        private void UC_Update_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void searchb_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where Item_Name like '" + searchb.Text + "%'";
            DataSet dst = fn.getData(query);
            guna2DataGridView1.DataSource = dst.Tables[0];
        }


       
        int id;

        

        private void updatebutton_Click(object sender, EventArgs e)
        {
            query = "update items set Item_Name = '" + itemb.Text + "', Category = '" + categoryb.Text + "', Price = '" + priceb.Text + "' where id = "+id+"";
            fn.setData(query);
            loaddata();

            itemb.Clear();
            categoryb.Clear();
            priceb.Clear();
        }

        private void guna2DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            categoryb.Text = category;
            itemb.Text = name;
            priceb.Text = price.ToString();
        }
    }
}
