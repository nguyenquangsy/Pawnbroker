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
    public class dal_doanhthu_MH : Connection
    {
        public DataTable getDoanhThuNgay_MH(dto_datetime ddt,dto_mathang dmh)
        {
            string a = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],A.MAPHIEU as [Mã Phiếu],c.TIENCAM * c.SOLUONG * b.TIENTRA  * DATEDIFF(Day, NGAYLAP,NGAYHENTRA) as [Tổng Tiền] ,d.TENMATHANG as [Tên Mặt Hàng]";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,CTPHIEUCAMDO C,MATHANG D";
            string c = " WHERE a.MAPHIEU = b.MAPHIEU and b.MAPHIEU = c.MAPHIEU AND c.MAMATHANG = d.MAMATHANG and d.TENMATHANG = @tenmathang and DAY(NGAYLAPPHIEUTHANHTOAN) = @ngay and MONTH(NGAYLAPPHIEUTHANHTOAN) = @thang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = a+b+c;
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.Parameters.AddWithValue("@ngay", ddt.Ngay);
            command.Parameters.AddWithValue("@thang", ddt.Thang);
            command.Parameters.AddWithValue("@nam", ddt.Nam);
            command.ExecuteNonQuery();

            return truyxuat_get(command);
        }

        public DataTable getDoanhThuThang_MH(dto_datetime ddt, dto_mathang dmh)
        {
            string a = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],A.MAPHIEU as [Mã Phiếu],c.TIENCAM * c.SOLUONG * b.TIENTRA  * DATEDIFF(Day, NGAYLAP,NGAYHENTRA) as [Tổng Tiền] ,d.TENMATHANG as [Tên Mặt Hàng]";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,CTPHIEUCAMDO C,MATHANG D";
            string c = " WHERE a.MAPHIEU = b.MAPHIEU and b.MAPHIEU = c.MAPHIEU AND c.MAMATHANG = d.MAMATHANG and d.TENMATHANG = @tenmathang and MONTH(NGAYLAPPHIEUTHANHTOAN) = @thang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = a + b + c;
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.Parameters.AddWithValue("@thang", ddt.Thang);
            command.Parameters.AddWithValue("@nam", ddt.Nam);
            command.ExecuteNonQuery();

            return truyxuat_get(command);
        }

        public DataTable getDoanhThuNam_MH(dto_datetime ddt, dto_mathang dmh)
        {
            string a = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],A.MAPHIEU as [Mã Phiếu],c.TIENCAM * c.SOLUONG * b.TIENTRA  * DATEDIFF(Day, NGAYLAP,NGAYHENTRA) as [Tổng Tiền] ,d.TENMATHANG as [Tên Mặt Hàng]";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,CTPHIEUCAMDO C,MATHANG D";
            string c = " WHERE a.MAPHIEU = b.MAPHIEU and b.MAPHIEU = c.MAPHIEU AND c.MAMATHANG = d.MAMATHANG and d.TENMATHANG = @tenmathang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = a + b + c;
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.Parameters.AddWithValue("@nam", ddt.Nam);
            command.ExecuteNonQuery();

            return truyxuat_get(command);
        }

        public DataTable getAll_MH(dto_mathang dmh)
        {
            string a = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],A.MAPHIEU as [Mã Phiếu],c.TIENCAM * c.SOLUONG * b.TIENTRA  * DATEDIFF(Day, NGAYLAP,NGAYHENTRA) as [Tổng Tiền] ,d.TENMATHANG as [Tên Mặt Hàng]";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,CTPHIEUCAMDO C,MATHANG D";
            string c = " WHERE a.MAPHIEU = b.MAPHIEU and b.MAPHIEU = c.MAPHIEU AND c.MAMATHANG = d.MAMATHANG and d.TENMATHANG = @tenmathang";

            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = a + b + c;
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.ExecuteNonQuery();

            return truyxuat_get(command);
        }

        public DataTable getKhoangTg_MH(DateTime tu, DateTime den, dto_mathang dmh)
        {
            string a = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],A.MAPHIEU as [Mã Phiếu],c.TIENCAM * c.SOLUONG * b.TIENTRA  * DATEDIFF(Day, NGAYLAP,NGAYHENTRA) as [Tổng Tiền] ,d.TENMATHANG as [Tên Mặt Hàng]";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,CTPHIEUCAMDO C,MATHANG D";
            string c = " WHERE a.MAPHIEU = b.MAPHIEU and b.MAPHIEU = c.MAPHIEU AND c.MAMATHANG = d.MAMATHANG and d.TENMATHANG = @tenmathang and NGAYLAPPHIEUTHANHTOAN >= @tu and NGAYLAPPHIEUTHANHTOAN <= @den";

            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = a + b + c;
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.Parameters.AddWithValue("@tu", tu);
            command.Parameters.AddWithValue("@den", den);
            command.ExecuteNonQuery();

            return truyxuat_get(command);
        }

        public string tongngay_MH(dto_datetime ddt, dto_mathang dmh)
        {
            string a = "select sum(c.TIENCAM * c.SOLUONG * b.TIENTRA  * DATEDIFF(Day, NGAYLAP,NGAYHENTRA))";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,CTPHIEUCAMDO C,MATHANG D";
            string c = " WHERE a.MAPHIEU = b.MAPHIEU and b.MAPHIEU = c.MAPHIEU AND c.MAMATHANG = d.MAMATHANG and d.TENMATHANG = @tenmathang and DAY(NGAYLAPPHIEUTHANHTOAN) = @ngay and MONTH(NGAYLAPPHIEUTHANHTOAN) = @thang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";
            string d = " group by d.TENMATHANG";

            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = a + b + c+d;
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.Parameters.AddWithValue("@ngay", ddt.Ngay);
            command.Parameters.AddWithValue("@thang", ddt.Thang);
            command.Parameters.AddWithValue("@nam", ddt.Nam);
            command.ExecuteNonQuery();

            return truyxuat_tong(command);
        }

        public string tongthang_MH(dto_datetime ddt, dto_mathang dmh)
        {
            string a = "select sum(c.TIENCAM * c.SOLUONG * b.TIENTRA  * DATEDIFF(Day, NGAYLAP,NGAYHENTRA))";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,CTPHIEUCAMDO C,MATHANG D";
            string c = " WHERE a.MAPHIEU = b.MAPHIEU and b.MAPHIEU = c.MAPHIEU AND c.MAMATHANG = d.MAMATHANG and d.TENMATHANG = @tenmathang and MONTH(NGAYLAPPHIEUTHANHTOAN) = @thang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";
            string d = " group by d.TENMATHANG";

            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = a + b + c + d;
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.Parameters.AddWithValue("@thang", ddt.Thang);
            command.Parameters.AddWithValue("@nam", ddt.Nam);
            command.ExecuteNonQuery();

            return truyxuat_tong(command);
        }

        public string tongnam_MH(dto_datetime ddt, dto_mathang dmh)
        {
            string a = "select sum(c.TIENCAM * c.SOLUONG * b.TIENTRA  * DATEDIFF(Day, NGAYLAP,NGAYHENTRA))";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,CTPHIEUCAMDO C,MATHANG D";
            string c = " WHERE a.MAPHIEU = b.MAPHIEU and b.MAPHIEU = c.MAPHIEU AND c.MAMATHANG = d.MAMATHANG and d.TENMATHANG = @tenmathang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";
            string d = " group by d.TENMATHANG";

            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = a + b + c + d;
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.Parameters.AddWithValue("@nam", ddt.Nam);
            command.ExecuteNonQuery();

            return truyxuat_tong(command);
        }

        public string tongall_MH(dto_mathang dmh)
        {
            string a = "select sum(c.TIENCAM * c.SOLUONG * b.TIENTRA  * DATEDIFF(Day, NGAYLAP,NGAYHENTRA))";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,CTPHIEUCAMDO C,MATHANG D";
            string c = " WHERE a.MAPHIEU = b.MAPHIEU and b.MAPHIEU = c.MAPHIEU AND c.MAMATHANG = d.MAMATHANG and d.TENMATHANG = @tenmathang";
            string d = " group by d.TENMATHANG";

            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = a + b + c + d;
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.ExecuteNonQuery();

            return truyxuat_tong(command);
        }

        public string tongKhoangTg_MH(DateTime tu, DateTime den, dto_mathang dmh)
        {
            string a = "select sum(c.TIENCAM * c.SOLUONG * b.TIENTRA  * DATEDIFF(Day, NGAYLAP,NGAYHENTRA))";
            string b = " from PHIEUTHANHTOAN A,PHIEUCAMDO B,CTPHIEUCAMDO C,MATHANG D";
            string c = " WHERE a.MAPHIEU = b.MAPHIEU and b.MAPHIEU = c.MAPHIEU AND c.MAMATHANG = d.MAMATHANG and d.TENMATHANG = @tenmathang and NGAYLAPPHIEUTHANHTOAN >= @tu and NGAYLAPPHIEUTHANHTOAN <= @den";
            string d = " group by d.TENMATHANG";

            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = a + b + c + d;
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.Parameters.AddWithValue("@tu", tu);
            command.Parameters.AddWithValue("@den", den);
            command.ExecuteNonQuery();

            return truyxuat_tong(command);
        }

        public string truyxuat_tong(SqlCommand command)
        {
            SqlDataAdapter da = new SqlDataAdapter(command);
            SqlDataReader dta = command.ExecuteReader();
            if (!dta.Read())
            {
                dta.Close();
                connectionString.Close();
                return null;
            }
            dta.Close();
            DataTable Table = new DataTable();
            da.Fill(Table);
            da.Fill(Table);
            connectionString.Close();
            string temp = Table.Rows[0][0].ToString();
            return temp;
        }

        public DataTable truyxuat_get(SqlCommand command)
        {
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);
            connectionString.Close();
            return Table;
        }

        public bool check_MH(dto_mathang dmh) // Kiểm tra mặt hàng đã đặt hay chưa
        {
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "select * from CTPHIEUCAMDO A, MATHANG B where A.MAMATHANG = B.MAMATHANG and b.TENMATHANG = @tenmathang";
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.ExecuteNonQuery();
            SqlDataReader dta = command.ExecuteReader();
            if(dta.Read())
            {
                dta.Close();
                connectionString.Close();
                return true;
            }
            dta.Close();
            connectionString.Close();
            return false;
        }
    }
}
