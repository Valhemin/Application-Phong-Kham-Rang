
namespace PKR
{
    partial class frmdulieudv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdulieudv));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtchitiet = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.namebs = new System.Windows.Forms.TextBox();
            this.tien = new System.Windows.Forms.TextBox();
            this.txttendv = new System.Windows.Forms.TextBox();
            this.txt_DV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.mdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chitiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mdv,
            this.tendv,
            this.chitiet,
            this.tenbs,
            this.gia});
            this.dataGridView1.Location = new System.Drawing.Point(32, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(751, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtchitiet
            // 
            this.txtchitiet.Location = new System.Drawing.Point(339, 519);
            this.txtchitiet.Multiline = true;
            this.txtchitiet.Name = "txtchitiet";
            this.txtchitiet.Size = new System.Drawing.Size(169, 61);
            this.txtchitiet.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Location = new System.Drawing.Point(433, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(380, 671);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(288, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // namebs
            // 
            this.namebs.Location = new System.Drawing.Point(339, 599);
            this.namebs.Name = "namebs";
            this.namebs.Size = new System.Drawing.Size(127, 20);
            this.namebs.TabIndex = 4;
            // 
            // tien
            // 
            this.tien.Location = new System.Drawing.Point(339, 634);
            this.tien.Name = "tien";
            this.tien.Size = new System.Drawing.Size(127, 20);
            this.tien.TabIndex = 5;
            this.tien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tien_KeyPress);
            // 
            // txttendv
            // 
            this.txttendv.Location = new System.Drawing.Point(339, 482);
            this.txttendv.Name = "txttendv";
            this.txttendv.Size = new System.Drawing.Size(146, 20);
            this.txttendv.TabIndex = 2;
            // 
            // txt_DV
            // 
            this.txt_DV.Location = new System.Drawing.Point(339, 434);
            this.txt_DV.Name = "txt_DV";
            this.txt_DV.Size = new System.Drawing.Size(57, 20);
            this.txt_DV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 635);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên Bác sĩ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Dịch vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(669, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 9;
            this.button4.Text = "Trở về";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mdv
            // 
            this.mdv.DataPropertyName = "MDV";
            this.mdv.HeaderText = "Mã dịch vụ";
            this.mdv.Name = "mdv";
            this.mdv.Width = 90;
            // 
            // tendv
            // 
            this.tendv.DataPropertyName = "TENDV";
            this.tendv.HeaderText = "Tên Dịch vụ";
            this.tendv.Name = "tendv";
            this.tendv.ReadOnly = true;
            this.tendv.Width = 130;
            // 
            // chitiet
            // 
            this.chitiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chitiet.DataPropertyName = "CHITIET";
            this.chitiet.HeaderText = "Chi Tiết";
            this.chitiet.Name = "chitiet";
            this.chitiet.ReadOnly = true;
            // 
            // tenbs
            // 
            this.tenbs.DataPropertyName = "TENBS";
            this.tenbs.HeaderText = "Tên Bác Sĩ";
            this.tenbs.Name = "tenbs";
            this.tenbs.ReadOnly = true;
            this.tenbs.Width = 130;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "GIADICHVU";
            this.gia.HeaderText = "Giá ";
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            this.gia.Width = 110;
            // 
            // frmdulieudv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(818, 730);
            this.Controls.Add(this.txtchitiet);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.namebs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttendv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdulieudv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Các dịch vụ";
            this.Load += new System.EventHandler(this.frmdulieudv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tien;
        private System.Windows.Forms.TextBox txttendv;
        private System.Windows.Forms.TextBox txt_DV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox namebs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtchitiet;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn chitiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
    }
}