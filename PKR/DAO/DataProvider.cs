using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKR.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string strcon = @"Data Source=DESKTOP-2021CRV\MSSQLSERVER01;Initial Catalog=QlKhachHangKhamRang;Integrated Security=True";

       

        public DataTable ExcuteQuery(string query,object[] parameter = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {

                sqlcon.Open();

                SqlCommand cmd = new SqlCommand(query, sqlcon);

                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                sqlcon.Close();
            }
            return dt;           
        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int dt = 0;

            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {

                sqlcon.Open();

                SqlCommand cmd = new SqlCommand(query, sqlcon);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                dt = cmd.ExecuteNonQuery();
                   
                sqlcon.Close();
            }
            return dt;
        }
        public object ExcuteScarlar(string query, object[] parameter = null)
        {
            object dt = 0;

            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {

                sqlcon.Open();

                SqlCommand cmd = new SqlCommand(query, sqlcon);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                dt = cmd.ExecuteScalar();

                sqlcon.Close();
            }
            return dt;
        }
    }
}
