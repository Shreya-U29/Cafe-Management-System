using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CaFe
{
    class function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source = LAPTOP-J6TM91QC\SQLEXPRESS; database = cafe; integrated security = true";
            return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        public void setData(String query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data Processed Successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
