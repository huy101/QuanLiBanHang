﻿using System;
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

        

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        

        private void trangChuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnThucdon(object sender, EventArgs e)
        {

        }

        private void btnThanhtoan(object sender, EventArgs e)
        {

        }

        private void btnTTNV(object sender, EventArgs e)
        {
            this.Hide();
            QLnhanvien ql = new QLnhanvien();
            ql.ShowDialog();
        }

        private void btnThoat(object sender, EventArgs e)
        {
            this.Close();
            var loginForm = new Form1();
            loginForm.ShowDialog();
        }
    }
}
