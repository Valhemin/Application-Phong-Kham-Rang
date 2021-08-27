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
using System.Security.Cryptography;
using PKR.DAO;

namespace PKR
{
    public partial class frmLogin : Form
    {
        static string strcon = @"Data Source=DESKTOP-2021CRV\MSSQLSERVER01;Initial Catalog=QlKhachHangKhamRang;Integrated Security=True";
        SqlConnection sqlcon = new SqlConnection(strcon);
        public frmLogin()
        {
            InitializeComponent();
        }
        #region Method
        bool xulidangnhap(string username, string password)
        {

            return LoginDAO.Instance.Login(username, password);
       
        }
        public void dangnhap()
        {
            if (xulidangnhap(txt_tk.Text, txt_mk.Text))
            {
                this.Hide();
                frmAdmin f = new frmAdmin(txt_tk.Text, txt_mk.Text);
                f.Show();
            }
            else MessageBox.Show("Sai tài khoản hoặc mật khẩu. Nhập lại", "Thông báo");
        }
#endregion
        #region Events
        private void bt_log_Click(object sender, EventArgs e)
        {
            dangnhap();
        }
    
            
        private void txt_tk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Chắc chắn muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        /*        private void txt_tk_Leave(object sender, EventArgs e)
       {
           if (txt_tk.Text == "")
           {
               txt_tk.Text = "Vui lòng nhập số điện thoại";
               txt_tk.ForeColor = Color.Gray;
           }
       }

       private void txt_tk_Enter(object sender, EventArgs e)
       {
           if(txt_tk.Text == "Vui lòng nhập số điện thoại")
           {
               txt_tk.Text = "";
               txt_tk.ForeColor = Color.Black;
           }
       }

       private void txt_tk_MouseClick(object sender, MouseEventArgs e)
       {
           txt_tk.Text = "";
       }*/
#endregion
    }
}
