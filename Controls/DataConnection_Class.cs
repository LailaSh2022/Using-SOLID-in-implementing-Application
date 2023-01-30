using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SWD502_Forms_ClassActivity_21_03_2022.Controls
{
	class DataConnection_Class
	{
        //("Data Source=LAPTOP-Q4ENDLRT\\SQLEXPRESS;
        //Initial Catalog=RetialDB;
        //Integrated Security=True;
        //Connect Timeout=30;
        //Encrypt=False;
        //TrustServerCertificate=False;
        //ApplicationIntent=ReadWrite;
        //MultiSubnetFailover=False");
        //Data Source=LAPTOP-Q4ENDLRT\SQLEXPRESS;Initial Catalog=CareDB;Integrated Security=True;
        //Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        SqlConnection conn;
        static string host = "LAPTOP-Q4ENDLRT\\SQLEXPRESS";
        static string database = "CarDB";
        static string Encrypt = "False";
        static string Certificate = "False";
        static string LoginDB = "True";
        static string Connect = "30";
        static string Access = "ReadWrite";
        static string Failover = "False";
        public static string strProvider = "Data Source=" + host + ";Initial Catalog=" + database + ";Integrated Security=" + LoginDB
            + ";Connect Timeout=" + Connect + ";Encrypt=" + Encrypt+ ";TrustServerCertificate="+ Certificate 
            + ";ApplicationIntent="+ Access + ";MultiSubnetFailover="+ Failover;
        public bool Open()
        {
            try
            {
                //strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
                SqlConnection sqlConnection = new SqlConnection(strProvider);
                sqlConnection.Open();
                conn = new SqlConnection(strProvider);
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
            return strProvider;
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
