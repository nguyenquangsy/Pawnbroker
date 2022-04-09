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
    public partial class Doanhthu_KH : Form
    {
        public string Vaitro;

        int type;

        bus_doanhthu_KH bdt_kh = new bus_doanhthu_KH();

        public Doanhthu_KH()
        {
            InitializeComponent();
            this.ControlBox = false;
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void btn_ok_Click(object sender, EventArgs e)
        {
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
                        dto_khachhang dkh = new dto_khachhang(0,null,null,null,txt_CMND.Text,false);
                        dto_datetime ddt = new dto_datetime(t_ngay, t_thang, t_nam);

                        dtgv.DataSource = bdt_kh.getDoanhThuNgay_KH(ddt,dkh);
                        txt_TongTien.Text = bdt_kh.tongngay_KH(ddt,dkh);

                    }
                    break;
                case 2:
                    {
                        dto_khachhang dkh = new dto_khachhang(0, null, null, null, txt_CMND.Text, false);
                        dto_datetime ddt = new dto_datetime(null, t_thang, t_nam);

                        dtgv.DataSource = bdt_kh.getDoanhThuThang_KH(ddt,dkh);
                        txt_TongTien.Text = bdt_kh.tongthang_KH(ddt,dkh);
                    }
                    break;
                case 3:
                    {
                        dto_khachhang dkh = new dto_khachhang(0, null, null, null, txt_CMND.Text, false);   
                        dto_datetime ddt = new dto_datetime(null, null, t_nam);

                        dtgv.DataSource = bdt_kh.getDoanhThuNam_KH(ddt,dkh);
                        txt_TongTien.Text = bdt_kh.tongnam_KH(ddt,dkh);
                    }
                    break;
                case 4:
                    {
                        dto_khachhang dkh = new dto_khachhang(0, null, null, null, txt_CMND.Text, false);

                        dtgv.DataSource = bdt_kh.getAll_KH(dkh);
                        txt_TongTien.Text = bdt_kh.tongall_KH(dkh);
                    }
                    break;
                case 5:
                    {
                        dto_khachhang dkh = new dto_khachhang(0, null, null, null, txt_CMND.Text, false);

                        dtgv.DataSource = bdt_kh.getKhoangTg_KH(dtp_tu.Value, date_time.Value,dkh);
                        txt_TongTien.Text = bdt_kh.tongKhoangTg_KH(dtp_tu.Value, date_time.Value,dkh);
                    }
                    break;
            }
        }       

        public void phim(bool value)
        {
            label2.Visible = value;
            label3.Visible = value;
            dtp_tu.Visible = value;
        }

        private void txt_cmnd_Click(object sender, EventArgs e)
        {
            if(txt_CMND.Text.Equals("Số CMND"))
            {
                txt_CMND.Text = null;
                txt_CMND.ForeColor = Color.Black;
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
    }
}
