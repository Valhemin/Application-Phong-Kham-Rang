
namespace PKR
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlichhen = new System.Windows.Forms.Button();
            this.btnthuoc = new System.Windows.Forms.Button();
            this.btndichvu = new System.Windows.Forms.Button();
            this.btnlaphoadon = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.btneditpass = new System.Windows.Forms.Button();
            this.btneditinfor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PKR.Properties.Resources.pk;
            this.panel1.Location = new System.Drawing.Point(179, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 460);
            this.panel1.TabIndex = 1;
            // 
            // btnlichhen
            // 
            this.btnlichhen.BackColor = System.Drawing.Color.Yellow;
            this.btnlichhen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlichhen.Location = new System.Drawing.Point(27, 29);
            this.btnlichhen.Name = "btnlichhen";
            this.btnlichhen.Size = new System.Drawing.Size(120, 61);
            this.btnlichhen.TabIndex = 2;
            this.btnlichhen.Text = "Quản lí lịch hẹn";
            this.btnlichhen.UseVisualStyleBackColor = false;
            this.btnlichhen.Click += new System.EventHandler(this.btnlichhen_Click_1);
            // 
            // btnthuoc
            // 
            this.btnthuoc.BackColor = System.Drawing.Color.Chartreuse;
            this.btnthuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthuoc.Location = new System.Drawing.Point(27, 223);
            this.btnthuoc.Name = "btnthuoc";
            this.btnthuoc.Size = new System.Drawing.Size(120, 57);
            this.btnthuoc.TabIndex = 2;
            this.btnthuoc.Text = "Thuốc";
            this.btnthuoc.UseVisualStyleBackColor = false;
            this.btnthuoc.Click += new System.EventHandler(this.btnthuoc_Click_1);
            // 
            // btndichvu
            // 
            this.btndichvu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btndichvu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndichvu.Location = new System.Drawing.Point(27, 125);
            this.btndichvu.Name = "btndichvu";
            this.btndichvu.Size = new System.Drawing.Size(120, 61);
            this.btndichvu.TabIndex = 2;
            this.btndichvu.Text = "Dịch vụ";
            this.btndichvu.UseVisualStyleBackColor = false;
            this.btndichvu.Click += new System.EventHandler(this.btndichvu_Click_1);
            // 
            // btnlaphoadon
            // 
            this.btnlaphoadon.BackColor = System.Drawing.Color.LightSalmon;
            this.btnlaphoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlaphoadon.Location = new System.Drawing.Point(27, 318);
            this.btnlaphoadon.Name = "btnlaphoadon";
            this.btnlaphoadon.Size = new System.Drawing.Size(120, 62);
            this.btnlaphoadon.TabIndex = 2;
            this.btnlaphoadon.Text = "Lập hóa đơn";
            this.btnlaphoadon.UseVisualStyleBackColor = false;
            this.btnlaphoadon.Click += new System.EventHandler(this.btnlaphoadon_Click_1);
            // 
            // btntk
            // 
            this.btntk.BackColor = System.Drawing.Color.RoyalBlue;
            this.btntk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntk.Location = new System.Drawing.Point(27, 480);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(120, 48);
            this.btntk.TabIndex = 2;
            this.btntk.Text = "Tài khoản";
            this.btntk.UseVisualStyleBackColor = false;
            this.btntk.Click += new System.EventHandler(this.btntk_Click_1);
            // 
            // btndangxuat
            // 
            this.btndangxuat.BackColor = System.Drawing.Color.Beige;
            this.btndangxuat.Location = new System.Drawing.Point(749, 487);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(75, 41);
            this.btndangxuat.TabIndex = 3;
            this.btndangxuat.Text = "Đăng xuất";
            this.btndangxuat.UseVisualStyleBackColor = false;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.Color.PowderBlue;
            this.btnthongke.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.Location = new System.Drawing.Point(27, 415);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(120, 48);
            this.btnthongke.TabIndex = 2;
            this.btnthongke.Text = "Thống kê doanh thu";
            this.btnthongke.UseVisualStyleBackColor = false;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btneditpass
            // 
            this.btneditpass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btneditpass.Location = new System.Drawing.Point(654, 487);
            this.btneditpass.Name = "btneditpass";
            this.btneditpass.Size = new System.Drawing.Size(75, 41);
            this.btneditpass.TabIndex = 3;
            this.btneditpass.Text = "Đổi mật khẩu";
            this.btneditpass.UseVisualStyleBackColor = false;
            this.btneditpass.Click += new System.EventHandler(this.btneditpass_Click_1);
            // 
            // btneditinfor
            // 
            this.btneditinfor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btneditinfor.Location = new System.Drawing.Point(532, 487);
            this.btneditinfor.Name = "btneditinfor";
            this.btneditinfor.Size = new System.Drawing.Size(99, 41);
            this.btneditinfor.TabIndex = 3;
            this.btneditinfor.Text = "Thay đổi thông tin cá nhân";
            this.btneditinfor.UseVisualStyleBackColor = false;
            this.btneditinfor.Click += new System.EventHandler(this.btneditinfor_Click_1);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 540);
            this.Controls.Add(this.btneditinfor);
            this.Controls.Add(this.btneditpass);
            this.Controls.Add(this.btndangxuat);
            this.Controls.Add(this.btndichvu);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.btnlaphoadon);
            this.Controls.Add(this.btnthuoc);
            this.Controls.Add(this.btnlichhen);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị viên";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlichhen;
        private System.Windows.Forms.Button btnthuoc;
        private System.Windows.Forms.Button btndichvu;
        private System.Windows.Forms.Button btnlaphoadon;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Button btneditpass;
        private System.Windows.Forms.Button btneditinfor;
    }
}