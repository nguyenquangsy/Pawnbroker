using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QUANLI;
using DAL_QUANLI;
using System.Data;
using System.Windows.Forms;

namespace BUS_QUANLI
{
    public class bus_doanhthu_KH
    {
        dal_doanhthu_KH dal_dtKH = new dal_doanhthu_KH();

        public DataTable getDoanhThuNgay_KH(dto_datetime ddt, dto_khachhang dkh)
        {
            return dal_dtKH.getDoanhThuNgay_KH(ddt,dkh);
        }

        public DataTable getDoanhThuThang_KH(dto_datetime ddt, dto_khachhang dkh)
        {
            return dal_dtKH.getDoanhThuThang_KH(ddt,dkh);
        }

        public DataTable getDoanhThuNam_KH(dto_datetime ddt, dto_khachhang dkh)
        {
            return dal_dtKH.getDoanhThuNam_KH(ddt,dkh);
        }

        public DataTable getAll_KH(dto_khachhang dkh)
        {
            return dal_dtKH.getAll_KH(dkh);
        }

        public DataTable getKhoangTg_KH(DateTime tu, DateTime den, dto_khachhang dkh)
        {
            return dal_dtKH.getKhoangTg_KH(tu, den,dkh);
        }
        public string tongngay_KH(dto_datetime ddt, dto_khachhang dkh)
        {
            return dal_dtKH.tongngay_KH(ddt,dkh);
        }

        public string tongthang_KH(dto_datetime ddt, dto_khachhang dkh)
        {
            return dal_dtKH.tongthang_KH(ddt,dkh);
        }

        public string tongnam_KH(dto_datetime ddt, dto_khachhang dkh)
        {
            return dal_dtKH.tongnam_KH(ddt,dkh);
        }

        public string tongall_KH(dto_khachhang dkh)
        {
            return dal_dtKH.tongall_KH(dkh);
        }

        public string tongKhoangTg_KH(DateTime tu, DateTime den, dto_khachhang dkh)
        {
            return dal_dtKH.tongKhoangTg_KH(tu, den,dkh);
        }
    }
}
