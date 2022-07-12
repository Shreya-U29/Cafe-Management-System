using DGVPrinterHelper;
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
    public partial class UC_Place : UserControl
    {
        function fn = new function();
        String query;
        public UC_Place()
        {
            InitializeComponent();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            qtybox.ResetText();
            totalbox.Clear();

            String text = listBox.GetItemText(listBox.SelectedItem);
            itembox.Text = text;
            query = "select Price from items where Item_Name = '" + text + "'";
            DataSet ds = fn.getData(query);

            try
            {
                pricebox.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = combobox.Text;
            query = "select Item_Name from items where category = '" + category + "' ";
            ShowItemList(query);
        }
        private void ShowItemList(String query)
        {
            listBox.Items.Clear();
            DataSet ds = fn.getData(query); 
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            String category = combobox.Text;
            query = "select Item_Name from items where category = '" + category + "' and Item_Name like '" + searchbox.Text + "%'";
            ShowItemList(query);
        }

        private void qtybox_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(qtybox.Value.ToString());
            Int64 price = Int64.Parse(pricebox.Text);
            totalbox.Text = (quan * price).ToString();
        }
        protected int n, total = 0;
        int amount;

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(DataGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGrid.Rows.RemoveAt(this.DataGrid.SelectedRows[0].Index);
            }
            catch { }
            total = total - amount;
            label.Text = "Rs." + total;

        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            DGVPrinter dGVPrinter = new DGVPrinter();
            dGVPrinter.Title = "Customer Bill";
            dGVPrinter.SubTitle = String.Format("Date: {0}", DateTime.Now.Date, DateTime.Now.TimeOfDay);
            dGVPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            dGVPrinter.PageNumbers = true;
            dGVPrinter.PageNumberInHeader = false;
            dGVPrinter.PorportionalColumns = true;
            dGVPrinter.HeaderCellAlignment = StringAlignment.Near;
            dGVPrinter.Footer = "Total Payable Amount :" + label.Text;
            dGVPrinter.FooterSpacing = 15;
            dGVPrinter.PrintDataGridView(DataGrid);

            total = 0;
            DataGrid.Rows.Clear();
            itembox.Clear();
            pricebox.Clear();
            totalbox.Clear();

            label.Text = "Rs." + total;

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (totalbox.Text != "0" && totalbox.Text != "")
            {
                n = DataGrid.Rows.Add();
                DataGrid.Rows[n].Cells[0].Value = itembox.Text;
                DataGrid.Rows[n].Cells[1].Value = pricebox.Text;
                DataGrid.Rows[n].Cells[2].Value = qtybox.Text;
                DataGrid.Rows[n].Cells[3].Value = totalbox.Text;

                total = total + int.Parse(totalbox.Text);
                label.Text = "Rs." + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity needs to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
