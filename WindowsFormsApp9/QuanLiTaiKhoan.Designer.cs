namespace WindowsFormsApp9
{
    partial class QuanLiTaiKhoan
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
            this.lbnTenDangNhap = new System.Windows.Forms.Label();
            this.lbnMatKhau = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tendangnhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MatKhau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VaiTro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbnTenDangNhap
            // 
            this.lbnTenDangNhap.AutoSize = true;
            this.lbnTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTenDangNhap.Location = new System.Drawing.Point(12, 80);
            this.lbnTenDangNhap.Name = "lbnTenDangNhap";
            this.lbnTenDangNhap.Size = new System.Drawing.Size(132, 20);
            this.lbnTenDangNhap.TabIndex = 0;
            this.lbnTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lbnMatKhau
            // 
            this.lbnMatKhau.AutoSize = true;
            this.lbnMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnMatKhau.Location = new System.Drawing.Point(12, 167);
            this.lbnMatKhau.Name = "lbnMatKhau";
            this.lbnMatKhau.Size = new System.Drawing.Size(88, 20);
            this.lbnMatKhau.TabIndex = 0;
            this.lbnMatKhau.Text = "Mật Khẩu";
            this.lbnMatKhau.Click += new System.EventHandler(this.lbnMatKhau_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 274);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 43);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(145, 274);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 43);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(255, 274);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 43);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(12, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 48);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Trở lại";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tendangnhap,
            this.MatKhau,
            this.VaiTro});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(358, 1);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(440, 447);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Tendangnhap
            // 
            this.Tendangnhap.Text = "Tên đăng nhập";
            this.Tendangnhap.Width = 160;
            // 
            // MatKhau
            // 
            this.MatKhau.Text = "Mật Khẩu";
            this.MatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MatKhau.Width = 146;
            // 
            // VaiTro
            // 
            this.VaiTro.Text = "Vai Trò";
            this.VaiTro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VaiTro.Width = 160;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 156);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // QuanLiTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbnMatKhau);
            this.Controls.Add(this.lbnTenDangNhap);
            this.Name = "QuanLiTaiKhoan";
            this.Text = "QuanLiTaiKhoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnTenDangNhap;
        private System.Windows.Forms.Label lbnMatKhau;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Tendangnhap;
        private System.Windows.Forms.ColumnHeader MatKhau;
        private System.Windows.Forms.ColumnHeader VaiTro;
        private System.Windows.Forms.TextBox textBox2;
    }
}