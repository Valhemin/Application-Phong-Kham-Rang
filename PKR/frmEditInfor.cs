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
    public partial class frmEditInfor : Form
    {
        private string username, password;
        static string strcon = @"Data Source=DESKTOP-2021CRV\MSSQLSERVER01;Initial Catalog=QlKhachHangKhamRang;Integrated Security=True";
        SqlConnection sqlcon = new SqlConnection(strcon);
        public frmEditInfor()
        {
            InitializeComponent();
        }
        #region Method
        public frmEditInfor(string user, string pass)
        {
            InitializeComponent();
            this.username = user;
            this.password = pass;
        }
        public void hienthi()
        {
            string sqlselect = "select HOTEN,NAMSINH,GIOITINH,DIACHI from ACCOUNT where TAIKHOAN = '" + username + "' and MATKHAU='" + password + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlselect, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void bt_ok_Click(object sender, EventArgs e)
        {
            try
            {
                string checkbox = "";
                if (nam.Checked)
                    checkbox = nam.Text;
                if (nu.Checked)
                    checkbox = nu.Text;
                checkbox = khac.Text;
                SqlCommand cmd = new SqlCommand("Update ACCOUNT Set HOTEN=N'" + txt_hoten.Text + @"',NAMSINH ='" + txt_namsinh.Text + @"',GIOITINH=N'" + checkbox + @"',DIACHI=N'" + txt_diachi.Text + @"' where TAIKHOAN ='" + username + "' and MATKHAU = '" + password + "'", sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo");
                hienthi();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string checkbox = "";
            if (nam.Checked)
                checkbox = nam.Text;
            if (nu.Checked)
                checkbox = nu.Text;
            checkbox = khac.Text;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_hoten.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_namsinh.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_diachi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            string gt = dataGridView1.Rows[i].Cells[2].Value.ToString();
            if (gt.Trim() == "Nam")
            {
                nam.Checked = true;
            }
            else if (gt.Trim() == "Nữ")
            {
                nu.Checked = true;
            }
            else
            {
                khac.Checked = true;
            }
        }

            private void bt_trove_Click(object sender, EventArgs e)
        {
            sqlcon.Close();
            this.Hide();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            txt_hoten.Text = "";
            txt_namsinh.Text = "";
            txt_diachi.Text = "";
            nam.Checked = false;
            nu.Checked = false;
            khac.Checked = false;
        }

        private void frmEditInforAdmin_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            hienthi();       
        }

        private void frmEditInforAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlcon.Close();
        }
        #endregion
    }
}
