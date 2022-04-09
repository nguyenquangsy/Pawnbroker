using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QUANLI;
using DAL_QUANLI;
using System.Data;
using System.Windows.Forms;

namespace BUS_QUANLI
{
    public class bus_ct_phieucamdo
    {
        dal_ct_phieucamdo dal_ctpcd = new dal_ct_phieucamdo();

        public DataTable getctphieucamdo(dto_ct_phieucamdo dctpcd)
        {
            return dal_ctpcd.getctphieucamdo(dctpcd);
        }

        public void themctphieu(dto_ct_phieucamdo dctpcd,dto_mathang dmh)
        {
            int a = dal_ctpcd.them(dctpcd, dmh);

            if (a == 0)
                return ;
            if (a == 1)
            {
                MessageBox.Show("Đã tồn tại mặt hàng " + dmh.Tenmathang + " bên phiếu này rồi!");
                return;
            }
            MessageBox.Show("Tên mặt hàng chưa tồn tại!");
        }

        public void xoactphieu(dto_ct_phieucamdo dctpcd, dto_mathang dmh)
        {
            dal_ctpcd.xoa(dctpcd, dmh);
        }

        public void suactphieu(dto_ct_phieucamdo dctpcd, dto_mathang dmh)
        {
            int a = dal_ctpcd.sua(dctpcd, dmh);

            if (a == 0)
                return;
            MessageBox.Show("Mặt hàng này chưa tồn tại!");
        }

        public DataTable getmathang()
        {
            return dal_ctpcd.getmathang();
        }
    }
}
