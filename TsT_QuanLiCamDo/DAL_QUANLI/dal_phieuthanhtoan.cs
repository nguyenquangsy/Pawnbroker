using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_QUANLI;
using System.Data;
using System.Windows.Forms;

namespace DAL_QUANLI
{
    public class dal_phieuthanhtoan :Connection
    {
        public void updatethanhtoan(dto_phieuthanhtoan dptt,string tienlai,string tong)
        {
            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "update PHIEUCAMDO set TRANGTHAI = 1 where MAPHIEU = @maphieu";
            command.Parameters.AddWithValue("@maphieu", dptt.Maphieu);
            command.ExecuteNonQuery();

            command = connectionString.CreateCommand();
            command.CommandText = "insert into PHIEUTHANHTOAN values (@ngaylapphieu, @maphieu,@tienlai, @tong, @tt_ptt)";
            command.Parameters.AddWithValue("@maphieu", dptt.Maphieu);
            command.Parameters.AddWithValue("@ngaylapphieu", dptt.Ngaylapphieu);
            command.Parameters.AddWithValue("@tong", tong);
            command.Parameters.AddWithValue("@tienlai", tienlai);
            command.Parameters.AddWithValue("@tt_ptt", dptt.Tt_ptt);    
            command.ExecuteNonQuery();

            connectionString.Close();
        }

        public string tong(string maphieu)
        {
            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            string sql = "select sum(b.TIENCAM * b.SOLUONG) from PHIEUCAMDO a, CTPHIEUCAMDO b where a.MAPHIEU = b.MAPHIEU and a.MAPHIEU = @maphieu group by a.MAPHIEU";
            command.CommandText = sql;
            command.Parameters.AddWithValue("@maphieu", maphieu);
            command.ExecuteNonQuery();
            SqlDataAdapter DA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            DA.Fill(table);

            connectionString.Close();

            string temp = table.Rows[0][0].ToString();
            return temp;
        }

        public string tienlai(dto_phieuthanhtoan dptt)
        {
            connectionString.Open();

            SqlCommand command = connectionString.CreateCommand();
            string sql = "select sum(b.TIENCAM * b.SOLUONG * a.TIENTRA * DATEDIFF(Day, NGAYLAP,NGAYHENTRA)) from PHIEUCAMDO a, CTPHIEUCAMDO b where a.MAPHIEU = b.MAPHIEU and a.MAPHIEU = @maphieu group by a.MAPHIEU";
            command.CommandText = sql;
            command.Parameters.AddWithValue("@maphieu", dptt.Maphieu);
            command.ExecuteNonQuery();
            SqlDataAdapter DA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            DA.Fill(table);

            connectionString.Close();

            string temp = table.Rows[0][0].ToString();
            return temp;
        }

        public bool checkct_phieucamdo(dto_phieuthanhtoan dptt)  // kiểm tra xem phiếu đã có sản phẩm chưa
        {
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "select * from CTPHIEUCAMDO where MAPHIEU = @maphieu";
            command.Parameters.AddWithValue("@maphieu", dptt.Maphieu);
            command.ExecuteNonQuery();
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

        public string check_MaPhieuThanhToan(dto_phieuthanhtoan dptt)  //Truy lại mã thanh toán để hiện trong phiếu thanh toán
        {
            connectionString.Open();

            string sql = "select MAPHIEUTHANHTOAN from PHIEUTHANHTOAN where MAPHIEU = @maphieu";

            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@maphieu", dptt.Maphieu);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);

            string temp = table.Rows[0][0].ToString();
            return temp;
        }

        public DataTable get_PhieuThanhToan(string maphieuthanhtoan)
        {
            string sql = "select d.TENMATHANG,c.SOLUONG,c.TIENCAM " +
                "from PHIEUTHANHTOAN a,CTPHIEUCAMDO c, MATHANG d " +
                "where a.MAPHIEU = c.MAPHIEU and c.MAMATHANG = d.MAMATHANG and a.MAPHIEUTHANHTOAN = '"+maphieuthanhtoan+"'";

            connectionString.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            DataTable table = new DataTable();
            da.Fill(table);
            connectionString.Close();
            return table;
        }  //Đưa cho chi tiết phiếu cầm đồ có những sản phẩm nào hiện trên phiếu thanh toán

        public DataTable get_ttkhachhang(string maphieu)
        {
            string sql = "select c.TENKHACHHANG,c.SDT,c.CMND,c.DIACHI " +
                "from PHIEUCAMDO a, PHIEUCAMDO b,KHACHHANG c " +
                "where a.MAPHIEU = b.MAPHIEU and b.MAKHACHHANG = c.MAKHACHHANG and a.MAPHIEU = '"+maphieu+"'";

            connectionString.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            DataTable table = new DataTable();
            da.Fill(table);
            connectionString.Close();
            return table;
        } //Đưa ra thông tin khách hàng để hiện trên 2 phiếu

        public DataTable get_Phieuhen(string maphieu)
        {
            string sql = "select d.TENMATHANG,c.SOLUONG,c.TIENCAM " +
                "from PHIEUCAMDO a,CTPHIEUCAMDO c, MATHANG d " +
                "where a.MAPHIEU = c.MAPHIEU and c.MAMATHANG = d.MAMATHANG and a.MAPHIEU = '" + maphieu+ "'";

            connectionString.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            DataTable table = new DataTable();
            da.Fill(table);
            connectionString.Close();
            return table;
        } // Đưa cho chi tiết cầm đồ có những sản phầm nào để hiện trên phiếu hợp đồng cầm đồ
    }
}
