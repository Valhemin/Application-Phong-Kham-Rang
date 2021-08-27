using PKR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKR.DAO
{
    class HoadonDAO
    {
        private static HoadonDAO instance;
        public static HoadonDAO Instance 
        {  get { if (instance == null) instance = new HoadonDAO(); return HoadonDAO.instance; } 
           set { HoadonDAO.instance = value; }
        }
        private HoadonDAO() { }
        public List<Hoadon> LoadTablehoadon(string tendv)
        {
            List<Hoadon> tablelist = new List<Hoadon>();

                DataTable data = DataProvider.Instance.ExcuteQuery("USP_GETHOADON");


                foreach (DataRow item in data.Rows)
                {
                    Hoadon talble = new Hoadon(item);
                    tablelist.Add(talble);
                }

                return tablelist;
                 
        }
    }
}
