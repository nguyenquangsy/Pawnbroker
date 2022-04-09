using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QUANLI
{
    public class dto_mathang
    {
        int mamathang;
        string tenmathang;
        int maloai;
        bool tt_mh;

        
        public string Tenmathang { get => tenmathang; set => tenmathang = value; }       
        public int Mamathang { get => mamathang; set => mamathang = value; }
        public int Maloai { get => maloai; set => maloai = value; }
        public bool Tt_mh { get => tt_mh; set => tt_mh = value; }

        public dto_mathang()
        {

        }

        public dto_mathang(int mh_mamathang,string mh_tenmathang,int mh_maloai,bool mh_tt_mh)
        {
            this.Mamathang = mh_mamathang;
            this.Tenmathang = mh_tenmathang;
            this.Maloai = mh_maloai;
            this.Tt_mh = mh_tt_mh;
        }
    }
}
