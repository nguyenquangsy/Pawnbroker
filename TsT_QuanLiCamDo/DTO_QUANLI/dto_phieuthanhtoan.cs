using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QUANLI
{
    public class dto_phieuthanhtoan
    {
        int maphieuthanhtoan;
        DateTime ngaylapphieu;        
        int maphieu;
        string tienlai;
        string tongtien;
        bool tt_ptt;

        public dto_phieuthanhtoan()
        {

        }

        public dto_phieuthanhtoan(int ptt_maphieuthanhtoan,DateTime ptt_ngaylap,int ptt_maphieu,string ptt_tienlai,string ptt_tongtien,bool ptt_tt_ptt)
        {
            this.Maphieuthanhtoan = ptt_maphieuthanhtoan;
            this.Ngaylapphieu = ptt_ngaylap;
            this.Maphieu = ptt_maphieu;
            this.Tienlai = ptt_tienlai;
            this.Tongtien = ptt_tongtien;
            this.Tt_ptt = ptt_tt_ptt;
        }

        public int Maphieuthanhtoan { get => maphieuthanhtoan; set => maphieuthanhtoan = value; }
        public DateTime Ngaylapphieu { get => ngaylapphieu; set => ngaylapphieu = value; }
        public int Maphieu { get => maphieu; set => maphieu = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
        public bool Tt_ptt { get => tt_ptt; set => tt_ptt = value; }
        public string Tienlai { get => tienlai; set => tienlai = value; }
    }
}
