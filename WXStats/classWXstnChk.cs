using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //added this to access SQL Servers

namespace WXStats
{
    class classWXstnChk
    {

        private string connectionString = string.Empty;

        public classWXstnChk() //a constructor - no arguments
        {

        }
        public void cnxstring(string ip, string sqlServer, string database, string userId, string password) //method to set connection string
        {
            //string connectionString = @"Data Source=192.168.1.15\DAWES_SQL2008; Database = WeatherStation; User Id = WeatherStation; Password = Esp32a.b.;";

            connectionString = $@"Data Source={ip}\{sqlServer}; Database = {database}; User Id = {userId}; Password = {password};";

        }

        public DateTime getAllData(string tablename)  //method to retieve data from a table
        {
            try
            {
                DateTime dt = DateTime.MinValue;
                SqlConnection conn;
                SqlDataReader rdr = null;
                conn = new SqlConnection(connectionString);
                SqlCommand sqlCmd = new SqlCommand($"select top 1 [TIME] from {tablename} ORDER BY [TIME] DESC ", conn);
                conn.Open();
                rdr = sqlCmd.ExecuteReader();
                //string Val = (string)sqlCmd.ExecuteScalar();
                while (rdr.Read())
                {
                    dt = (DateTime)rdr[0];

                }
                conn.Close();
                return dt;

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                //System.Windows.Forms.Application.Exit();
                return DateTime.MinValue;

            }
        }//end of method

        public double[] getTemperatureData(int pointcount,string tablename)
        {
            double [] tempdata = new double[pointcount];
            int cnt = 0;
            SqlConnection conn;
            SqlDataReader rdr = null;
            conn = new SqlConnection(connectionString);
            SqlCommand sqlCmd = new SqlCommand($"select top {pointcount} [TEMP] from {tablename} ORDER BY [TIME] DESC ", conn);
            conn.Open();
            rdr = sqlCmd.ExecuteReader();
            //string Val = (string)sqlCmd.ExecuteScalar();
            while (rdr.Read())
            {
                tempdata[cnt] = (double)rdr[0];
                cnt += 1;

            }
            conn.Close();
            return tempdata;




        }





    }//end of class
}//end namespace
