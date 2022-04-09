using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QUANLI;

namespace DAL_QUANLI
{
    public class dal_doanhthu_KH : Connection
    {
        public DataTable getDoanhThuNgay_KH(dto_datetime ddt,dto_khachhang dkh)
        {
            string a = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],A.MAPHIEU as [Mã Phiếu],TONGTIEN as [Tổng Tiền] ,C.TENKHACHHANG AS [Tên Khách Hàng]";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,KHACHHANG C";
            string c = " WHERE A.MAPHIEU = b.MAPHIEU AND B.MAKHACHHANG = C.MAKHACHHANG AND C.CMND = @cmnd and DAY(NGAYLAPPHIEUTHANHTOAN) = @ngay and MONTH(NGAYLAPPHIEUTHANHTOAN) = @thang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            connectionString.Open();
            string str = a + b + c;

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.Parameters.AddWithValue("@ngay", ddt.Ngay);
            command.Parameters.AddWithValue("@thang", ddt.Thang);
            command.Parameters.AddWithValue("@nam", ddt.Nam);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();

            return Table;
        }

        public DataTable getDoanhThuThang_KH(dto_datetime ddt, dto_khachhang dkh)
        {
            string a = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],A.MAPHIEU as [Mã Phiếu],TONGTIEN as [Tổng Tiền] ,C.TENKHACHHANG AS [Tên Khách Hàng]";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,KHACHHANG C";
            string c = " WHERE A.MAPHIEU = b.MAPHIEU AND B.MAKHACHHANG = C.MAKHACHHANG AND C.CMND = @cmnd and MONTH(NGAYLAPPHIEUTHANHTOAN) = @thang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            connectionString.Open();
            string str = a + b + c;

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.Parameters.AddWithValue("@thang", ddt.Thang);
            command.Parameters.AddWithValue("@nam", ddt.Nam);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();

            return Table;
        }

        public DataTable getDoanhThuNam_KH(dto_datetime ddt, dto_khachhang dkh)
        {
            string a = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],A.MAPHIEU as [Mã Phiếu],TONGTIEN as [Tổng Tiền] ,C.TENKHACHHANG AS [Tên Khách Hàng]";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,KHACHHANG C";
            string c = " WHERE A.MAPHIEU = b.MAPHIEU AND B.MAKHACHHANG = C.MAKHACHHANG AND C.CMND = @cmnd and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            connectionString.Open();
            string str = a + b + c;

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.Parameters.AddWithValue("@nam", ddt.Nam);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();

            return Table;
        }

        public DataTable getAll_KH(dto_khachhang dkh)
        {
            string a = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],A.MAPHIEU as [Mã Phiếu],TONGTIEN as [Tổng Tiền] ,C.TENKHACHHANG AS [Tên Khách Hàng]";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,KHACHHANG C";
            string c = " WHERE A.MAPHIEU = b.MAPHIEU AND B.MAKHACHHANG = C.MAKHACHHANG AND C.CMND = @cmnd";

            connectionString.Open();
            string str = a + b + c;

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();

            return Table;
        }

        public DataTable getKhoangTg_KH(DateTime tu, DateTime den, dto_khachhang dkh)
        {
            string a = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],A.MAPHIEU as [Mã Phiếu],TONGTIEN as [Tổng Tiền] ,C.TENKHACHHANG AS [Tên Khách Hàng]";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,KHACHHANG C";
            string c = " WHERE A.MAPHIEU = b.MAPHIEU AND B.MAKHACHHANG = C.MAKHACHHANG AND C.CMND = @cmnd and NGAYLAPPHIEUTHANHTOAN >= @tu and NGAYLAPPHIEUTHANHTOAN <= @den";

            connectionString.Open();
            string str = a + b + c;

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.Parameters.AddWithValue("@tu", tu);
            command.Parameters.AddWithValue("@den", den);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();

            return Table;
        }

        public string tongngay_KH(dto_datetime ddt, dto_khachhang dkh)
        {
            string a = "select sum(TONGTIEN) ";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,KHACHHANG C";
            string c = " where A.MAPHIEU = b.MAPHIEU AND B.MAKHACHHANG = C.MAKHACHHANG AND C.CMND = @cmnd and DAY(NGAYLAPPHIEUTHANHTOAN) = @ngay and MONTH(NGAYLAPPHIEUTHANHTOAN) = @thang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            connectionString.Open();
            string str = a + b + c;

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.Parameters.AddWithValue("@ngay", ddt.Ngay);
            command.Parameters.AddWithValue("@thang", ddt.Thang);
            command.Parameters.AddWithValue("@nam", ddt.Nam);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();

            string temp = Table.Rows[0][0].ToString();
            return temp;
        }

        public string tongthang_KH(dto_datetime ddt, dto_khachhang dkh)
        {
            string a = "select sum(TONGTIEN) ";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,KHACHHANG C";
            string c = " where A.MAPHIEU = b.MAPHIEU AND B.MAKHACHHANG = C.MAKHACHHANG AND C.CMND = @cmnd and MONTH(NGAYLAPPHIEUTHANHTOAN) = @thang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            connectionString.Open();
            string str = a + b + c;

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.Parameters.AddWithValue("@thang", ddt.Thang);
            command.Parameters.AddWithValue("@nam", ddt.Nam);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();

            string temp = Table.Rows[0][0].ToString();
            return temp;
        }

        public string tongnam_KH(dto_datetime ddt, dto_khachhang dkh)
        {
            string a = "select sum(TONGTIEN) ";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,KHACHHANG C";
            string c = " where A.MAPHIEU = b.MAPHIEU AND B.MAKHACHHANG = C.MAKHACHHANG AND C.CMND = @cmnd and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            connectionString.Open();
            string str = a + b + c;

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.Parameters.AddWithValue("@nam", ddt.Nam);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();

            string temp = Table.Rows[0][0].ToString();
            return temp;
        }

        public string tongall_KH(dto_khachhang dkh)
        {
            string a = "select sum(TONGTIEN) ";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,KHACHHANG C";
            string c = " where A.MAPHIEU = b.MAPHIEU AND B.MAKHACHHANG = C.MAKHACHHANG AND C.CMND = @cmnd";

            connectionString.Open();
            string str = a + b + c;

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();

            string temp = Table.Rows[0][0].ToString();
            return temp;
        }

        public string tongKhoangTg_KH(DateTime tu, DateTime den, dto_khachhang dkh)
        {
            string a = "select sum(TONGTIEN) ";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,KHACHHANG C";
            string c = " where A.MAPHIEU = b.MAPHIEU AND B.MAKHACHHANG = C.MAKHACHHANG AND C.CMND = @cmnd and NGAYLAPPHIEUTHANHTOAN >= @tu and NGAYLAPPHIEUTHANHTOAN <= @den";

            connectionString.Open();
            string str = a + b + c;

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.Parameters.AddWithValue("@tu", tu);
            command.Parameters.AddWithValue("@den", den);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();

            string temp = Table.Rows[0][0].ToString();
            return temp;
        }
    }
}
