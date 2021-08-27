
namespace PKR
{
    partial class frmAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.tim = new System.Windows.Forms.TextBox();
            this.mknhanvien = new System.Windows.Forms.TextBox();
            this.tknhanvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tim
            // 
            this.tim.Location = new System.Drawing.Point(234, 14);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(299, 20);
            this.tim.TabIndex = 1;
            this.tim.Enter += new System.EventHandler(this.tim_Enter);
            this.tim.Leave += new System.EventHandler(this.tim_Leave);
            // 
            // mknhanvien
            // 
            this.mknhanvien.Location = new System.Drawing.Point(966, 187);
            this.mknhanvien.Name = "mknhanvien";
            this.mknhanvien.Size = new System.Drawing.Size(158, 20);
            this.mknhanvien.TabIndex = 4;
            // 
            // tknhanvien
            // 
            this.tknhanvien.Location = new System.Drawing.Point(966, 153);
            this.tknhanvien.Name = "tknhanvien";
            this.tknhanvien.Size = new System.Drawing.Size(158, 20);
            this.tknhanvien.TabIndex = 3;
            this.tknhanvien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tknhanvien_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(859, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tìm thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(859, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tài khoản";
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(1052, 257);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(83, 39);
            this.xoa.TabIndex = 8;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click_1);
            // 
            // sua
            // 
            this.sua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.Location = new System.Drawing.Point(952, 257);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(83, 39);
            this.sua.TabIndex = 7;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click_1);
            // 
            // bttim
            // 
            this.bttim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttim.Location = new System.Drawing.Point(629, 14);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(67, 21);
            this.bttim.TabIndex = 2;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click_1);
            // 
            // them
            // 
            this.them.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(854, 257);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(83, 39);
            this.them.TabIndex = 6;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TAIKHOAN,
            this.MATKHAU,
            this.loai,
            this.hoten,
            this.namsinh,
            this.Gioitin,
            this.diachi});
            this.dataGridView2.Location = new System.Drawing.Point(28, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(817, 311);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // TAIKHOAN
            // 
            this.TAIKHOAN.DataPropertyName = "TAIKHOAN";
            this.TAIKHOAN.HeaderText = "Tài khoản";
            this.TAIKHOAN.Name = "TAIKHOAN";
            this.TAIKHOAN.ReadOnly = true;
            this.TAIKHOAN.Width = 80;
            // 
            // MATKHAU
            // 
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "Mật khẩu";
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.ReadOnly = true;
            this.MATKHAU.Width = 80;
            // 
            // loai
            // 
            this.loai.DataPropertyName = "LOAITK";
            this.loai.HeaderText = "Loại TK";
            this.loai.Name = "loai";
            this.loai.ReadOnly = true;
            this.loai.Width = 80;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "HOTEN";
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // namsinh
            // 
            this.namsinh.DataPropertyName = "NAMSINH";
            this.namsinh.HeaderText = "Năm Sinh";
            this.namsinh.Name = "namsinh";
            this.namsinh.ReadOnly = true;
            this.namsinh.Width = 80;
            // 
            // Gioitin
            // 
            this.Gioitin.DataPropertyName = "GIOITINH";
            this.Gioitin.HeaderText = "Giới Tính";
            this.Gioitin.Name = "Gioitin";
            this.Gioitin.ReadOnly = true;
            this.Gioitin.Width = 80;
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi.DataPropertyName = "DIACHI";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1041, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(859, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Loại tài khoản";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(966, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 410);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.mknhanvien);
            this.Controls.Add(this.tknhanvien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.them);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí tài khoản";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tim;
        private System.Windows.Forms.TextBox mknhanvien;
        private System.Windows.Forms.TextBox tknhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAIKHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitin;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}