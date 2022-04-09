using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QUANLI;

namespace DAL_QUANLI
{
    public class dal_khachhang : Connection
    {
        public DataTable getkhachhang()
        {
            string str = "select MAKHACHHANG as [Mã khách hàng],TENKHACHHANG as [Tên khách hàng],SDT as [Số điện thoại],DIACHI as [Địa chỉ],CMND from KHACHHANG where TT_KH = 0";
            SqlDataAdapter da = new SqlDataAdapter(str,connectionString);
            DataTable Table = new DataTable();
            da.Fill(Table);
            return Table;
        }

        // add when avai and not avai
        public bool check_kh(dto_khachhang dkh) // kiểm tra xem khách hàng đã tồn tại chưa
        {
            connectionString.Open();
            string sql = "select * from KHACHHANG where CMND = @cmnd";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);

            SqlDataReader DTA = command.ExecuteReader();
            if(DTA.Read())
            {
                DTA.Close();
                connectionString.Close();
                return true;
            }
            DTA.Close();
            connectionString.Close();
            return false;
        }

        public void them(dto_khachhang dkh)
        {
            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "insert into KHACHHANG values(@tenkhachhang, @sdt, @diachi, @cmnd, @tt_kh)";
            command.Parameters.AddWithValue("@tenkhachhang",dkh.Tenkhachhang);
            command.Parameters.AddWithValue("@sdt",dkh.Sdt);
            command.Parameters.AddWithValue("@diachi",dkh.Diachi);
            command.Parameters.AddWithValue("@cmnd",dkh.Cmnd);
            command.Parameters.AddWithValue("@tt_kh",dkh.Tt_kh);

            command.ExecuteNonQuery();
            connectionString.Close();
        }

        public void them_avai(dto_khachhang dkh)
        {
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "update KHACHHANG set TENKHACHHANG = @tenkhachhang, SDT = @sdt, DIACHI = @diachi, TT_KH = 0 where CMND = @cmnd";
            command.Parameters.AddWithValue("@tenkhachhang", dkh.Tenkhachhang);
            command.Parameters.AddWithValue("@sdt", dkh.Sdt);
            command.Parameters.AddWithValue("@diachi", dkh.Diachi);
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.Parameters.AddWithValue("@tt_kh", dkh.Tt_kh);
            command.ExecuteNonQuery();
            connectionString.Close();
        }
        //---------------------------

        public void xoa(dto_khachhang dkh)
        {
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            /*command.CommandText = "delete from PHIEUCAMDO where MAKHACHHANG = N'" + dkh.Makhachhang+ "'";
            command.ExecuteNonQuery();
            command = connectionString.CreateCommand();*/
            command.CommandText = "update KHACHHANG SET TT_KH = 1 where MAKHACHHANG = @makhachhang";
            command.Parameters.AddWithValue("@makhachhang", dkh.Makhachhang);
            command.ExecuteNonQuery();
            connectionString.Close();
        }

        public int sua(dto_khachhang dkh)
        {
            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "update KHACHHANG set TENKHACHHANG = @tenkhachhang , SDT = @sdt , DIACHI = @diachi , CMND = @cmnd where MAKHACHHANG = @makhachhang";
            command.Parameters.AddWithValue("@makhachhang", dkh.Makhachhang);
            command.Parameters.AddWithValue("@tenkhachhang", dkh.Tenkhachhang);
            command.Parameters.AddWithValue("@sdt", dkh.Sdt);
            command.Parameters.AddWithValue("@diachi", dkh.Diachi);
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.Parameters.AddWithValue("@tt_kh", dkh.Tt_kh);
            command.ExecuteNonQuery();
            connectionString.Close();
            return 0;
        }

