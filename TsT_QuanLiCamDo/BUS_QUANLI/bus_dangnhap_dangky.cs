using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_QUANLI;
using DTO_QUANLI;
using Microsoft.VisualBasic;

namespace BUS_QUANLI
{
    public class bus_dangnhap_dangky
    {
        dal_dangnhap_dangky ddndk = new dal_dangnhap_dangky();

        public bool them(dto_taikhoan dtk)
        {
            return ddndk.them(dtk);
        }

        public bool check(dto_taikhoan dtk)
        {
            return ddndk.check(dtk);
        }

        public bool thaydoimatkhau(dto_taikhoan dtk,string confirm_pass,string old_pass)
        {
            if (dtk.Matkhau.Equals(confirm_pass))
            {
                int a = ddndk.thaydoimatkhau(dtk,old_pass);
                if (a == 0)
                    return true;
                MessageBox.Show("Vui lòng nhập đúng mật khẩu cũ!");
            }
            else
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không giống nhau!");
            }
            return false;
        }

        public bool checkdangky()
        {
            string content = Interaction.InputBox("Vui lòng nhập mã đăng ký", "Nhập", "Mã", 700, 500);
            if(content.Equals(""))
            {
                return false;
            }

            dto_taikhoan dtk = new dto_taikhoan(null, null, content, null, null);

            if (ddndk.checkdangky(dtk))
            {
                return true;
            }
            MessageBox.Show("Vui lòng nhập đúng mã đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public bool checktaikhoan(dto_taikhoan dtk)
        {
            if(dtk.Tentaikhoan.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản của bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }    
            if(dtk.Quenmatkhau.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mã đăng ký của bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return ddndk.checktaikhoan(dtk);
        }

        public bool update_matkhau(dto_taikhoan dtk,string temp)
        {
            if(!dtk.Matkhau.Equals(temp))
            {
                MessageBox.Show("Mật khẩu không khớp, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }    

            ddndk.update_MatKhau(dtk);
            return true;
        }

        public string getVaiTro_TK(dto_taikhoan dtk)
        {
            return ddndk.getVaiTro_TK(dtk);
        }

        public DataTable getNhanVien()
        {
            return ddndk.getNhanVien();
        }

        public void del_NhanVien(dto_taikhoan dtk)
        {
            if(MessageBox.Show("Bạn có muốn xóa nhân viên này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }    

            ddndk.del_NhanVien(dtk);
        }
    }
}
