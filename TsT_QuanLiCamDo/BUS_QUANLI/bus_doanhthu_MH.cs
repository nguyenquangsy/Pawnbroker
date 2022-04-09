using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QUANLI;
using DAL_QUANLI;
using System.Data;

namespace BUS_QUANLI
{
    public class bus_doanhthu_MH
    {
        dal_doanhthu_MH dal_dtMH = new dal_doanhthu_MH();

        public DataTable getDoanhThuNgay_MH(dto_datetime ddt, dto_mathang dmh)
        {
            return dal_dtMH.getDoanhThuNgay_MH(ddt,dmh);
        }

        public DataTable getDoanhThuThang_MH(dto_datetime ddt, dto_mathang dmh)
        {
            return dal_dtMH.getDoanhThuThang_MH(ddt, dmh);
        }

        public DataTable getDoanhThuNam_MH(dto_datetime ddt, dto_mathang dmh)
        {
            return dal_dtMH.getDoanhThuNam_MH(ddt, dmh);
        }

        public DataTable getAll_MH(dto_mathang dmh)
        {
            return dal_dtMH.getAll_MH(dmh);
        }

        public DataTable getKhoangTg_MH(DateTime tu, DateTime den, dto_mathang dmh)
        {
            return dal_dtMH.getKhoangTg_MH(tu, den, dmh);
        }
        public string tongngay_MH(dto_datetime ddt, dto_mathang dmh)
        {
            return dal_dtMH.tongngay_MH(ddt, dmh);
        }

        public string tongthang_MH(dto_datetime ddt, dto_mathang dmh)
        {
            return dal_dtMH.tongthang_MH(ddt, dmh);
        }

        public string tongnam_MH(dto_datetime ddt, dto_mathang dmh)
        {
            return dal_dtMH.tongnam_MH(ddt, dmh);
        }

        public string tongall_MH(dto_mathang dmh)
        {
            return dal_dtMH.tongall_MH(dmh);
        }

        public string tongKhoangTg_MH(DateTime tu, DateTime den, dto_mathang dmh)
        {
            return dal_dtMH.tongKhoangTg_MH(tu, den, dmh);
        }

        public bool check_MH(dto_mathang dmh) // Kiểm tra xem mặt hàng đã được đặt hay chưa
        {
            return dal_dtMH.check_MH(dmh);
        }
    }
}
