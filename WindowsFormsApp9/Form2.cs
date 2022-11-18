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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            var loginForm = new Form1();
            loginForm.ShowDialog();

        }

        private void quanLiTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLiTaiKhoan quanLiTaiKhoan=new QuanLiTaiKhoan();
               quanLiTaiKhoan.ShowDialog();
        }
    }
}
