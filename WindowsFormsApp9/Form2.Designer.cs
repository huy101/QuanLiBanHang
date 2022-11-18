namespace WindowsFormsApp9
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLiTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thưcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChuToolStripMenuItem,
            this.quanLiToolStripMenuItem,
            this.thưcĐơnToolStripMenuItem,
            this.thanhToanToolStripMenuItem,
            this.thôngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChuToolStripMenuItem
            // 
            this.trangChuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogout});
            this.trangChuToolStripMenuItem.Name = "trangChuToolStripMenuItem";
            this.trangChuToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.trangChuToolStripMenuItem.Text = "Trang chủ";
            // 
            // btnLogout
            // 
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(224, 26);
            this.btnLogout.Text = "Thoát";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // quanLiToolStripMenuItem
            // 
            this.quanLiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhânViênToolStripMenuItem,
            this.quanLiTaiKhoanToolStripMenuItem});
            this.quanLiToolStripMenuItem.Name = "quanLiToolStripMenuItem";
            this.quanLiToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.quanLiToolStripMenuItem.Text = "Quản lí";
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            this.thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            this.thôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.thôngTinNhânViênToolStripMenuItem.Text = "thông tin nhân viên";
            // 
            // quanLiTaiKhoanToolStripMenuItem
            // 
            this.quanLiTaiKhoanToolStripMenuItem.Name = "quanLiTaiKhoanToolStripMenuItem";
            this.quanLiTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.quanLiTaiKhoanToolStripMenuItem.Text = "quản lí tài khoản";
            // 
            // thưcĐơnToolStripMenuItem
            // 
            this.thưcĐơnToolStripMenuItem.Name = "thưcĐơnToolStripMenuItem";
            this.thưcĐơnToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.thưcĐơnToolStripMenuItem.Text = "Thực đơn";
            // 
            // thanhToanToolStripMenuItem
            // 
            this.thanhToanToolStripMenuItem.Name = "thanhToanToolStripMenuItem";
            this.thanhToanToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.thanhToanToolStripMenuItem.Text = "thanh toán";
            // 
            // thôngKêToolStripMenuItem
            // 
            this.thôngKêToolStripMenuItem.Name = "thôngKêToolStripMenuItem";
            this.thôngKêToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.thôngKêToolStripMenuItem.Text = "thống kê";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp9.Properties.Resources.abstract_gradient_wallpaper_desktop_mattbirchler_idownloadblog_purple_1536x864_11;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "trangchu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.ToolStripMenuItem quanLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thưcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLiTaiKhoanToolStripMenuItem;
    }
}