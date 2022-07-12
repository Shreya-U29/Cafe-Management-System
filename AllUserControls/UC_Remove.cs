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
    public partial class UC_Remove : UserControl
    {
        function fn = new function();
        string query;
        public UC_Remove()
        {
            InitializeComponent();
        }

        private void UC_Remove_Load(object sender, EventArgs e)
        {
            label.ForeColor = Color.Navy;
            loadall();
        }
        public void loadall()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            datagrid.DataSource = ds.Tables[0];
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where Item_Name like '" + searchbox.Text + "%'";
            DataSet d = fn.getData(query);
            datagrid.DataSource=d.Tables[0];
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete Item?","Important Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int id = int.Parse(datagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where id = " + id + "";
                fn.setData(query);
                loadall();
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            label.ForeColor= Color.Red;
            label.Text = "Click on row to delete the item";
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            loadall();
        }
    }
}
