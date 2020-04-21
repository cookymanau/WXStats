using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //added this to access SQL Servers
using static WXStats.Globals;

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
            SqlCommand sqlCmd = new SqlCommand($"select top {Globals.pointcount} {Globals.fieldname} from {tablename} ORDER BY [TIME] DESC ", conn);
            conn.Open();
            rdr = sqlCmd.ExecuteReader();
            //string Val = (string)sqlCmd.ExecuteScalar();
            while (rdr.Read())
            {
                tempdata[cnt] = (double)rdr[0];  //errors
                cnt += 1;

            }
            conn.Close();
            return tempdata;
        }//end of method

        public double[,] getTemperatureData(int pointcount, string table1,string table2)
        {
            double[,] tempdata = new double[pointcount,2];
            string sqlQuery = $@"

select distinct top {pointcount} * from (
select top 100 percent a.TEMP as WXtemp1, b.TEMP as WXtemp2 from {table1} a inner join {table2} b on a.TIME=b.TIME 
where a.TIME between convert(DATETIME,'{Globals.startDate}') AND CONVERT(DATETIME,'{Globals.endDate}') 
ORDER BY a.TIME
)a





";
            int cnt = 0;
            SqlConnection conn;
            SqlDataReader rdr = null;
            conn = new SqlConnection(connectionString);
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            conn.Open();
            rdr = sqlCmd.ExecuteReader();
            //string Val = (string)sqlCmd.ExecuteScalar();
            while (rdr.Read())
            {
                tempdata[cnt,0] = (double)rdr["WXtemp1"];
                tempdata[cnt,1] = (double)rdr["WXtemp2"];

                cnt += 1;

            }
            conn.Close();
            return tempdata;
        }//end of method




    }//end of class
}//end namespace
