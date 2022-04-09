using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QUANLI;
using DTO_QUANLI;
using System.Windows.Forms;

namespace BUS_QUANLI
{
    public class bus_khachhang
    {
        dal_khachhang dal_kh = new dal_khachhang();

        public DataTable getkhachhang()
        {
            return dal_kh.getkhachhang();
        }

        public bool themkhachhang(dto_khachhang dkh)
        {
            if(dkh.Tenkhachhang.Equals("") ||dkh.Sdt.Equals("") || dkh.Diachi.Equals("") || dkh.Cmnd.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                return false;
            }
            string temp = dkh.Sdt;
            if(temp.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại");
                return false;
            }
            temp = dkh.Cmnd;
            if(temp.Length != 12 && temp.Length != 9)
            {
                MessageBox.Show("Vui lòng nhập đúng số cmnd");
                return false;
            }    

            if(dal_kh.check_kh(dkh))
            {
                dal_kh.them_avai(dkh);
                return true;
            }
            dal_kh.them(dkh);
            return true;
        }

        public void xoakhachhang(dto_khachhang dkh)
        {
            if (dkh.Makhachhang.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa khách hàng đã chọn?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            dal_kh.xoa(dkh);
        }

        public void suakhachhang(dto_khachhang dkh)
        {
            if (dkh.Makhachhang.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa!");
                return;
            }

            if (MessageBox.Show("Bạn có muốn sửa khách hàng đã chọn?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            int a = dal_kh.sua(dkh);

            if(a == 1)
            {
                MessageBox.Show("Bị trùng khách hàng đã có");
                return;
            }    
        }

        // Tìm kiếm khách hàng có phiếu và đang cầm 
        public DataTable getdanhsachtimkiem()
        {
            return dal_kh.getdanhsachtimkiem();
        }

        public DataTable gettimkiem(dto_khachhang dkh)
        {
            return dal_kh.gettimkiem(dkh);
        }
        //--------------------------------------------

        public DataTable getTimKiem_KH(dto_khachhang dkh)// Tìm kiếm thông tin khách hàng
        {
            return dal_kh.getTimKiem_KH(dkh);
        }

        public DataTable getdanhsachkhachhangvipham()
        {
            return dal_kh.getdanhsachkhachhangvipham();
        }

        public DataTable getTimKiem_KHVP(dto_khachhang dkh)
        {
            return dal_kh.getTimKiem_KHVP(dkh);
        }
    }
}
