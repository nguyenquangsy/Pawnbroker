using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QUANLI
{
    public class dto_ct_phieucamdo
    {
        int mamathang;
        int maphieu;
        int soluong;
        string tiencam;
        bool tt_ctpcd;

        public int Soluong { get => soluong; set => soluong = value; }
        public string Tiencam { get => tiencam; set => tiencam = value; }
        public int Mamathang { get => mamathang; set => mamathang = value; }
        public int Maphieu { get => maphieu; set => maphieu = value; }
        public bool Tt_ctpcd { get => tt_ctpcd; set => tt_ctpcd = value; }

        public dto_ct_phieucamdo()
        {

        }

        public dto_ct_phieucamdo(int ctpcd_mamathang,int ctpcd_maphieu,int ctpcd_soluong,string ctpcd_tiencam,bool ctpcd_tt_ctpcd)
        {
            this.Mamathang = ctpcd_mamathang;
            this.Maphieu = ctpcd_maphieu;
            this.Soluong = ctpcd_soluong;
            this.Tiencam = ctpcd_tiencam;
            this.Tt_ctpcd = ctpcd_tt_ctpcd;
        }
    }
}
