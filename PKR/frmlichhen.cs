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
namespace PKR
{
    public partial class frmlichhen : Form
    {
        static string strcon = @"Data Source=DESKTOP-2021CRV\MSSQLSERVER01;Initial Catalog=QlKhachHangKhamRang;Integrated Security=True";
        SqlConnection sqlcon = new SqlConnection(strcon);
        
        public frmlichhen()
        {
            InitializeComponent();
        }
        #region Method
        public void hienthi()
        {
            string hien = "select TEN,NGAYHEN,GIOHEN,TENDV from LICHHEN";
            SqlDataAdapter da = new SqlDataAdapter(hien,sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void laydt()
        {
            string laydl = "select TENDV from DICHVU";
            SqlDataAdapter da = new SqlDataAdapter(laydl, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "TENDV";
            listBox1.ValueMember = "TENDV";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string timlich = "select TEN,NGAYHEN,GIOHEN,TENDV from LICHHEN " +
     "where TEN like '%" + textBox1.Text + "%'or NGAYHEN like N'%" + textBox1.Text + "%'or GIOHEN like N'%" + textBox1.Text + "%' or TENDV like N'%" + textBox1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(timlich, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ngay = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string gio = dateTimePicker2.Value.ToString("hh:mm tt");
                int i;
            i = dataGridView1.CurrentRow.Index;
            ten.Text=dataGridView1.Rows[i].Cells[0].Value.ToString();
            ngay = dataGridView1.Rows[i].Cells[1].Value.ToString();
            gio = dataGridView1.Rows[i].Cells[2].Value.ToString();
            listBox1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ngay = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string gio = dateTimePicker2.Value.ToString("hh:mm tt");
            string kiemtra = "select TEN,NGAYHEN,GIOHEN,TENDV from LICHHEN where TEN =N'" + ten.Text + "' and NGAYHEN ='"+ngay+"'and TENDV =N'"+listBox1.SelectedValue+"'";
            SqlDataAdapter da1 = new SqlDataAdapter(kiemtra, sqlcon);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            if (dt1.Rows.Count < 1)
            {
                string them = "Insert into LICHHEN(TEN,NGAYHEN,GIOHEN,TENDV) values (N'" + ten.Text + "','" + ngay + "','" + gio + "',N'" + listBox1.SelectedValue + "')";
                SqlCommand cmd = new SqlCommand(them, sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công !", "Thông báo");
                hienthi();
            }
            else MessageBox.Show("Đã tồn tại khách hàng này", "Thông báo");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ngay = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string gio = dateTimePicker2.Value.ToString("hh:mm tt");
            string kiemtra = "select count (*) from LICHHEN WHERE TEN ='" + ten.Text + "' and NGAYHEN ='" + ngay + "'and TENDV =N'" + listBox1.SelectedValue + "'";
            SqlDataAdapter da = new SqlDataAdapter(kiemtra, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string sua = "update LICHHEN SET TEN =N'" + ten.Text + "',NGAYHEN ='" + ngay + "',GIOHEN = '" + gio + "',TENDV=N'" + listBox1.SelectedValue + "' where TEN ='" + ten.Text + "'";
                SqlCommand cmd = new SqlCommand(sua, sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                hienthi();
            }
            else MessageBox.Show("Không tồn tại khách hàng này", "Thông báo");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ngay = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string gio = dateTimePicker2.Value.ToString("hh:mm tt");
            string kiemtra = "select count (*) from LICHHEN WHERE TEN =N'" + ten.Text + "' and NGAYHEN='"+ngay+ "'and TENDV =N'" + listBox1.SelectedValue + "'";
            SqlDataAdapter da = new SqlDataAdapter(kiemtra, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string xoauser = "delete from LICHHEN where TEN =N'" + ten.Text + "'and NGAYHEN='"+ngay+"'and GIOHEN ='"+gio+"'";
                SqlCommand cmd = new SqlCommand(xoauser, sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo");
                hienthi();
            }
            else MessageBox.Show("Không tồn tại khách hàng này", "Thông báo");
        }
        #endregion
        #region events
        private void frmlichhenadmin_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            hienthi();
            laydt();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            sqlcon.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Có thể tìm theo Tên,Ngày,Giờ,Dịch vụ...";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Có thể tìm theo Tên,Ngày,Giờ,Dịch vụ...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        #endregion
    }
}
