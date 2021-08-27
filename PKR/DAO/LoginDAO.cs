using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKR.DAO
{
    class LoginDAO
    {
        private static LoginDAO instance;

        public static LoginDAO Instance 
        { 
          get  { if (instance == null) instance = new LoginDAO(); return instance; }
          private set { instance = value; }        
        }
        private LoginDAO() { }

        public bool Login(string username,string password)
        {
            string query = "USP_LOGIN @username , @password ";
            
            DataTable result = DataProvider.Instance.ExcuteQuery(query,new object[] { username , password });

            return result.Rows.Count > 0;
        }
    }
}
