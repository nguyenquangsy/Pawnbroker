using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QUANLI
{
    public class dto_loaimathang
    {
        int maloai;
        string tenloai;

        
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public int Maloai { get => maloai; set => maloai = value; }

        public dto_loaimathang()
        {

        }   
        
        public dto_loaimathang(int lmh_maloai,string lmh_tenloai)
        {
            this.Maloai = lmh_maloai;
            this.Tenloai = lmh_tenloai;
        }
    }
}
