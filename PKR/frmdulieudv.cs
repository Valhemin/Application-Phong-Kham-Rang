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
    public partial class frmdulieudv : Form
    {
        static string strcon = @"Data Source=DESKTOP-2021CRV\MSSQLSERVER01;Initial Catalog=QlKhachHangKhamRang;Integrated Security=True";
        SqlConnection sqlcon = new SqlConnection(strcon);
        public frmdulieudv()
        {
            InitializeComponent();
        }
        #region Method
        public void hienthi()
        {
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery("USP_GETLISTDICHVU");
        }
        public void themdv()
        {
            try
            {
                string kiemtra = "select * from DICHVU where MDV ='" + txt_DV.Text + "'";
                int result = DataProvider.Instance.ExcuteNonQuery(kiemtra);
                if (result < 1)
                {
                    string them = "Insert into DICHVU(MDV,TENDV,CHITIET,GIADICHVU,TENBS) " +
     "values(@d1,@d2,@d3,@d4,@d5)";
                    SqlCommand cmd = new SqlCommand(them, sqlcon);
                    cmd.Parameters.Add("@d1", txt_DV.Text);
                    cmd.Parameters.Add("@d2", txttendv.Text);
                    cmd.Parameters.Add("@d3", txtchitiet.Text);
                    cmd.Parameters.Add("@d4", tien.Text);
                    cmd.Parameters.Add("@d5", namebs.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    hienthi();
                }
                else MessageBox.Show("Đã tồn tại dịch vụ này", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            finally
            {
                sqlcon.Close();
            }
        }
        public void suadv()
        {
            try
            {
                string kiemtra = "select count (*) from DICHVU WHERE MDV ='" + txt_DV.Text + "'";
                int result = DataProvider.Instance.ExcuteNonQuery(kiemtra);
                if (result < 1)
                {
                    string sua = "update DICHVU SET TENDV =N'" + txttendv.Text + "',CHITIET =N'" + txtchitiet.Text + "',GIADICHVU = '" + tien.Text + "',TENBS=N '" + namebs.Text + "' where MDV ='" + txt_DV.Text + "'";
                    SqlCommand cmd = new SqlCommand(sua, sqlcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    hienthi();
                }
                else MessageBox.Show("Không tồn tại dịch vụ này", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            finally
            {
                sqlcon.Close();
            }
        }
        public void xoadv()
        {
            try
            {
                string kiemtra = "select count (*) from DICHVU WHERE MDV ='" + txt_DV.Text + "'";
                int result = DataProvider.Instance.ExcuteNonQuery(kiemtra);
                if (result < 1)
                {
                    string xoauser = "delete from DICHVU where MDV ='" + txt_DV.Text + "'";
                    SqlCommand cmd = new SqlCommand(xoauser, sqlcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    hienthi();
                }
                else MessageBox.Show("Không tồn tại", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            finally
            {
                sqlcon.Close();
            }
        }
#endregion
        #region Events
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmdulieudv_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themdv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            suadv();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xoadv();
        }

        private void tien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_DV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txttendv.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtchitiet.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            namebs.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            tien.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }
        #endregion
    }
}
