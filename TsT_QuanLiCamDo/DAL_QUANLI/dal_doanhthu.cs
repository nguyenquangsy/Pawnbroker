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
    public class dal_doanhthu:Connection
    {
        public DataTable getDoanhThuNgay(dto_datetime ddt)
        {
            connectionString.Open();

            string str = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],MAPHIEU as [Mã Phiếu],TONGTIEN as [Tổng Tiền] " +
                "from PHIEUTHANHTOAN " +
                "where DAY(NGAYLAPPHIEUTHANHTOAN) = @ngay and MONTH(NGAYLAPPHIEUTHANHTOAN) = @thang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@ngay", ddt.Ngay);
            command.Parameters.AddWithValue("@thang", ddt.Thang);
            command.Parameters.AddWithValue("@nam", ddt.Nam);
            command.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();
            return Table;
        }

        public DataTable getDoanhThuThang(dto_datetime ddt)
        {
            connectionString.Open();

            string str = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],MAPHIEU as [Mã Phiếu],TONGTIEN as [Tổng Tiền] " +
                "from PHIEUTHANHTOAN " +
                "where MONTH(NGAYLAPPHIEUTHANHTOAN) = @thang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@thang", ddt.Thang);
            command.Parameters.AddWithValue("@nam", ddt.Nam);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();
            return Table;
        }

        public DataTable getDoanhThuNam(dto_datetime ddt)
        {
            connectionString.Open();

            string str = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],MAPHIEU as [Mã Phiếu],TONGTIEN as [Tổng Tiền] " +
                "from PHIEUTHANHTOAN " +
                "where YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@nam", ddt.Nam);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();
            return Table;
        }

        public DataTable getAll()
        {
            connectionString.Open();

            string str = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],MAPHIEU as [Mã Phiếu],TONGTIEN as [Tổng Tiền] " +
                "from PHIEUTHANHTOAN ";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();
            return Table;
        }

        public DataTable getKhoangTg(DateTime tu,DateTime den)
        {
            connectionString.Open();

            string str = "select MAPHIEUTHANHTOAN as [Mã Phiếu Thanh Toán],NGAYLAPPHIEUTHANHTOAN as [Ngày Lập],MAPHIEU as [Mã Phiếu],TONGTIEN as [Tổng Tiền] " +
                "from PHIEUTHANHTOAN " +
                "where NGAYLAPPHIEUTHANHTOAN >= @tu and NGAYLAPPHIEUTHANHTOAN <= @den";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@tu", tu);
            command.Parameters.AddWithValue("@den", den);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();
            return Table;
        }

        public string tongngay(dto_datetime ddt)
        {
            connectionString.Open();
            string str = "select sum(TONGTIEN) " +
                "from PHIEUTHANHTOAN " +
                "where DAY(NGAYLAPPHIEUTHANHTOAN) = @ngay and MONTH(NGAYLAPPHIEUTHANHTOAN) = @thang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
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

        public string tongthang(dto_datetime ddt)
        {
            connectionString.Open();
            string str = "select sum(TONGTIEN) " +
                "from PHIEUTHANHTOAN " +
                "where MONTH(NGAYLAPPHIEUTHANHTOAN) = @thang and YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@thang", ddt.Thang);
            command.Parameters.AddWithValue("@nam", ddt.Nam);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();

            string temp = Table.Rows[0][0].ToString();
            return temp;
        }

        public string tongnam(dto_datetime ddt)
        {
            connectionString.Open();
            string str = "select sum(TONGTIEN) " +
                "from PHIEUTHANHTOAN " +
                "where YEAR(NGAYLAPPHIEUTHANHTOAN) = @nam";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@nam", ddt.Nam);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();

            string temp = Table.Rows[0][0].ToString();
            return temp;
        }

        public string tongall()
        {
            connectionString.Open();
            string str = "select sum(TONGTIEN) " +
                "from PHIEUTHANHTOAN ";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            connectionString.Close();

            string temp = Table.Rows[0][0].ToString();
            return temp;
        }

        public string tongKhoangTg(DateTime tu,DateTime den)
        {
            connectionString.Open();
            string str = "select sum(TONGTIEN) " +
                "from PHIEUTHANHTOAN " +
                "where NGAYLAPPHIEUTHANHTOAN >= @tu and NGAYLAPPHIEUTHANHTOAN <= @den";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
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
