
namespace PKR
{
    partial class frmEditInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditInfor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Columm1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khac = new System.Windows.Forms.RadioButton();
            this.nu = new System.Windows.Forms.RadioButton();
            this.nam = new System.Windows.Forms.RadioButton();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_namsinh = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_trove = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(33, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 107);
            this.panel1.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columm1,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(456, 101);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Columm1
            // 
            this.Columm1.DataPropertyName = "HOTEN";
            this.Columm1.HeaderText = "Họ tên";
            this.Columm1.Name = "Columm1";
            this.Columm1.ReadOnly = true;
            this.Columm1.Width = 120;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NAMSINH";
            this.Column1.HeaderText = "Năm Sinh";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GIOITINH";
            this.Column2.HeaderText = "Giới Tính";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DIACHI";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // khac
            // 
            this.khac.AutoSize = true;
            this.khac.Location = new System.Drawing.Point(296, 309);
            this.khac.Name = "khac";
            this.khac.Size = new System.Drawing.Size(50, 17);
            this.khac.TabIndex = 26;
            this.khac.TabStop = true;
            this.khac.Text = "Khác";
            this.khac.UseVisualStyleBackColor = true;
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Location = new System.Drawing.Point(229, 309);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(39, 17);
            this.nu.TabIndex = 25;
            this.nu.TabStop = true;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Location = new System.Drawing.Point(167, 309);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(47, 17);
            this.nam.TabIndex = 24;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(166, 338);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(237, 27);
            this.txt_diachi.TabIndex = 28;
            // 
            // txt_namsinh
            // 
            this.txt_namsinh.Location = new System.Drawing.Point(166, 267);
            this.txt_namsinh.Multiline = true;
            this.txt_namsinh.Name = "txt_namsinh";
            this.txt_namsinh.Size = new System.Drawing.Size(59, 27);
            this.txt_namsinh.TabIndex = 23;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(167, 226);
            this.txt_hoten.Multiline = true;
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(161, 27);
            this.txt_hoten.TabIndex = 22;
            // 
            // bt_reset
            // 
            this.bt_reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.Location = new System.Drawing.Point(296, 386);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(94, 47);
            this.bt_reset.TabIndex = 31;
            this.bt_reset.Text = "Ghi lại";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_trove
            // 
            this.bt_trove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_trove.Location = new System.Drawing.Point(407, 161);
            this.bt_trove.Name = "bt_trove";
            this.bt_trove.Size = new System.Drawing.Size(85, 30);
            this.bt_trove.TabIndex = 35;
            this.bt_trove.Text = "Trở về";
            this.bt_trove.UseVisualStyleBackColor = true;
            this.bt_trove.Click += new System.EventHandler(this.bt_trove_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_ok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ok.Location = new System.Drawing.Point(105, 386);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(94, 47);
            this.bt_ok.TabIndex = 29;
            this.bt_ok.Text = "Đồng ý";
            this.bt_ok.UseVisualStyleBackColor = false;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Năm sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Sửa đổi thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Họ và Tên";
            // 
            // frmEditInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.khac);
            this.Controls.Add(this.nu);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_namsinh);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_trove);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa thông tin cá nhân";
            this.Load += new System.EventHandler(this.frmEditInforAdmin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.RadioButton khac;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_namsinh;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_trove;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}