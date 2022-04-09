using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QUANLI
{
    public class dto_taikhoan
    {
        string tentaikhoan;
        string matkhau;
        string quenmatkhau;
        string hovatenuser;
        string vaitro;

        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Quenmatkhau { get => quenmatkhau; set => quenmatkhau = value; }
        public string Hovatenuser { get => hovatenuser; set => hovatenuser = value; }
        public string Vaitro { get => vaitro; set => vaitro = value; }

        public dto_taikhoan()
        {

        }

        public dto_taikhoan(string tk_tentaikhoan,string tk_matkhau,string tk_quenmatkhau ,string tk_hovatenuser,string tk_vaitro)
        {
            this.Tentaikhoan = tk_tentaikhoan;
            this.Matkhau = tk_matkhau;
            this.Quenmatkhau = tk_quenmatkhau;
            this.Hovatenuser = tk_hovatenuser;
            this.Vaitro = tk_vaitro;
        }
    }
}
