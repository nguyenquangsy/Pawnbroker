using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QUANLI;
using BUS_QUANLI;

namespace Tst
{
    public partial class Doanhthu_MH : Form
    {
        public string Vaitro;

        int type;

        bus_doanhthu_MH bdt_mh = new bus_doanhthu_MH();
        bus_ct_phieucamdo bctpcd = new bus_ct_phieucamdo();

        public Doanhthu_MH()
        {
            InitializeComponent();
        }

        public void phim(bool value)
        {
            label2.Visible = value;
            label3.Visible = value;
            dtp_tu.Visible = value;
        }

        private void btn_khoangtg_Click(object sender, EventArgs e)
        {
            type = 5;
            btn_all.BackColor = Color.White;
            btn_ngay.BackColor = Color.White;
            btn_Thang.BackColor = Color.White;
            btn_nam.BackColor = Color.White;
            btn_khoangtg.BackColor = Color.Red;
            phim(true);
            date_time.MinDate = DateTime.Now;
        }

        private void btn_ngay_Click(object sender, EventArgs e)
        {
            type = 1;
            btn_all.BackColor = Color.White;
            btn_ngay.BackColor = Color.Red;
            btn_Thang.BackColor = Color.White;
            btn_nam.BackColor = Color.White;
            btn_khoangtg.BackColor = Color.White;
            phim(false);
            date_time.MinDate = dtp_tu.MinDate;
        }

        private void btn_Thang_Click(object sender, EventArgs e)
        {
            type = 2;
            btn_all.BackColor = Color.White;
            btn_ngay.BackColor = Color.White;
            btn_Thang.BackColor = Color.Red;
            btn_nam.BackColor = Color.White;
            btn_khoangtg.BackColor = Color.White;
            phim(false);
            date_time.MinDate = dtp_tu.MinDate;
        }

        private void btn_nam_Click(object sender, EventArgs e)
        {
            type = 3;
            btn_all.BackColor = Color.White;
            btn_ngay.BackColor = Color.White;
            btn_Thang.BackColor = Color.White;
            btn_nam.BackColor = Color.Red;
            btn_khoangtg.BackColor = Color.White;
            phim(false);
            date_time.MinDate = dtp_tu.MinDate;
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            type = 4;
            btn_all.BackColor = Color.Red;
            btn_ngay.BackColor = Color.White;
            btn_Thang.BackColor = Color.White;
            btn_nam.BackColor = Color.White;
            btn_khoangtg.BackColor = Color.White;
            phim(false);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            dto_mathang dmh = new dto_mathang(0, cmb_TenMatHang.Text, 0, false);
            if (!bdt_mh.check_MH(dmh))
            {
                MessageBox.Show("Mặt hàng này chưa được bất cứ ai cầm");
                return;
            }    
            string t_ngay = null, t_thang = null, t_nam = null;
            if (type == 0)
            {
                return;
            }
            else if (type < 5)
            {
                string temp = date_time.Value.ToString();
                int dem = 1;
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i].ToString().Equals("/"))
                    {
                        dem++;
                    }
                    else if (!temp[i].ToString().Equals(" "))
                    {
                        switch (dem)
                        {
                            case 1:
                                {
                                    t_thang += temp[i];
                                }
                                break;
                            case 2:
                                {
                                    t_ngay += temp[i];
                                }
                                break;
                            case 3:
                                {
                                    t_nam += temp[i];
                                }
                                break;
                        }
                    }
                    else
                    {
                        i = temp.Length + 1;
                    }
                }
            }
            switch (type)
            {
                case 1:
                    {
                        dto_datetime ddt = new dto_datetime(t_ngay, t_thang, t_nam);

                        dtgv.DataSource = bdt_mh.getDoanhThuNgay_MH(ddt,dmh);
                        txt_TongTien.Text = bdt_mh.tongngay_MH(ddt,dmh);

                    }
                    break;
                case 2:
                    {
                        dto_datetime ddt = new dto_datetime(null, t_thang, t_nam);

                        dtgv.DataSource = bdt_mh.getDoanhThuThang_MH(ddt,dmh);
                        txt_TongTien.Text = bdt_mh.tongthang_MH(ddt,dmh);
                    }
                    break;
                case 3:
                    {
                        dto_datetime ddt = new dto_datetime(null, null, t_nam);

                        dtgv.DataSource = bdt_mh.getDoanhThuNam_MH(ddt,dmh);
                        txt_TongTien.Text = bdt_mh.tongnam_MH(ddt,dmh);
                    }
                    break;
                case 4:
                    {
                        dtgv.DataSource = bdt_mh.getAll_MH(dmh);
                        txt_TongTien.Text = bdt_mh.tongall_MH(dmh);
                    }
                    break;
                case 5:
                    {
                        dtgv.DataSource = bdt_mh.getKhoangTg_MH(dtp_tu.Value, date_time.Value,dmh);
                        txt_TongTien.Text = bdt_mh.tongKhoangTg_MH(dtp_tu.Value, date_time.Value,dmh);
                    }
                    break;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Doanhthu dt = new Doanhthu();
            dt.Vaitro = Vaitro;
            this.Close();
            dt.Show();
        }

        private void dtp_tu_ValueChanged(object sender, EventArgs e)
        {
            date_time.MinDate = dtp_tu.Value;
        }

        private void Doanhthu_MH_Load(object sender, EventArgs e)
        {
            cmb_TenMatHang.DataSource = bctpcd.getmathang();
            cmb_TenMatHang.ValueMember = "TENMATHANG";
            cmb_TenMatHang.DisplayMember = "TENMATHANG";
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
