 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QUANLI;
using System.Windows.Forms;

namespace DAL_QUANLI
{
    public class dal_mathang : Connection
    {
        public DataTable getmathang()
        {
            string str = "select b.MAMATHANG as [Mã mặt hàng],b.TENMATHANG as [Tên mặt hàng],a.TENLOAI as [Tên loại] from LOAIMATHANG a,MATHANG b where a.MALOAI = b.MALOAI and  b.TT_MH = 0";
            SqlDataAdapter da = new SqlDataAdapter(str,connectionString);
            DataTable dtmathang = new DataTable();
            da.Fill(dtmathang);
            return dtmathang;
        }

        // Tìm kiếm những mặt hàng đang tồn tại trong kho với số lượng
        public DataTable gettimkiem(dto_mathang dmh)
        {
            DataTable Table = new DataTable();
            connectionString.Open();
            string str = "SELECT A.MALOAI,A.MAMATHANG,A.TENMATHANG,B.[SỐ LƯỢNG] FROM MATHANG A,(select MAMATHANG, sum(SOLUONG) AS[SỐ LƯỢNG] from CTPHIEUCAMDO Group by MAMATHANG) B WHERE A.MAMATHANG = B.MAMATHANG and A.TENMATHANG = @tenmathang and a.TT_MH = 0";
            SqlCommand command = new SqlCommand(str, connectionString);
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(command); //chuyen du lieu ve            
            Table.Clear();
            da.Fill(Table);
            // đổ dữ liệu vào kho
            connectionString.Close();  // đóng kết nối   
            return Table;
        }

        public DataTable getdanhsachtimkiem()
        {
            DataTable Table = new DataTable();
            connectionString.Open();
            string str = "SELECT A.MALOAI,A.MAMATHANG,A.TENMATHANG,B.[SỐ LƯỢNG] FROM MATHANG A,(select MAMATHANG, sum(SOLUONG) AS[SỐ LƯỢNG] from CTPHIEUCAMDO Group by MAMATHANG) B WHERE A.MAMATHANG = B.MAMATHANG and a.TT_MH = 0";
            SqlCommand command = new SqlCommand(str, connectionString);
            command.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(command); //chuyen du lieu ve            
            Table.Clear();
            da.Fill(Table);
            // đổ dữ liệu vào kho
            connectionString.Close();  // đóng kết nối   
            return Table;
        }
        //------------------------------------------------------------

        public DataTable getTimKiem_MH(dto_mathang dmh) // Tìm kiếm thông tin mặt hàng trong sql
        {
            string str = "select b.MAMATHANG as [Mã mặt hàng],b.TENMATHANG as [Tên mặt hàng],a.TENLOAI as [Tên loại] from LOAIMATHANG a,MATHANG b where a.MALOAI = b.MALOAI and TENMATHANG = @tenmathang and  b.TT_MH = 0";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = str;
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(str, connectionString);
            DataTable dtmathang = new DataTable();
            da.Fill(dtmathang);
            return dtmathang;
        }

        public string timkiemmaloai(dto_loaimathang dlmh)
        {
            connectionString.Open();

            string sql = "select MALOAI from LOAIMATHANG where TENLOAI = @tenloai";
            SqlCommand command = new SqlCommand(sql, connectionString);
            command.Parameters.AddWithValue("@tenloai", dlmh.Tenloai);
            SqlDataReader DTA = command.ExecuteReader();

            if (DTA.Read())
            {
                DTA.Close();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable Table = new DataTable();
                da.Fill(Table);

                string temp = Table.Rows[0].ItemArray[0].ToString(); // Lấy dữ liệu từ DataTable
                connectionString.Close();
                return temp;
            }
            connectionString.Close();
            return "";
        }

        public void themloaimathang(dto_loaimathang dlmh)
        {
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "insert into LOAIMATHANG values(@tenloai)";
            command.Parameters.AddWithValue("@tenloai", dlmh.Tenloai);
            command.ExecuteNonQuery();
            connectionString.Close();
        }

        // thêm mặt hàng vào kho
        public bool check_mh(dto_mathang dmh) // kiểm tra mặt hàng đã có tồn tại thông trên sql
        {
            connectionString.Open();
            string str = "select * from MATHANG where TENMATHANG = @tenmathang";
            SqlCommand command = new SqlCommand(str, connectionString);
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
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

        public void them(dto_mathang dmh,string temp) // Thêm mặt hàng khi chưa có trong sql
        {
            connectionString.Open();        
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "insert into MATHANG values(@tenmathang, @temp, @tt_mh)";
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.Parameters.AddWithValue("@temp", temp);
            command.Parameters.AddWithValue("@tt_mh", dmh.Tt_mh);
            command.ExecuteNonQuery();
            connectionString.Close();
        } 

        public void them_avai(dto_mathang dmh) // Thêm mặt hàng khi đã có trong sql
        {
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "update MATHANG set TT_MH = 0 where TENMATHANG = @tenmathang";
            command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
            command.ExecuteNonQuery();
            connectionString.Close();
        }
        //-----------------------------------------------------------

        public void xoa(dto_mathang dmh)
        {
            connectionString.Open();
            /*SqlCommand cmd = connectionString.CreateCommand();
            cmd.CommandText = "delete from CTPHIEUCAMDO where MAMATHANG = '" + dmh.Mamathang + "'";
            cmd.ExecuteNonQuery();*/
            SqlCommand cmd = connectionString.CreateCommand();
            cmd.CommandText = "update MATHANG set TT_MH = 1 where MAMATHANG = @mamathang";
            cmd.Parameters.AddWithValue("@mamathang", dmh.Mamathang);
            cmd.ExecuteNonQuery();
            //Sql command = con.CreateCommand();
            connectionString.Close();
        }

        public bool sua(dto_mathang dmh, dto_loaimathang dlmh)
        {
            connectionString.Open();

            string sql = "select MALOAI from LOAIMATHANG where TENLOAI = @tenloai";
            SqlCommand command = new SqlCommand(sql, connectionString);
            command.Parameters.AddWithValue("@tenloai", dlmh.Tenloai);
            SqlDataReader DTA = command.ExecuteReader();

            if (DTA.Read())
            {
                DTA.Close();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable Table = new DataTable();
                Table.Clear();
                da.Fill(Table);

                string temp = Table.Rows[0].ItemArray[0].ToString(); // Lấy dữ liệu từ DataTable


                command = connectionString.CreateCommand();
                command.CommandText = "update MATHANG set TENMATHANG = @tenmathang , MALOAI = @temp where MAMATHANG = @mamathang";
                command.Parameters.AddWithValue("@tenmathang", dmh.Tenmathang);
                command.Parameters.AddWithValue("@temp", temp);
                command.Parameters.AddWithValue("@mamathang", dmh.Mamathang);
                command.ExecuteNonQuery();
            }
            else
            {
                return false;
            }
            connectionString.Close();
            return true;
        }
    }
}
