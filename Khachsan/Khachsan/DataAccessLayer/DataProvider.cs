using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Khachsan.DataAccessLayer
{
    class DataProvider
    {
        private static SqlConnection con;
        public static SqlConnection Connect()
        {
            try
            {
                string sql = @"Server=DESKTOP-CUJBDU6\SQLEXPRESS;Database=Khachsan;Trusted_Connection=true ";
                con = new SqlConnection(sql);
                con.Open();
                return con;
            }
            catch (SqlException)
            {
                return null;
            }
        }
        public static DataTable GetData(string proc)
        {
            try
            {
                con = Connect();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(proc, con);
                da.Fill(dt);
                con.Close();
                return dt;

            }
            catch (SqlException)
            {
                con.Close();
                return null;
            }
        }
        public static string GetValues(string sql)
        {
            try
            {
                string temp = null;
                con = Connect();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader sqldr = cmd.ExecuteReader();
                while (sqldr.Read())
                    temp = sqldr[0].ToString();
                con.Close();
                return temp;
            }
            catch (SqlException)
            {
                con.Close();
                return null;
            }

        }
        public static int ExecuteNonQuery(string proc, SqlParameter[] para)
        {

            try
            {
                con = Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);

                int val = cmd.ExecuteNonQuery();
                con.Close();
                return val;
            }
            catch (SqlException)
            {
                return 0;
            }
        }
    }
}
