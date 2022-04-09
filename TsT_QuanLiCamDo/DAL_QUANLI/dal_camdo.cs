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
    public class dal_camdo : Connection 
    {
        public DataTable getcamdo(dto_taikhoan dtk)
        {
            connectionString.Open();
            string str = "select a.MAPHIEU as [Mã phiếu],a.NGAYLAP as [Ngày lập],a.NGAYHENTRA as [Ngày trả]," +
                "a.TIENTRA as [Lãi suất],b.TENKHACHHANG as [Tên khách hàng],a.TRANGTHAI as [Trạng thái] from PHIEUCAMDO a,KHACHHANG b " +
                "where a.MAKHACHHANG = B.MAKHACHHANG and a.TT_PCD = 0 and b.TT_KH = 0";

            SqlDataAdapter da = new SqlDataAdapter(str, connectionString);
            DataTable Table = new DataTable();
            da.Fill(Table);
            connectionString.Close();
            return Table;
        }

        public void them(dto_phieucamdo dpcd)
        {
            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "insert into PHIEUCAMDO values(@ngaylap,@ngaytra,@tienlai,@trangthai,@makhachhang,@tentaikhoan,@tt_pcd)";
            command.Parameters.AddWithValue("@ngaylap", dpcd.Ngaylap);
            command.Parameters.AddWithValue("@ngaytra", dpcd.Ngaytra);
            command.Parameters.AddWithValue("@tienlai", dpcd.Tienlai);
            command.Parameters.AddWithValue("@trangthai", dpcd.Trangthai);
            command.Parameters.AddWithValue("@makhachhang", dpcd.Makhachhang);
            command.Parameters.AddWithValue("@tentaikhoan", dpcd.Tentaikhoan);
            command.Parameters.AddWithValue("@tt_pcd", dpcd.Tt_pcd);
            command.ExecuteNonQuery();
            connectionString.Close();
        }

        public void xoa(dto_phieucamdo dpcd)
        {           
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            /*command.CommandText = "delete from CTPHIEUCAMDO where MAPHIEU = '" + dpcd.Maphieu + "'";
            if(command.ExecuteNonQuery() < 0)
            {
                return false;
            }    
            command = connectionString.CreateCommand();*/
            command.CommandText = "update PHIEUCAMDO set TT_PCD = 1 where MAPHIEU = @maphieu";
            command.Parameters.AddWithValue("@maphieu", dpcd.Maphieu);
            command.ExecuteNonQuery(); 
            connectionString.Close();
        }

        public int sua(dto_phieucamdo dpcd,dto_khachhang dkh)
        {
           connectionString.Open();

            string sql = "select MAKHACHHANG from KHACHHANG where TENKHACHHANG = @tenkhachhang and TT_KH = 0";
            SqlCommand command = new SqlCommand(sql, connectionString);
            command.Parameters.AddWithValue("@tenkhachhang", dkh.Tenkhachhang);
            SqlDataReader DTA = command.ExecuteReader();

            if (DTA.Read())
            {
                DTA.Close();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable Table1 = new DataTable();
                da.Fill(Table1);

                string temp = Table1.Rows[0].ItemArray[0].ToString(); // Lấy dữ liệu từ DataTable

                command = connectionString.CreateCommand();
                command.CommandText = "update PHIEUCAMDO set NGAYLAP = @ngaylap , NGAYHENTRA = @ngaytra, TIENTRA = @tienlai , MAKHACHHANG = @makhachhang, TRANGTHAI = @trangthai where MAPHIEU = @maphieu";
                command.Parameters.AddWithValue("@ngaylap", dpcd.Ngaylap);
                command.Parameters.AddWithValue("@ngaytra", dpcd.Ngaytra);
                command.Parameters.AddWithValue("@tienlai", dpcd.Tienlai);
                command.Parameters.AddWithValue("@trangthai", dpcd.Trangthai);
                command.Parameters.AddWithValue("@makhachhang", temp);
                command.Parameters.AddWithValue("@maphieu", dpcd.Maphieu);
                if (command.ExecuteNonQuery() > 0)
                {
                    connectionString.Close();
                    return 0;
                }                        
            }
            else
            {
                connectionString.Close();
                return 1;
            }
            connectionString.Close();
            return 2;
        }

        public string truytimkhachhang(dto_khachhang dkh)
        {
            connectionString.Open();
            string sql = "select MAKHACHHANG from KHACHHANG where CMND = @cmnd AND TT_KH = 0";
            SqlCommand command = new SqlCommand(sql, connectionString);
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            SqlDataReader DTA = command.ExecuteReader();

            if (DTA.Read())
            {
                DTA.Close();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable Table = new DataTable();
                Table.Clear();
                da.Fill(Table);

                string temp = Table.Rows[0].ItemArray[0].ToString(); // Lấy dữ liệu từ DataTable
                connectionString.Close();
                return temp;
            }
            connectionString.Close();
            return "";
        }

        public DataTable getphieuquahan()
        {
            //DataTable Table = new DataTable();
            DateTime now = DateTime.Now;
            connectionString.Open();
            string str = "select a.MAPHIEU as [Mã phiếu],a.NGAYLAP as [Ngày lập],a.NGAYHENTRA as [Ngày trả],a.TIENTRA as [Tiền cầm],b.TENKHACHHANG  as [Tên khách hàng],DATEDIFF (Day, a.NGAYHENTRA,'" + now + "') as [Số ngày quá hạn] from PHIEUCAMDO a,KHACHHANG b where a.MAKHACHHANG = B.MAKHACHHANG and '" + now + "' - a.NGAYHENTRA > 0 and TRANGTHAI = 0 and a.TT_PCD = 0";
            SqlCommand command = new SqlCommand(str, connectionString);
            command.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(command); //chuyen du lieu ve            
            DataTable Table = new DataTable();
            da.Fill(Table);
            // đổ dữ liệu vào kho
            connectionString.Close();  // đóng kết nối   
            return Table;
        }

        public DataTable getphieudangcam()
        {
            DataTable Table = new DataTable();

            DateTime now = DateTime.Now;
            connectionString.Open();
            string str = "select a.MAPHIEU as [Mã phiếu],a.NGAYLAP as [Ngày lập],a.NGAYHENTRA as [Ngày trả],a.TIENTRA as [Tiền cầm],b.TENKHACHHANG  as [Tên khách hàng],DATEDIFF (Day,'" + now + "', a.NGAYHENTRA) as [Số ngày gần tới hạn] from PHIEUCAMDO a,KHACHHANG b where a.MAKHACHHANG = B.MAKHACHHANG and '" + now + "' - a.NGAYHENTRA < 0  and TRANGTHAI = 0  and a.TT_PCD = 0";
            SqlCommand command = new SqlCommand(str, connectionString);
            command.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(command); //chuyen du lieu ve            
            //Table.Clear();
            da.Fill(Table);
            // đổ dữ liệu vào kho
            connectionString.Close();  // đóng kết nối 
            return Table;
        }

        public DataTable getphieudatra()
        {
            DataTable Table = new DataTable();
            DateTime now = DateTime.Now;
            connectionString.Open();
            string str = "select a.MAPHIEU as [Mã phiếu],a.NGAYLAP as [Ngày lập],a.NGAYHENTRA as [Ngày trả],a.TIENTRA as [Tiền cầm],b.TENKHACHHANG  as [Tên khách hàng] from PHIEUCAMDO a,KHACHHANG b where a.MAKHACHHANG = B.MAKHACHHANG and TRANGTHAI = 1  and a.TT_PCD = 0";
            SqlCommand command = new SqlCommand(str, connectionString);
            command.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(command); //chuyen du lieu ve            
            //Table.Clear();
            da.Fill(Table);
            // đổ dữ liệu vào kho
            connectionString.Close();  // đóng kết nối   
            return Table;
        }

        public DataTable getTimKiemPhieu(dto_khachhang dkh)
        {
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "select a.MAPHIEU as [Mã phiếu],a.NGAYLAP as [Ngày lập],a.NGAYHENTRA as [Ngày trả],a.TIENTRA as [Tiền lãi],b.TENKHACHHANG as [Tên khách hàng],a.TRANGTHAI as [Trạng thái] from PHIEUCAMDO a,KHACHHANG b where a.MAKHACHHANG = B.MAKHACHHANG and a.TT_PCD = 0 and b.TT_KH = 0 and b.CMND = @cmnd";
            command.Parameters.AddWithValue("@cmnd", dkh.Cmnd);
            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);
            connectionString.Close();
            return table;
        }
    }
}
