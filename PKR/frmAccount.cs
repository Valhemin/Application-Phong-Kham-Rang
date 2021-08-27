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
using PKR.DAO;

namespace PKR
{
    public partial class frmAccount : Form
    {
        static string strcon = @"Data Source=DESKTOP-2021CRV\MSSQLSERVER01;Initial Catalog=QlKhachHangKhamRang;Integrated Security=True";
        SqlConnection sqlcon = new SqlConnection(strcon);
        public frmAccount()
        {
            InitializeComponent();
            comboBox1.Items.Add("admin");
            comboBox1.Items.Add("staff");
        }
        #region Method
        public void hienthi()
        {
            dataGridView2.DataSource = DataProvider.Instance.ExcuteQuery("USP_GETLISTACCOUNT");
        }
        private void frmAccount_Load(object sender, EventArgs e)
        {
            hienthi();            
        }
        public void timtk()
        {
            if (tim.Text != "")
            {
                string timacc = "select TAIKHOAN,MATKHAU,HOTEN,NAMSINH,GIOITINH,DIACHI from ACCOUNT " +
     "where TAIKHOAN like '%" + tim.Text + "%'or HOTEN like N'%" + tim.Text + "%'or NAMSINH like N'%" + tim.Text + "%' or GIOITINH like N'%" + tim.Text + "%' or DIACHI like N'%" + tim.Text + "%'";
                dataGridView2.DataSource = DataProvider.Instance.ExcuteQuery(timacc);
            }
            else hienthi();
        }
        public void themtk()
        {
            if (tknhanvien.TextLength == 10)
            {
                string kiemtra = "select * from ACCOUNT WHERE TAIKHOAN ='" + tknhanvien.Text + "'";
                int result = DataProvider.Instance.ExcuteNonQuery(kiemtra);
                if (result < 1)
                {
                    sqlcon.Open();
                    string them = "Insert into ACCOUNT(TAIKHOAN,MATKHAU,LOAITK) " +
     "values(@d1,@d2,@d3)";
                    SqlCommand cmd = new SqlCommand(them, sqlcon);
                    cmd.Parameters.Add("@d1", tknhanvien.Text);
                    cmd.Parameters.Add("@d2", mknhanvien.Text);
                    cmd.Parameters.Add("@d3", comboBox1.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    sqlcon.Close();
                    hienthi();

                }
                else MessageBox.Show("Đã tồn tại tài khoản này", "Thông báo");
            }
            else MessageBox.Show("Nhập đúng số điện thoại", "Thông báo");
        }
        public void suatk()
        {
            string kiemtra = "select count (*) from ACCOUNT WHERE TAIKHOAN ='" + tknhanvien.Text + "'";
            int result = DataProvider.Instance.ExcuteNonQuery(kiemtra);
            if (result > 0)
            {
                sqlcon.Open();
                string sua = "update ACCOUNT SET MATKHAU ='" + mknhanvien.Text + "' where TAIKHOAN ='" + tknhanvien.Text + "'";
                SqlCommand cmd = new SqlCommand(sua, sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                sqlcon.Close();
                hienthi();
            }
            else MessageBox.Show("Không tồn tại tài khoản này", "Thông báo");
        }
        public void xoatk()
        {
            string kiemtra = "select count (*) from ACCOUNT WHERE TAIKHOAN ='" + tknhanvien.Text + "'";
            int result = DataProvider.Instance.ExcuteNonQuery(kiemtra);
            if (result > 0)
            {
                sqlcon.Open();
                string xoauser = "delete from ACCOUNT where TAIKHOAN ='" + tknhanvien.Text + "'";
                SqlCommand cmd = new SqlCommand(xoauser, sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo");
                sqlcon.Close();
                hienthi();
            }
            else MessageBox.Show("Không tồn tại tài khoản này", "Thông báo");
        }
        #endregion
        #region Events
        private void bttim_Click_1(object sender, EventArgs e)
        {
            timtk();
        }

        private void them_Click_1(object sender, EventArgs e)
        {
            themtk();
        }

        private void sua_Click_1(object sender, EventArgs e)
        {
            suatk();
        }

        private void xoa_Click_1(object sender, EventArgs e)
        {
            xoatk();
        }
                
        private void tknhanvien_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tim_Leave(object sender, EventArgs e)
        {
            if (tim.Text == "")
            {
                tim.Text = "Có thể tìm theo Tên,Năm Sinh,Địa chỉ,...";
                tim.ForeColor = Color.Gray;
            }
        }

        private void tim_Enter(object sender, EventArgs e)
        {
            if (tim.Text == "Có thể tìm theo Tên,Năm Sinh,Địa chỉ,...")
            {
                tim.Text = "";
                tim.ForeColor = Color.Black;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            tknhanvien.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            mknhanvien.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion


    }
}
