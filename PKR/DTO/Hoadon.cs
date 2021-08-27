using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKR.DTO
{
    class Hoadon
    {
        public Hoadon(string mhd,string tenkh,string namsinh,string gioitinh,string diachi,string dichvu,string giadv,string thuoc,string giathuoc,string ngayxuathoadon,string gioxuathoadon,string tong)
        {
            this.MHD = mhd;
            this.TENKH = tenkh;
            this.NAMSINH = namsinh;
            this.GIOITINH= gioitinh;
            this.DIACHI = diachi;
            this.DICHVU = dichvu;
            this.GIADV = giadv;
            this.THUOC = thuoc;
            this.GIATHUOC = giathuoc;
            this.NGAYXUATHOADON = ngayxuathoadon;
            this.GIOXUATHOADON = gioxuathoadon;
            this.TONG = tong;
        }
        public Hoadon(DataRow row)
        {
            this.MHD = row["MHD"].ToString();
            this.TENKH = row["TENKH"].ToString();
            this.NAMSINH = row["NAMSINH"].ToString();
            this.GIOITINH = row["GIOITINH"].ToString();
            this.DIACHI = row["DIACHI"].ToString();
            this.DICHVU = row["DICHVU"].ToString();
            this.GIADV = row["GIADV"].ToString();
            this.THUOC = row["THUOC"].ToString();
            this.GIATHUOC = row["GIATHUOC"].ToString();
            this.NGAYXUATHOADON = row["NGAYXUATHOADON"].ToString();
            this.GIOXUATHOADON = row["GIOXUATHOADON"].ToString();
            this.TONG = row["TONG"].ToString();
            
        }

        private string mHD, tENKH, nAMSINH, gIOITINH, dIACHI, dICHVU, gIADV, tHUOC, gIATHUOC, nGAYXUATHOADON, gIOXUATHOADON, tONG;
 
        public string MHD { get { return mHD; }  set { mHD = value; } }
        public string TENKH { get { return tENKH; } set { tENKH = value; } }
        public string NAMSINH { get { return nAMSINH; } set { nAMSINH = value; } }
        public string GIOITINH { get { return gIOITINH; } set { gIOITINH = value; } }
        public string DIACHI { get { return dIACHI; } set { dIACHI = value; } }
        public string DICHVU { get { return dICHVU; } set { dICHVU = value; } }
        public string GIADV { get { return gIADV; } set { gIADV = value; } }
        public string THUOC { get { return tHUOC; } set { tHUOC = value; } }
        public string GIATHUOC { get { return gIATHUOC; } set { gIATHUOC = value; } }
        public string NGAYXUATHOADON { get { return nGAYXUATHOADON; } set { nGAYXUATHOADON = value; } }
        public string GIOXUATHOADON { get { return gIOXUATHOADON; } set { gIOXUATHOADON = value; } }
        public string TONG { get { return tONG; } set { tONG = value; } }
    }
}
