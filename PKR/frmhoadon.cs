using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Diagnostics.Instrumentation.Extensions.Intercept;
using PKR.DAO;
using PKR.DTO;

namespace PKR
{
    public partial class frmhoadon : Form
    {
        static string strcon = @"Data Source=DESKTOP-2021CRV\MSSQLSERVER01;Initial Catalog=QlKhachHangKhamRang;Integrated Security=True";
        SqlConnection sqlcon = new SqlConnection(strcon);
        int tongtien, gettiendv, gettienthuoc;
        string getMDV, getMT, ngay, gio;
        
        public frmhoadon()
        {
            InitializeComponent();
        }
        #region Method;
        public void tinhtien()
        {
           /* string tong;
            DataProvider.Instance.ExcuteQuery("select GIATHUOC from THUOC where TENTHUOC=N'" + combotenthuoc.SelectedItem.ToString() + "'");
            gettienthuoc = Int32.Parse(textgiathuoc.ToString());
            tong = Convert.ToString(gettiendv + gettienthuoc);
            txttongtien.Text = tong.ToString();*/
        }

        public void hienthidv()
        {
            string hien = "Select TENDV,GIADICHVU from DICHVU";
            combodv.DataSource = DataProvider.Instance.ExcuteQuery(hien);
            combodv.DisplayMember = "TENDV";
        }
        public void hienthithuoc()
        {
            string hien = "select TENTHUOC,GIATHUOC from THUOC";
            SqlDataAdapter da = new SqlDataAdapter(hien, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            combotenthuoc.Items.Add("");
            combotenthuoc.DataSource = dt;
            combotenthuoc.ValueMember = "TENTHUOC";
            
        }
        public void hienthihoadon()
        {
           dataGridView1.DataSource =  DataProvider.Instance.ExcuteQuery("USP_GETHOADON");
        }
        public void xacnhan()
        {
            DialogResult result = MessageBox.Show("Tiền dịch vụ = " + gettiendv + "\nTiền thuốc = " + gettienthuoc + "\nTổng cộng = " + gettiendv + " + " + gettienthuoc + " = " + tongtien + " VNĐ.", "Thông bác", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string kiemtra = "select count (*) from HOADON WHERE MHD ='" + textmhd.Text + "'";
                int result1 = DataProvider.Instance.ExcuteNonQuery(kiemtra);
                if (result1 < 1)
                    if (result1 == 0)
                    {
                        ngay = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                        gio = dateTimePicker2.Value.ToString("hh:mm tt");
                        string them = "insert into HOADON(MHD,MDV,MT,NGAYXUATHOADON,GIOXUATHOADON,TONG) " +
             "value ('" + textmhd.Text + "','" + getMDV + "','" + getMT + "','" + ngay + "','" + gio + "','" + tongtien + "')";
                        MessageBox.Show("Hóa đơn nhập thành công !\n" + "Mã hóa đơn :" + textmhd.Text + "\nNgày:" + ngay + "," + gio + ".", "Thông báo");
                    }
                MessageBox.Show("Đã tồn tại mã hóa đơn này,nhập mã khác !", "Thông báo");
            }
        }
        public void cbhienthidv()
        {
            //get mã dịch vụ
            string MDV = "select MDV from DICHVU where TENDV=N'" + combodv.SelectedItem.ToString() + "'";
            string GIA = "select GIADICHVU from DICHVU where TENDV=N'" + combodv.SelectedItem.ToString() + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(MDV, sqlcon);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            for (int i = 0; i < dt1.Rows.Count - 1;)
            {
                getMDV = dt1.Rows[i]["MDV"].ToString();
            }
        }
        public void cbhienthithuoc()
        {
            //get mã thuốc
            string MT = "select MT from THUOC where TENTHUOC=N'" + combotenthuoc.SelectedItem.ToString() + "'";
            string GIA = "";
            SqlDataAdapter da1 = new SqlDataAdapter(MT, sqlcon);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            foreach (DataRow row in dt1.Rows)
            {
                this.getMT = row["MT"].ToString();
            }
        }
        public void updatehoadon()
        {
            string kiemtra = "select count (*) from HOADON WHERE MDV ='" + textmhd.Text + "'";
            int result = DataProvider.Instance.ExcuteNonQuery(kiemtra);
            if (result < 1)
            {
                string sua = "update HOADON SET MDV='" + getMDV + "',MT ='" + getMT + "',NGAYXUATHOADON='" + ngay + "',GIOXUATHOADON ='" + gio + "',TONG ='" + tongtien + "' where MHD ='" + textmhd.Text + "'";
                SqlCommand cmd = new SqlCommand(sua, sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            else MessageBox.Show("Không tồn tại hóa đơn này !", "Thông báo");
        }
        public void xoahoadon()
        {
            string kiemtra = "select count (*) from HOADON WHERE MHD ='" + textmhd.Text + "'";
            int result = DataProvider.Instance.ExcuteNonQuery(kiemtra);
            if (result < 1)
            {
                string xoa = "delete from HOADON where MHD ='" + textmhd.Text + "'";
                SqlCommand cmd = new SqlCommand(xoa, sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else MessageBox.Show("Không tồn tại hóa đơn này !", "Thông báo");
        }
        #endregion
        #region Events

        private void combotenthuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbhienthithuoc();            
        }

        private void suahoadon_Click(object sender, EventArgs e)
        {
            updatehoadon();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            xoahoadon();
        }


        private void butxn_Click(object sender, EventArgs e)
        {
            xacnhan();       
        }

        private void frmhoadon_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            hienthidv();
            hienthithuoc();
            hienthihoadon();
            tinhtien();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sqlcon.Close();
        }

        private void frmhoadon_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlcon.Close();
        }
        #endregion
    }
}
