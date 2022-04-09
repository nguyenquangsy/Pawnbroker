using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QUANLI;
using DAL_QUANLI;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BUS_QUANLI
{
    public class bus_camdo
    {
        dal_camdo dcd = new dal_camdo();

        public DataTable getcamdo(dto_taikhoan dtk)
        {
            return dcd.getcamdo(dtk);
        }

        public void them(dto_phieucamdo dpcd)
        {            
            if(dpcd.Maphieu.Equals("") || dpcd.Tienlai.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu");
                return ;
            }

            dcd.them(dpcd);
        }

        public string locten()
        {
            DialogResult dialogResult = MessageBox.Show("Đã có sẳn khách hàng chưa?", "Ping!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string content = Interaction.InputBox("Xin vui lòng nhập 1 số thông tin khách hàng", "Truy tìm khách hàng", "Nhập số cmnd", 700, 500);
                if (content.Equals(""))
                {
                    return "";
                }

                dto_khachhang dkh = new dto_khachhang(0,null,null,null,content,false);
                string ma = dcd.truytimkhachhang(dkh);
                if(!ma.Equals(""))
                {
                    return ma;
                }    
            }
            else if (dialogResult == DialogResult.No)
            {
                //MessageBox.Show("Xin lòng nhập thêm thông tin khách hàng!");
                return "";
            }
            MessageBox.Show("Xin lòng nhập thêm thông tin khách hàng!");
            return "";
        }

        public void xoa(dto_phieucamdo dpcd)
        {
            if (dpcd.Maphieu.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn phiếu để xóa!");
                return ;
            }
            if (MessageBox.Show("Bạn có muốn xóa phiếu đã chọn?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return ;
            }

            dcd.xoa(dpcd);
        }

        public bool sua(dto_phieucamdo dpcd,dto_khachhang dkh)
        {
            if (dpcd.Maphieu.Equals("") || dpcd.Tienlai.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu");
                return false;
            }

            if (MessageBox.Show("Bạn có muốn sửa phiếu đã chọn?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return false;
            }

            int a = dcd.sua(dpcd, dkh);
            if (a == 0)
                return true;
            if(a == 1)
            {
                MessageBox.Show("Xin vui lòng nhập thêm khách hàng " + dkh.Tenkhachhang + "!");
            }
            return false;
        }

        public DataTable getphieugiahan()
        {
            return dcd.getphieuquahan();
        }

        public DataTable getphieudangcam()
        {
            return dcd.getphieudangcam();
        }

        public DataTable getphieudatra()
        {
            return dcd.getphieudatra();
        }

        public DataTable getTimKiem(dto_khachhang dkh)
        {
            return dcd.getTimKiemPhieu(dkh);
        }
    }
}
