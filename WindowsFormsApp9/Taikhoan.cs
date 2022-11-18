using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    internal class Taikhoan
    {
        private string tentaikhoan;
        private string matkhau;
        public int VaiTro { get; set; }
        public Taikhoan()
        {
        }

        public Taikhoan(string tentaikhoan, string matkhau, int vaitro)
        {
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.VaiTro= vaitro;
        }

        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