        // Tìm kiếm khách hàng có phiếu và đang cầm 
        public DataTable getdanhsachtimkiem()
        {
            DataTable Table = new DataTable();
            connectionString.Open();
            string str = "SELECT A.MAKHACHHANG AS [Mã khách hàng],A.TENKHACHHANG as [Tên khách hàng],A.SDT as [Số điện thoại],A.DIACHI as [Địa chỉ],A.CMND,B.[Số phiếu cầm đồ] FROM KHACHHANG A,(select MAKHACHHANG ,COUNT(MAKHACHHANG) AS [Số phiếu cầm đồ] from PHIEUCAMDO group by MAKHACHHANG) B WHERE A.MAKHACHHANG = B.MAKHACHHANG and a.TT_KH = 0";
            SqlCommand command = new SqlCommand(str, connectionString);
            command.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(command); //chuyen du lieu ve            
            Table.Clear();
            da.Fill(Table);
            // đổ dữ liệu vào kho
            connectionString.Close();  // đóng kết nối   
            return Table;
        }

        public DataTable gettimkiem(dto_khachhang dkh)
        {
            DataTable Table = new DataTable();
            connectionString.Open();
            string str = "SELECT A.MAKHACHHANG AS [Mã khách hàng],A.TENKHACHHANG as [Tên khách hàng],A.SDT as [Số điện thoại],A.DIACHI as [Địa chỉ],A.CMND,B.[Số phiếu cầm đồ] FROM KHACHHANG A,(select MAKHACHHANG ,COUNT(MAKHACHHANG) AS [Số phiếu cầm đồ] from PHIEUCAMDO group by MAKHACHHANG) B WHERE A.MAKHACHHANG = B.MAKHACHHANG and A.CMND = @cmnd and a.TT_KH = 0";
            SqlCommand command = new SqlCommand(str, connectionString);
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(command); //chuyen du lieu ve            
            Table.Clear();
            da.Fill(Table);
            // đổ dữ liệu vào kho
            connectionString.Close();  // đóng kết nối   
            return Table;
        }
        //------------------------------------------------

        public DataTable getTimKiem_KH(dto_khachhang dkh) // Tìm kiếm thông tin khách hàng
        {
            string str = "select MAKHACHHANG as [Mã khách hàng],TENKHACHHANG as [Tên khách hàng],SDT as [Số điện thoại],DIACHI as [Địa chỉ],CMND from KHACHHANG where CMND = @cmnd and TT_KH = 0";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable Table = new DataTable();
            da.Fill(Table);

            return Table;
        }

        public DataTable getdanhsachkhachhangvipham()
        {
            DataTable Table = new DataTable();
            DateTime now = DateTime.Now;
            connectionString.Open();
            string str = "select a.MAKHACHHANG,a.TENKHACHHANG,a.SDT from KHACHHANG a,PHIEUCAMDO b where a.MAKHACHHANG = b.MAKHACHHANG and '" + now + "' - b.NGAYHENTRA > 0 AND b.TRANGTHAI = 0 and a.TT_KH = 0";
            SqlCommand command = new SqlCommand(str, connectionString);
            command.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(command); //chuyen du lieu ve            
            Table.Clear();
            da.Fill(Table);
            // đổ dữ liệu vào kho
            connectionString.Close();  // đóng kết nối 
            return Table;
        }

        public DataTable getTimKiem_KHVP(dto_khachhang dkh)
        {
            DataTable Table = new DataTable();
            DateTime now = DateTime.Now;

            connectionString.Open();

            string str = "select a.MAKHACHHANG,a.TENKHACHHANG,a.SDT from KHACHHANG a,PHIEUCAMDO b where a.MAKHACHHANG = b.MAKHACHHANG and '" + now + "' - b.NGAYHENTRA > 0 AND b.TRANGTHAI = 0 and a.CMND = @cmnd and a.TT_KH = 0";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(command); //chuyen du lieu ve            
            Table.Clear();
            da.Fill(Table);

            // đổ dữ liệu vào kho
            connectionString.Close();  // đóng kết nối 
            return Table;
        }
    }
}