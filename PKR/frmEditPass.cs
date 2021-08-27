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
    public partial class frmEditPass : Form
    {
        static string strcon = @"Data Source=DESKTOP-2021CRV\MSSQLSERVER01;Initial Catalog=QlKhachHangKhamRang;Integrated Security=True";
        SqlConnection sqlcon = new SqlConnection(strcon);
        string username, password;
        public frmEditPass()
        {
            InitializeComponent();
        }
        public frmEditPass(string user,string pass)
        {
            this.username = user;
            this.password = pass;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Count (*) from ACCOUNT where TAIKHOAN = '" + username + "' and MATKHAU='" + txtoldpass.Text + "'", sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txt_newpass.Text == txt_renewpass.Text)
                {
                    if (txt_newpass.Text.Length >= 6)
                    {
                        SqlDataAdapter da1 = new SqlDataAdapter("Update ACCOUNT set MATKHAU = '" + txt_newpass.Text + "' where TAIKHOAN = '" + username + "' and MATKHAU = '" +txtoldpass.Text + "'", sqlcon);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        sqlcon.Close();
                    }
                    else
                    {
                        errorProvider3.SetError(txt_newpass, "Độ dài mật khẩu quá ngắn! ( Tối thiếu 6 kí tự)");
                    }
                }
                else
                {
                    errorProvider3.SetError(txtoldpass, "Bạn chưa điền mật khẩu!");
                    errorProvider4.SetError(txt_renewpass, "Mật khẩu nhập lại chưa đúng!");
                }
        }
            else
            {
                errorProvider2.SetError(txtoldpass, " Mật khẩu cũ không đúng !");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {         
            this.Hide();            
        }
    }
}