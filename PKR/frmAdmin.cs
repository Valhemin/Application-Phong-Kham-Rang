using PKR.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKR
{
    public partial class frmAdmin : Form
    {
        string username, password;
        int tk;
        public frmAdmin()
        {
            InitializeComponent();
        }
        public frmAdmin(string user,string pass)
        {
            InitializeComponent();
            this.username = user;
            this.password = pass;
            
        }
        public void kiemtratk()
        {
            /*int result1 = DataProvider.Instance.ExcuteNonQuery("select * FROM ACCOUNT where TAIKHOAN = '" + username + "'and MATKHAU = '" + password + "'and LOAITK ='" + "admin" + "'");
            if (result1 > 0)
            {
                btntk.Visible = true;
            }
            else btntk.Visible = false;*/
            int result = DataProvider.Instance.ExcuteNonQuery("select * from account Where  TAIKHOAN = '" + username + "'and MATKHAU = '" + password + "'and HOTEN='" + "" + "'");
            if(result == 1)
            {
                MessageBox.Show("Chưa nhập thông tin cá nhân ! Hãy đi nhập", "Thông báo");
                frmEditInfor f = new frmEditInfor(username,password);
                f.Show();
            }
        }

        #region events
        private void btnthongke_Click(object sender, EventArgs e)
        {
            frmThongke f = new frmThongke();
            f.Show();
        }

        private void btnlichhen_Click_1(object sender, EventArgs e)
        {
            frmlichhen f = new frmlichhen();
            f.Show();
        }

        private void btndichvu_Click_1(object sender, EventArgs e)
        {
            frmdulieudv f = new frmdulieudv();
            f.Show();
        }

        private void btnthuoc_Click_1(object sender, EventArgs e)
        {
            frmdulieuthuoc f = new frmdulieuthuoc();
            f.Show();
        }

        private void btnlaphoadon_Click_1(object sender, EventArgs e)
        {
            frmhoadon f = new frmhoadon();
            f.Show();
        }

        private void btntk_Click_1(object sender, EventArgs e)
        {
            frmAccount f = new frmAccount();
            f.Show();
        }

        private void btneditinfor_Click_1(object sender, EventArgs e)
        {
            frmEditInfor f = new frmEditInfor(username, password);
            f.Show();
        }

        private void btneditpass_Click_1(object sender, EventArgs e)
        {
            frmEditPass f = new frmEditPass(username, password);
            f.Show();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            kiemtratk();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin f = new frmLogin();
            f.Show();
        }
        #endregion 
    }
}
