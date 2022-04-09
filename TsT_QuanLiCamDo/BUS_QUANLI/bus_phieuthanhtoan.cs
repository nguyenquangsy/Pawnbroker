using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QUANLI;
using DAL_QUANLI;
using System.Windows.Forms;
using System.Data;

namespace BUS_QUANLI
{
    public class bus_phieuthanhtoan
    {
        dal_phieuthanhtoan dal_ptt = new dal_phieuthanhtoan();

        public void updatephieuthanhtoan(dto_phieuthanhtoan dptt,string tienlai,string tong)
        {  
            dal_ptt.updatethanhtoan(dptt,tienlai,tong);
        }

        public bool check_ct_phieucamdo(dto_phieuthanhtoan dptt)
        {
            if (!dal_ptt.checkct_phieucamdo(dptt))
            {
                MessageBox.Show("Phiếu của khách hàng chưa có sản phẩm. Vui lòng nhập phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public string tong(string maphieu)
        {
            return dal_ptt.tong(maphieu);
        }

        public string tienlai(dto_phieuthanhtoan dptt)
        {
            return dal_ptt.tienlai(dptt);
        }

        public string check_MaPhieuThanhToan(dto_phieuthanhtoan dptt)
        {
            return dal_ptt.check_MaPhieuThanhToan(dptt);
        }

        public DataTable get_PhieuThanhToan(string maphieuthanhtoan)
        {
            return dal_ptt.get_PhieuThanhToan(maphieuthanhtoan);
        }

        public DataTable get_ttkh(string maphieu)
        {
            return dal_ptt.get_ttkhachhang(maphieu);
        }

        public DataTable get_Phieuhen(string maphieu)
        {
            return dal_ptt.get_Phieuhen(maphieu);
        }
    }
}
