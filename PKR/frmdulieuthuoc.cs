using PKR.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PKR
{
    public partial class frmdulieuthuoc : Form
    {
        static string strcon = @"Data Source=DESKTOP-2021CRV\MSSQLSERVER01;Initial Catalog=QlKhachHangKhamRang;Integrated Security=True";
        SqlConnection sqlcon = new SqlConnection(strcon);
        public frmdulieuthuoc()
        {
            InitializeComponent();
        }
        #region Method
        public void themthuoc()
        {
            try
            {
                string kiemtra = "select * from THUOC where MT ='" + txt_MT.Text + "'";
                int result = DataProvider.Instance.ExcuteNonQuery(kiemtra);
                if (result < 1)
                {
                    string them = "Insert into THUOC(MT,TENTHUOC,GIATHUOC) " +
     "values(@d1,@d2,@d3)";
                    SqlCommand cmd = new SqlCommand(them, sqlcon);
                    cmd.Parameters.Add("@d1", txt_MT.Text);
                    cmd.Parameters.Add("@d2", textBox1.Text);
                    cmd.Parameters.Add("@d3", textBox2.Text);
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
        public void capnhatthuoc()
        {
            try
            {
                string kiemtra = "select count (*) from THUOC WHERE  MT ='" + txt_MT.Text + "'";
                int result = DataProvider.Instance.ExcuteNonQuery(kiemtra);
                if (result < 1)
                {
                    string sua = "update THUOC SET TENTHUOC =N'" + textBox1.Text + "',GIATHUOC = '" + textBox2.Text + "' where MT ='" + txt_MT.Text + "'";
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
        public void xoathuoc()
        {
            try
            {
                string kiemtra = "select count (*) from THUOC WHERE MT ='" + txt_MT.Text + "'";
                int result = DataProvider.Instance.ExcuteNonQuery(kiemtra);
                if (result < 1)
                {
                    string xoauser = "delete from THUOC where MT ='" + txt_MT.Text + "'";
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
        public void hienthi()
        {
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery("USP_GETLISTTHUOC");
        }
        #endregion
        #region Events
        private void frmdulieu_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }      

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_MT.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            themthuoc();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            capnhatthuoc();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            xoathuoc();
        }
        #endregion
    }
}
