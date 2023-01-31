using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using SWD502_Forms_ClassActivity_21_03_2022.Modules;

namespace SWD502_Forms_ClassActivity_21_03_2022.Controls
{
	class DataConnection_Class : DatabaseConnection
	{
        SqlConnection conn;
       
        public bool Open()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString());
                sqlConnection.Open();
                conn = new SqlConnection(connectionString());
                conn.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }
        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }
        public string connectionString()
        {
            return getstrProvider();
        }

        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
		public int ExecuteReader(string sql)
        {
            try
            {
                SqlDataReader reader;
                SqlCommand cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                int counter = 0;
				if (reader.HasRows)
				{
                    while (reader.Read())
                        counter++;
                    return counter;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
    }
}
