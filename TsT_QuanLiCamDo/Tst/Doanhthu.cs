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
    public partial class Doanhthu : Form
    {
        public string Vaitro;

        public Doanhthu()
        {
            InitializeComponent();
            this.ControlBox = false;
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        int type;

        bus_doanhthu bdt = new bus_doanhthu();

        private void btn_ngay_Click(object sender, EventArgs e)
        {
            type = 1;
            btn_all.BackColor = Color.White;
            btn_ngay.BackColor = Color.Red;
            btn_Thang.BackColor = Color.White;
            btn_nam.BackColor = Color.White;
            btn_khoangtg.BackColor = Color.White;
            phim(false);
            data_time.MinDate = dtp_tu.MinDate;
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
            data_time.MinDate = dtp_tu.MinDate;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            trang_chủ tc = new trang_chủ();
            tc.Vaitro = Vaitro;
            this.Close();
            tc.Show();
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
                string temp = data_time.Value.ToString();
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

                        dtgv.DataSource = bdt.getDoanhThuNgay(ddt);
                        txt_TongTien.Text = bdt.tongngay(ddt);

                    }
                    break;
                case 2:
                    {
                        dto_datetime ddt = new dto_datetime(null, t_thang, t_nam);

                        dtgv.DataSource = bdt.getDoanhThuThang(ddt);
                        txt_TongTien.Text = bdt.tongthang(ddt);
                    }
                    break;
                case 3:
                    {
                        dto_datetime ddt = new dto_datetime(null, null, t_nam);

                        dtgv.DataSource = bdt.getDoanhThuNam(ddt);
                        txt_TongTien.Text = bdt.tongnam(ddt);
                    }
                    break;
                case 4:
                    {
                        dtgv.DataSource = bdt.getAll();
                        txt_TongTien.Text = bdt.tongall();
                    }
                    break;
                case 5:
                    {
                        dtgv.DataSource = bdt.getKhoangTg(dtp_tu.Value, data_time.Value);
                        txt_TongTien.Text = bdt.tongKhoangTg(dtp_tu.Value, data_time.Value);
                    }break;
            }
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
            data_time.MinDate = dtp_tu.MinDate;
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
        }

        private void btn_TheoKhachHang_Click(object sender, EventArgs e)
        {
            Doanhthu_KH dtkh = new Doanhthu_KH();
            dtkh.Vaitro = Vaitro;
            this.Close();
            dtkh.Show();
        }

        private void btn_TheoMatHang_Click(object sender, EventArgs e)
        {
            Doanhthu_MH dtmh = new Doanhthu_MH();
            dtmh.Vaitro = Vaitro;
            this.Close();
            dtmh.Show();
        }

        private void dtp_tu_ValueChanged(object sender, EventArgs e)
        {
            data_time.MinDate = dtp_tu.Value;
        }

        private void Doanhthu_Load(object sender, EventArgs e)
        {

        }
    }
}