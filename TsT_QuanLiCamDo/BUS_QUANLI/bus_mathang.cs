using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DTO_QUANLI;
using DAL_QUANLI;
//using Microsoft.VisualBasic;

namespace BUS_QUANLI
{
    public class bus_mathang
    {
        dal_mathang dal_mh = new dal_mathang();

        public DataTable getmathang()
        {
            return dal_mh.getmathang();
        }

        public void themmathang(dto_mathang dmh,dto_loaimathang dlmh)
        {
            if (dmh.Mamathang.Equals("") || dmh.Tenmathang.Equals("") || dlmh.Tenloai.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mặt hàng");
                return;
            }

            string temp = dal_mh.timkiemmaloai(dlmh);

            if(temp.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show(dlmh.Tenloai + " là loại mặt hàng này hiện tại chưa có, bạn có muốn thêm loại mặt hàng này không?", "Ping!!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dal_mh.themloaimathang(dlmh);
                }
                else
                {
                    return;
                }

                temp = dal_mh.timkiemmaloai(dlmh);
            } 

            if(dal_mh.check_mh(dmh))
            {
                dal_mh.them_avai(dmh);
                return;
            }    
            dal_mh.them(dmh,temp);
        }

        public void xoamathang(dto_mathang dmh)
        {
            if (dmh.Mamathang.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn mặt hàng để xóa");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa mặt hàng đã chọn?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            
            dal_mh.xoa(dmh);
        }

        public bool suamathang(dto_mathang dmh,dto_loaimathang dlmh)
        {
            if (dmh.Mamathang.Equals("") || dmh.Tenmathang.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn mặt hàng để sửa");
                return false;
            }

            if (MessageBox.Show("Bạn có muốn sửa mặt hàng đã chọn?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return false;
            }

            return dal_mh.sua(dmh, dlmh);
        }

        // Tìm kiếm những mặt hàng đang tồn tại trong kho với số lượng
        public DataTable gettimkiem(dto_mathang dmh)
        {
            return dal_mh.gettimkiem(dmh);
        }

        public DataTable getdanhsachtimkiem()
        {
            return dal_mh.getdanhsachtimkiem();
        }
        //------------------------------------------------------------

        public DataTable getTimKiem_MH(dto_mathang dmh) // Tìm kiếm thông tin mặt hàng trong sql
        {
            return dal_mh.getTimKiem_MH(dmh);
        }
    }
}
