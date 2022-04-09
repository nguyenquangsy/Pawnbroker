using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_QUANLI;
using System.Data;

namespace DAL_QUANLI
{
    public class dal_ct_phieucamdo : Connection
    {
        public DataTable getctphieucamdo(dto_ct_phieucamdo dctpcd)
        {
            connectionString.Open();
            string str = "select a.TENKHACHHANG as[Tên khách hàng],b.TENMATHANG as [Tên mặt hàng],d.SOLUONG as [Số lượng],d.TIENCAM as [Tiền cầm] from KHACHHANG a,MATHANG b, PHIEUCAMDO c ,CTPHIEUCAMDO d where a.MAKHACHHANG = c.MAKHACHHANG and d.MAPHIEU = c.MAPHIEU and d.MAMATHANG = b.MAMATHANG and c.MAPHIEU = @maphieu and TT_CTPCD = 0 and TT_MH = 0";
            SqlCommand command = new SqlCommand(str, connectionString);
            command.Parameters.AddWithValue("@maphieu", dctpcd.Maphieu);
            command.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(command); //chuyen du lieu ve            
            DataTable Table = new DataTable();
            da.Fill(Table);
            // đổ dữ liệu vào kho
            connectionString.Close();  // đóng kết nối  
            return Table;
        }

        public int them(dto_ct_phieucamdo dctpcd,dto_mathang dmh)
        {
            connectionString.Open();

            string sql = "select MAMATHANG from MATHANG where TENMATHANG = @tenmathang";
            SqlCommand command = new SqlCommand(sql, connectionString);
            command.Parameters.AddWithValue("@tenmathang",dmh.Tenmathang);
            SqlDataReader DTA = command.ExecuteReader();
            if (DTA.Read())
            {
                DTA.Close();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable Table1 = new DataTable();
                da.Fill(Table1);

                string temp = Table1.Rows[0].ItemArray[0].ToString(); // Lấy dữ liệu từ DataTable

                sql = "select * from CTPHIEUCAMDO where MAMATHANG = '" + temp + "' and MAPHIEU = @maphieu";
                command = new SqlCommand(sql, connectionString);
                command.Parameters.AddWithValue("@maphieu", dctpcd.Maphieu);
                DTA = command.ExecuteReader();
                if (DTA.Read())
                {
                    DTA.Close();
                    connectionString.Close();
                    return 1;
                }
                DTA.Close();
                command = connectionString.CreateCommand();
                command.CommandText = "insert into CTPHIEUCAMDO values(@temp,@maphieu,@soluong,@tiemcam,@tt_ctpcd)";
                command.Parameters.AddWithValue("@temp", temp);
                command.Parameters.AddWithValue("@maphieu", dctpcd.Maphieu);
                command.Parameters.AddWithValue("@soluong", dctpcd.Soluong);
                command.Parameters.AddWithValue("@tiemcam", dctpcd.Tiencam);
                command.Parameters.AddWithValue("@tt_ctpcd", dctpcd.Tt_ctpcd);
                command.ExecuteNonQuery();
                connectionString.Close();
                return 0;
            }
            else
            {
                connectionString.Close();
                return 2;
            }
        }

        public void xoa(dto_ct_phieucamdo dctpcd,dto_mathang dmh)
        {
            string temp = null;
            connectionString.Open();

            string sql = "select MAMATHANG from MATHANG where TENMATHANG = @tenmathang";
            SqlCommand command = new SqlCommand(sql, connectionString);
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);

            SqlDataReader DTA = command.ExecuteReader();
            if (DTA.Read())
            {
                DTA.Close();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable Table1 = new DataTable();
                da.Fill(Table1);

                temp = Table1.Rows[0].ItemArray[0].ToString(); // Lấy dữ liệu từ DataTable
            }
            else
                return;
            command = connectionString.CreateCommand();
            command.CommandText = "delete from CTPHIEUCAMDO where MAMATHANG = @temp AND MAPHIEU = @maphieu'";
            command.Parameters.AddWithValue("@temp", temp);
            command.Parameters.AddWithValue("@maphieu", dctpcd.Maphieu);
            command.ExecuteNonQuery();
            connectionString.Close();
        }

        public int sua(dto_ct_phieucamdo dctpcd, dto_mathang dmh)
        {
            string temp = null;
            connectionString.Open();

            string sql = "select MAMATHANG from MATHANG where TENMATHANG = @tenmathang";
            SqlCommand command = new SqlCommand(sql, connectionString);
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);

            SqlDataReader DTA = command.ExecuteReader();
            if (DTA.Read())
            {
                DTA.Close();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable Table1 = new DataTable();
                da.Fill(Table1);

                temp = Table1.Rows[0].ItemArray[0].ToString(); // Lấy dữ liệu từ DataTable
            }
            else
            {
                DTA.Close();               
                return 1;
            }

            command = connectionString.CreateCommand();
            command.CommandText = "update CTPHIEUCAMDO set SOLUONG = @soluong,TIENCAM = @tiencam where MAMATHANG = @temp and MAPHIEU = @maphieu'";
            command.Parameters.AddWithValue("@temp", temp);
            command.Parameters.AddWithValue("@maphieu", dctpcd.Maphieu);
            command.Parameters.AddWithValue("@soluong", dctpcd.Soluong);
            command.Parameters.AddWithValue("@tiemcam", dctpcd.Tiencam);
            command.ExecuteNonQuery();
            connectionString.Close();
            return 0;
        }

        public DataTable getmathang() // Hiện ra hết mặt hàng cho người sử dụng dể chọn
        {
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "select TENMATHANG from MATHANG";
            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);
            connectionString.Close();

            return table;
        }
    }
}
