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
    public class bus_doanhthu
    {       
        dal_doanhthu dal_dt = new dal_doanhthu();

        public DataTable getDoanhThuNgay(dto_datetime ddt)
        {
            return dal_dt.getDoanhThuNgay(ddt);
        }

        public DataTable getDoanhThuThang(dto_datetime ddt)
        {
            return dal_dt.getDoanhThuThang(ddt);
        }

        public DataTable getDoanhThuNam(dto_datetime ddt)
        {
            return dal_dt.getDoanhThuNam(ddt);
        }

        public DataTable getAll()
        {
            return dal_dt.getAll();
        }

        public DataTable getKhoangTg(DateTime tu,DateTime den)
        {
            return dal_dt.getKhoangTg(tu, den);
        }

        public string tongngay(dto_datetime ddt)
        {
            return dal_dt.tongngay(ddt);
        }

        public string tongthang(dto_datetime ddt)
        {
            return dal_dt.tongthang(ddt);
        }

        public string tongnam(dto_datetime ddt)
        {
            return dal_dt.tongnam(ddt);
        }

        public string tongall()
        {
            return dal_dt.tongall();
        }

        public string tongKhoangTg(DateTime tu,DateTime den)
        {
            return dal_dt.tongKhoangTg(tu, den);
        }
    }
}
