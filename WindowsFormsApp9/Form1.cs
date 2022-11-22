using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        DataClasses_QLTKDataContext dtTK = new DataClasses_QLTKDataContext();
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtdangnhap.Text) || string.IsNullOrEmpty(txtmatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdangnhap.Select();
                return;
            }
           
            var dn = dtTK.TaiKhoans.SingleOrDefault(x=>x.TenTaiKhoan == txtdangnhap.Text && x.MatKhau == txtmatkhau.Text);
            if(dn != null)
            {
                MessageBox.Show("Đăng nhập thành công", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập ĐÚNG tên đăng nhập và mật khẩu", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
              
            }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

       
    }

    
    
}
