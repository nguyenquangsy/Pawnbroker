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
    public class dal_dangnhap_dangky : Connection
    {
        public bool them(dto_taikhoan dtk)
        {
            connectionString.Open();

            string sql = "select * from TAIKHOAN where TEN_TAI_KHOAN = @tentaikhoan";  // lay het du lieu trong bang sinh vien
            SqlCommand cmd = new SqlCommand(sql, connectionString); //bat dau truy van 
            cmd.Parameters.AddWithValue("@tentaikhoan", dtk.Tentaikhoan);

            SqlDataReader DTA = cmd.ExecuteReader();
            if (!DTA.Read())
            {
                DTA.Close();
                if(dtk.Vaitro.Equals("Chủ tiệm"))
                {
                    sql = "select * from TAIKHOAN where VAI_TRO = N'" + dtk.Vaitro + "'";
                    cmd = new SqlCommand(sql, connectionString);

                    DTA = cmd.ExecuteReader();
                    if(DTA.Read())
                    {
                        DTA.Close();
                        connectionString.Close();

                        return false;
                    }
                }
                DTA.Close();

                sql = "insert into TAIKHOAN(TEN_TAI_KHOAN,MAT_KHAU,HO_VA_TEN_USER,VAI_TRO) values(@tentaikhoan,@matkhau,@hoten,@vaitro)";

                cmd = new SqlCommand(sql, connectionString);
                cmd.Parameters.AddWithValue("@tentaikhoan", dtk.Tentaikhoan);
                cmd.Parameters.AddWithValue("@matkhau", dtk.Matkhau);
                cmd.Parameters.AddWithValue("@hoten", dtk.Hovatenuser);
                cmd.Parameters.AddWithValue("@vaitro", dtk.Vaitro);
                cmd.ExecuteNonQuery();

                connectionString.Close();

                return true;
            }
            connectionString.Close();

            return false;
        }

        public bool check(dto_taikhoan dtk)
        {
            connectionString.Open();
            string sql = "select * from TAIKHOAN where TEN_TAI_KHOAN = @tentaikhoan AND MAT_KHAU = @matkhau";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, connectionString); //bat dau truy van 
            com.Parameters.AddWithValue("@tentaikhoan", dtk.Tentaikhoan);
            com.Parameters.AddWithValue("@matkhau", dtk.Matkhau);
            SqlDataReader DTA = com.ExecuteReader();
            if (DTA.Read())
            {
                DTA.Close();
                connectionString.Close();
                return true;
            }
            connectionString.Close();  // đóng kết nối  
            return false;
        }

        public int thaydoimatkhau(dto_taikhoan dtk,string old_pass)
        {
            connectionString.Open();

            string sql = "select * from TAIKHOAN where TEN_TAI_KHOAN = @tentaikhoan and MAT_KHAU = @old_pass";  // lay het du lieu trong bang sinh vien
            SqlCommand command = new SqlCommand(sql, connectionString); //bat dau truy van 
            command.Parameters.AddWithValue("@tentaikhoan", dtk.Tentaikhoan);
            command.Parameters.AddWithValue("@old_pass", old_pass);
            SqlDataReader DTA = command.ExecuteReader();
            if (DTA.Read())
            {
                DTA.Close();
                command = connectionString.CreateCommand();
                command.CommandText = "update TAIKHOAN set MAT_KHAU = @matkhau where TEN_TAI_KHOAN = @tentaikhoan";
                command.Parameters.AddWithValue("@tentaikhoan", dtk.Tentaikhoan);
                command.Parameters.AddWithValue("@matkhau", dtk.Matkhau);
                command.ExecuteNonQuery();
            }
            else
            {
                return 1;
            }
            connectionString.Close();
            return 0;
        }

        public bool checkdangky(dto_taikhoan dtk)
        {
            /*connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "select * from TAIKHOAN where QUEN_MAT_KHAU = '"+ 74156 +"'";
            SqlDataReader DTA = command.ExecuteReader();
            if(DTA.Read())
            {
                DTA.Close();
                connectionString.Close();
                return true;
            }
            DTA.Close();
            connectionString.Close();
            return false;*/

            if(dtk.Quenmatkhau.Equals("74156"))
            {
                return true;
            }
            return false;
        }

        public bool checktaikhoan(dto_taikhoan dtk)
        {
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "select * from TAIKHOAN where TEN_TAI_KHOAN = @tentaikhoan and QUEN_MAT_KHAU = @quenmatkhau'";
            command.Parameters.AddWithValue("@tentaikhoan", dtk.Tentaikhoan);
            command.Parameters.AddWithValue("@quenmatkhau", dtk.Quenmatkhau);
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

        public void update_MatKhau(dto_taikhoan dtk)
        {
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "update TAIKHOAN set MAT_KHAU = @matkhau where TEN_TAI_KHOAN = @tentaikhoan";
            command.Parameters.AddWithValue("@tentaikhoan", dtk.Tentaikhoan);
            command.Parameters.AddWithValue("@matkhau", dtk.Matkhau);
            command.ExecuteNonQuery();
            connectionString.Close();
        }

        public string getVaiTro_TK(dto_taikhoan dtk)
        {
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "select VAI_TRO from TAIKHOAN where TEN_TAI_KHOAN = @tentaikhoan";
            command.Parameters.AddWithValue("@tentaikhoan", dtk.Tentaikhoan);
            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);

            string temp = table.Rows[0][0].ToString();
            return temp;
        }

        public DataTable getNhanVien()
        {
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "select TEN_TAI_KHOAN as [Tên tài khoản] , MAT_KHAU as [Mật khẩu], HO_VA_TEN_USER as [Họ và tên nhân viên] from TAIKHOAN where VAI_TRO != N'Chủ tiệm'";
            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);
            connectionString.Close();

            return table;
        }

        public void del_NhanVien(dto_taikhoan dtk)
        {
            connectionString.Open();
            SqlCommand command = connectionString.CreateCommand();
            command.CommandText = "delete from TAIKHOAN where TEN_TAI_KHOAN = @tentaikhoan";
            command.Parameters.AddWithValue("@tentaikhoan", dtk.Tentaikhoan);
            command.ExecuteNonQuery();
            connectionString.Close();
        }
    }
}
