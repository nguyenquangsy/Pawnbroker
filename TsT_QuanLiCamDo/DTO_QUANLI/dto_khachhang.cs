using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QUANLI
{
    public class dto_khachhang
    {
        int makhachhang;
        string tenkhachhang;
        string sdt;
        string diachi;
        string cmnd;
        bool tt_kh;

        
        public string Tenkhachhang { get => tenkhachhang; set => tenkhachhang = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public int Makhachhang { get => makhachhang; set => makhachhang = value; }
        public bool Tt_kh { get => tt_kh; set => tt_kh = value; }

        public dto_khachhang()
        {

        }

        public dto_khachhang(int kh_makhachhang,string kh_tenkhachhang,string kh_sdt,string kh_diachi,string kh_cmnd,bool kh_tt_kh)
        {
            this.Makhachhang = kh_makhachhang;
            this.Tenkhachhang = kh_tenkhachhang;
            this.Sdt = kh_sdt;
            this.Diachi = kh_diachi;
            this.Cmnd = kh_cmnd;
            this.Tt_kh = kh_tt_kh;
        }
    }
}
