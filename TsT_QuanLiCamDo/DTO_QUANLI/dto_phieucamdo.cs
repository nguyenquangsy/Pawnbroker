using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QUANLI
{
    public class dto_phieucamdo
    {
        int maphieu;
        string ngaylap;
        string ngaytra;
        float tienlai;
        bool trangthai;
        int makhachhang;
        string tentaikhoan;
        bool tt_pcd;

        public dto_phieucamdo()
        {

        }   
        
        public dto_phieucamdo(int pcd_maphieu,string pcd_ngaylap,string pcd_ngaytra,float pcd_tienlai,bool pcd_trangthai,int pcd_makhachhang,string pcd_tentaikhoan,bool pcd_tt_pcd)
        {
            this.Maphieu = pcd_maphieu;
            this.Ngaylap = pcd_ngaylap;
            this.Ngaytra = pcd_ngaytra;
            this.Tienlai = pcd_tienlai;
            this.Trangthai = pcd_trangthai;
            this.Makhachhang = pcd_makhachhang;
            this.Tentaikhoan = pcd_tentaikhoan;
            this.Tt_pcd = pcd_tt_pcd;
        }

        public int Maphieu { get => maphieu; set => maphieu = value; }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Ngaytra { get => ngaytra; set => ngaytra = value; }
        public float Tienlai { get => tienlai; set => tienlai = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
        public int Makhachhang { get => makhachhang; set => makhachhang = value; }
        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public bool Tt_pcd { get => tt_pcd; set => tt_pcd = value; }
    }
}
