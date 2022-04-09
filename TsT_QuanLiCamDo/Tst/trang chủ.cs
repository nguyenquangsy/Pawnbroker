using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using BUS_QUANLI;
using DTO_QUANLI;

namespace Tst
{

    public partial class trang_chủ : Form
    {
        bus_mathang bmh = new bus_mathang();
        bus_camdo bcd = new bus_camdo();
        bus_khachhang bkh = new bus_khachhang();
        bus_phieuthanhtoan bptt = new bus_phieuthanhtoan();

        int type;

        bool type_temp = true;
        public bool trangthai_phieu;

        public string tk;
        public string ten;

        public string Vaitro;

        public trang_chủ()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        void camdo()
        {
            chan_bam(true);
            groupBox1.Text = "Thông tin phiếu cầm đồ";
            lb_a1.Text = "Mã phiếu:";
            lb_a1.Location = new Point(57, lb_a1.Location.Y);
            lb_a2.Text = "Lãi suất:";
            lb_a2.Location = new Point(71, lb_a2.Location.Y);
            lb_a3.Text = "Tên khách hàng:";
            lb_a3.Location = new Point(8, lb_a3.Location.Y);
            lb_a4.Text = "Ngày lập:";
            lb_a4.Location = new Point(494, lb_a4.Location.Y);
            lb_a5.Text = "Ngày trả:";
            lb_a5.Location = new Point(496, lb_a5.Location.Y);

            lb_a1.Visible = true;
            lb_a2.Visible = true;
            lb_a3.Visible = true;
            txt_a1.Visible = true;
            txt_a2.Visible = true;
            txt_a3.Visible = true;
            txt_a2.Enabled = false;
            txt_a2.Text = "0.1  ";

            txt_a4.Visible = false;
            txt_a5.Visible = false;
            lb_a4.Visible = true;
            lb_a5.Visible = true;
            bth_chitietphieu.Visible = true;
            //check_trangthai.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;

            bth_chitietphieu.Visible = true;
            txt_a2.Text = "0.01";

            bth_XN.Visible = true;
            btn_taophieuhen.Visible = true;
            btn_phieuthanhtoan.Visible = true;
            txt_TimKiem.Text = "Số CMND";
            txt_TimKiem.ForeColor = Color.LightGray;

            if (type_temp)
            {
                txt_a1.Text = null;
                //txt_a2.Text = null;
                txt_a3.Text = null;
                txt_a4.Text = null;
                txt_a5.Text = null;
            }

            dgvtt.Size = new Size(dgvtt.Size.Width, 422);
            groupBox1.Visible = true;

            lb_a1.Visible = true;
        }

        void mathang()
        {
            chan_bam(true);
            groupBox1.Text = "Thông tin mặt hàng";
            lb_a1.Text = "Mã mặt hàng:";
            lb_a1.Location = new Point(29, lb_a1.Location.Y);
            lb_a2.Text = "Tên mặt hàng:";
            lb_a2.Location = new Point(24, lb_a2.Location.Y);
            lb_a3.Text = "Tên loại:";
            lb_a3.Location = new Point(67, lb_a3.Location.Y);

            lb_a1.Visible = true;
            lb_a2.Visible = true;
            lb_a3.Visible = true;
            txt_a1.Visible = true;
            txt_a2.Visible = true;
            txt_a3.Visible = true;

            txt_a4.Visible = false;
            txt_a5.Visible = false;
            lb_a4.Visible = false;
            lb_a5.Visible = false;
            bth_chitietphieu.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;

            bth_chitietphieu.Visible = false;

            bth_XN.Visible = true;
            btn_taophieuhen.Visible = false;
            btn_phieuthanhtoan.Visible = false;
            txt_TimKiem.Text = "Tên mặt hàng";
            txt_TimKiem.ForeColor = Color.LightGray;

            if (type_temp)
            {
                txt_a1.Text = null;
                txt_a2.Text = null;
                txt_a3.Text = null;
                txt_a4.Text = null;
                txt_a5.Text = null;
            }

            dgvtt.Size = new Size(dgvtt.Size.Width, 422);
            groupBox1.Visible = true;

            lb_ngay.Visible = false;
        }

        void khachhang()
        {
            chan_bam(true);
            groupBox1.Text = "Thông tin khách hàng";
            lb_a1.Text = "Mã khách hàng:";
            lb_a1.Location = new Point(13, lb_a1.Location.Y);
            lb_a2.Text = "Tên khách hàng:";
            lb_a2.Location = new Point(8, lb_a2.Location.Y);
            lb_a3.Text = "Số điện thoại:";
            lb_a3.Location = new Point(29, lb_a3.Location.Y);
            lb_a4.Text = "Địa chỉ:";
            lb_a4.Location = new Point(507, lb_a4.Location.Y);
            lb_a5.Text = "CMND:";   
            lb_a5.Location = new Point(508, lb_a5.Location.Y);           

            lb_a1.Visible = true;
            lb_a2.Visible = true;
            lb_a3.Visible = true;
            txt_a1.Visible = true;
            txt_a2.Visible = true;
            txt_a3.Visible = true;

            txt_a4.Visible = true;
            txt_a5.Visible = true;
            lb_a4.Visible = true;
            lb_a5.Visible = true;
            bth_chitietphieu.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;

            bth_chitietphieu.Visible = false;

            bth_XN.Visible = true;
            btn_taophieuhen.Visible = false;
            btn_phieuthanhtoan.Visible = false;
            txt_TimKiem.Text = "Số CMND";
            txt_TimKiem.ForeColor = Color.LightGray;

            if (type_temp)
            {
                txt_a1.Text = null;
                txt_a2.Text = null;
                txt_a3.Text = null;
                txt_a4.Text = null;
                txt_a5.Text = null;
            }

            dgvtt.Size = new Size(dgvtt.Size.Width, 422);
            groupBox1.Visible = true;

            lb_ngay.Visible = false;
        }

        private void đăngSuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   this.Hide();
            Form1 dn = new Form1();
            this.Close();
            dn.Show();
            //this.Close();
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thay_đổi_mật_khảu dk = new Thay_đổi_mật_khảu();
            dk.Vaitro = Vaitro;
            dk.tk = tk;
            this.Close();
            dk.Show();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvtt.DataSource = bmh.getmathang();
            dgvtt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            type = 1;
            mathang();
            //group.Text = "Thông tin mặt hàng";
        }

        private void thêmMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //them_xoa_sua(1);
            mathang();
            type = 1;
            bth_XN.Text = "Thêm";
            bth_XN.Enabled = true;
            txt_a2.Enabled = true;
            txt_a3.Enabled = true;
            /*thêmMặtHàngToolStripMenuItem.Enabled = false;
            xóaMặtHàngToolStripMenuItem.Enabled = false;
            sửaMặtHàngToolStripMenuItem.Enabled = false;*/
        }

        private void sửaMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //them_xoa_sua(3);
            mathang();
            type = 3;
            bth_XN.Text = "Sửa";
            bth_XN.Enabled = true;
            txt_a2.Enabled = true;
            txt_a3.Enabled = true;
            /*thêmMặtHàngToolStripMenuItem.Enabled = false;
            xóaMặtHàngToolStripMenuItem.Enabled = false;
            sửaMặtHàngToolStripMenuItem.Enabled = false;*/
        }

        private void xóaMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //them_xoa_sua(2);
            mathang();
            type = 2;
            bth_XN.Text = "Xóa";
            bth_XN.Enabled = true;
            /*thêmMặtHàngToolStripMenuItem.Enabled = false;
            xóaMặtHàngToolStripMenuItem.Enabled = false;
            sửaMặtHàngToolStripMenuItem.Enabled = false;*/
        }

        private void XN_Click(object sender, EventArgs e)
        {
            switch(type)
            {
                case 1:  // thêm mặt hàng
                    {
                        dto_loaimathang dlmh = new dto_loaimathang(0,txt_a3.Text);
                        dto_mathang dmh = new dto_mathang(0,txt_a2.Text,0,false);

                        bmh.themmathang(dmh, dlmh);  
                    }
                    break;
                case 2:  // xóa mặt hàng
                    {
                        dto_mathang dmh = new dto_mathang(int.Parse(txt_a1.Text), null, 0,false);

                        bmh.xoamathang(dmh);
                    }
                    break;
                case 3:  // sửa mặt hàng
                    {
                        dto_loaimathang dlmh = new dto_loaimathang(0, txt_a3.Text);
                        dto_mathang dmh = new dto_mathang(int.Parse(txt_a1.Text), txt_a2.Text, 0,false);

                        bmh.suamathang(dmh, dlmh);
                    }
                    break;
                case 4:  // thêm phiếu
                    {
                        string temp = dateTimePicker1.Value.ToString();
                        string temp1 = dateTimePicker2.Value.ToString();

                        dto_phieucamdo dpcd = new dto_phieucamdo(0, temp, temp1, float.Parse(txt_a2.Text), false, int.Parse(txt_a3.Text), tk,false);
                        bcd.them(dpcd);
                        chan_bam(true);
                    }
                    break;
                case 6:  // xóa phiếu
                    {
                       /* string temp = dateTimePicker1.Value.ToString();
                        string temp1 = dateTimePicker2.Value.ToString();*/

                        dto_phieucamdo dpcd = new dto_phieucamdo(int.Parse(txt_a1.Text), null, null, 0, false, 0, null,false);
                        bcd.xoa(dpcd);
                    }
                    break;
                case 5:  // sửa phiéu
                    {
                        string temp = dateTimePicker1.Value.ToString();
                        string temp1 = dateTimePicker2.Value.ToString();

                        dto_phieucamdo dpcd = new dto_phieucamdo(int.Parse(txt_a1.Text),temp,temp1,float.Parse(txt_a2.Text)/100,false,0,null,false);
                        dto_khachhang dkh = new dto_khachhang(0,txt_a3.Text,null,null,null,false);

                        bcd.sua(dpcd, dkh);
                    }
                    break;
                case 7:  // thêm khách hàngz
                    {
                        dto_khachhang dkh = new dto_khachhang(0, txt_a2.Text, txt_a3.Text, txt_a4.Text, txt_a5.Text,false);

                        if (bkh.themkhachhang(dkh))
                            type_temp = true;
                        else
                            type_temp = false;
                    }break;
                case 8:  // xóa khách hàng
                    {
                        dto_khachhang dkh = new dto_khachhang(int.Parse(txt_a1.Text), null, null, null, null,false);

                        bkh.xoakhachhang(dkh);
                    }break;
                case 9:  // sửa khách hàng
                    {
                        dto_khachhang dkh = new dto_khachhang(int.Parse(txt_a1.Text), txt_a2.Text, txt_a3.Text, txt_a4.Text, txt_a5.Text,false);

                        bkh.suakhachhang(dkh);
                    }
                    break;
                case 10:
                    {

                    }break;
            }
            dgvtt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //MessageBox.Show(type.ToString());
            if (type_temp)
            {
                bth_XN.Enabled = false;
                txt_a1.Enabled = false;
                txt_a2.Enabled = false;
                txt_a3.Enabled = false;
                /*if (type < 9)
                {
                    thêmMặtHàngToolStripMenuItem.Enabled = true;
                    xóaMặtHàngToolStripMenuItem.Enabled = true;
                    sửaMặtHàngToolStripMenuItem.Enabled = true;

                    lậpPhiếuCầmĐồToolStripMenuItem.Enabled = true;
                    xóaPhiếuCầmĐồToolStripMenuItem.Enabled = true;
                    sửaPhiếuCầmĐồToolStripMenuItem.Enabled = true;

                    thêmKháchHàngToolStripMenuItem.Enabled = true;
                    xóaKháchHàngToolStripMenuItem.Enabled = true;
                    sửaThôngTinKháchHàngToolStripMenuItem.Enabled = true;
                }*/

                if (type <= 3)
                {
                    dgvtt.DataSource = bmh.getmathang();

                }
                else if (type <= 6)
                {
                    dto_taikhoan dtk = new dto_taikhoan(tk, null, null, null, null);

                    dgvtt.DataSource = bcd.getcamdo(dtk);

                    dateTimePicker2.Enabled = false;
                }
                else if (type <= 9)
                {
                    dgvtt.DataSource = bkh.getkhachhang(); //đổ dữ liệu vào datagridview

                    txt_a4.Enabled = false;
                    txt_a5.Enabled = false;
                }
            }
        }

        private void cầmChuộcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dto_taikhoan dtk = new dto_taikhoan(tk, null, null,null,null);
            dgvtt.DataSource = bcd.getcamdo(dtk); //đổ dữ liệu vào datagridview
            dgvtt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //group.Text = "Thông tin phiếu";
            type = 4;
            camdo();
        }

        private void chan_bam(bool temp) //khi chọn lập phiếu thì kh cho vào danh sách
        {
            dgvtt.Enabled = temp;
        }

        private void lậpPhiếuCầmĐồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bth_XN.Text = "Thêm";
            /*lb_a1.Visible = false;
            lb_a2.Visible = false;
            lb_a3.Visible = false;
            lb_a4.Visible = false;
            lb_a5.Visible = false;
            txt_a1.Visible = false;
            txt_a2.Visible = false;
            txt_a3.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;*/
            ten = bcd.locten();
            if (!ten.Equals(""))
            {
                dateTimePicker2.MinDate = dateTimePicker1.Value;
                //them_xoa_sua(4);
                camdo();
                chan_bam(false);
                bth_XN.Text = "Thêm";
                type = 4;
                bth_XN.Enabled = true;
                txt_a2.Enabled = true;
                txt_a3.Text = ten;
                dateTimePicker2.Enabled = true;
                /*lậpPhiếuCầmĐồToolStripMenuItem.Enabled = false;
                xóaPhiếuCầmĐồToolStripMenuItem.Enabled = false;
                sửaPhiếuCầmĐồToolStripMenuItem.Enabled = false;*/
                return;
            }
            type = 10; // nằm ngoài vùng lựa chọn
        }

        private void sửaPhiếuCầmĐồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //them_xoa_sua(5);
            camdo();
            type = 5;
            bth_XN.Text = "Sửa";
            bth_XN.Enabled = true;
            txt_a2.Enabled = true;
            txt_a3.Enabled = true;
            dateTimePicker2.Enabled = true;
            /*lậpPhiếuCầmĐồToolStripMenuItem.Enabled = false;
            xóaPhiếuCầmĐồToolStripMenuItem.Enabled = false;
            sửaPhiếuCầmĐồToolStripMenuItem.Enabled = false;*/
        }

        private void xóaPhiếuCầmĐồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //them_xoa_sua(6);
            camdo();
            type = 6;
            bth_XN.Text = "Xóa";
            bth_XN.Enabled = true;
            /*lậpPhiếuCầmĐồToolStripMenuItem.Enabled = false;
            xóaPhiếuCầmĐồToolStripMenuItem.Enabled = false;
            sửaPhiếuCầmĐồToolStripMenuItem.Enabled = false;*/
        }

        private void khánhHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvtt.DataSource = bkh.getkhachhang(); //đổ dữ liệu vào datagridview
            dgvtt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            type = 7;
            khachhang();
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //them_xoa_sua(7);
            khachhang();
            type = 7;            
            bth_XN.Text = "Thêm";
            bth_XN.Enabled = true;
            txt_a2.Enabled = true;
            txt_a3.Enabled = true;
            txt_a4.Enabled = true;
            txt_a5.Enabled = true;
            /*thêmKháchHàngToolStripMenuItem.Enabled = false;
            xóaKháchHàngToolStripMenuItem.Enabled = false;
            sửaThôngTinKháchHàngToolStripMenuItem.Enabled = false;*/
        }

        private void xóaKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //them_xoa_sua(8);
            khachhang();
            type = 8;
            bth_XN.Text = "Xóa";
            bth_XN.Enabled = true;
            /*thêmKháchHàngToolStripMenuItem.Enabled = false;
            xóaKháchHàngToolStripMenuItem.Enabled = false;
            sửaThôngTinKháchHàngToolStripMenuItem.Enabled = false;*/
        }

        private void sửaThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //them_xoa_sua(9);
            khachhang();
            type = 9;
            bth_XN.Text = "Sửa";
            bth_XN.Enabled = true;
            txt_a2.Enabled = true;
            txt_a3.Enabled = true;
            txt_a4.Enabled = true;
            txt_a5.Enabled = true;
           /* thêmKháchHàngToolStripMenuItem.Enabled = false;
            xóaKháchHàngToolStripMenuItem.Enabled = false;
            sửaThôngTinKháchHàngToolStripMenuItem.Enabled = false;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_a1.Text.Equals("") || txt_a3.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu và tên khách hàng để tra!");
                return;
            }     
            int maphieu = int.Parse(txt_a1.Text);          
            chi_tiết_phiếu_cầm ctpc = new chi_tiết_phiếu_cầm();
            ctpc.str = maphieu;
            ctpc.ten = txt_a3.Text;
            ctpc.Vaitro = Vaitro;
            ctpc.trangthai_phieu = trangthai_phieu;
            this.Close();
            ctpc.Show();
        }

        private void tìmKiếmPhiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phiếu p = new Phiếu();
            p.Vaitro = Vaitro;
            this.Close();
            p.Show();
        }

        private void tìmKiếmMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìm_kiếm_mặt_hàng tkmh = new tìm_kiếm_mặt_hàng();
            tkmh.Vaitro = Vaitro;
            this.Close();
            tkmh.ShowDialog();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìm_kiếm_khách_hàng tkkh = new tìm_kiếm_khách_hàng();
            tkkh.Vaitro = Vaitro;
            this.Close();
            tkkh.Show();
        }

        private void kháchHàngViPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = 10;
            groupBox1.Visible = false;


            bth_XN.Text = "Thêm";

            bth_chitietphieu.Visible = false;
            btn_taophieuhen.Visible = false;
            btn_phieuthanhtoan.Visible = false;

            groupBox1.Visible = false;

            dgvtt.DataSource = bkh.getdanhsachkhachhangvipham(); //đổ dữ liệu vào datagridview
            dgvtt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvtt.Size = new Size(dgvtt.Size.Width, 588);

            txt_TimKiem.Text = "Số CMND";
            txt_TimKiem.ForeColor = Color.LightGray;

            lb_ngay.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.MinDate;
            int i;
            i = dgvtt.CurrentRow.Index;
            if (type <= 3)
            {
                txt_a1.Text = dgvtt.Rows[i].Cells[0].Value.ToString();
                txt_a2.Text = dgvtt.Rows[i].Cells[1].Value.ToString();
                txt_a3.Text = dgvtt.Rows[i].Cells[2].Value.ToString();
            }
            else if (type <= 6)
            {
                if (dgvtt.Rows[i].Cells[1].Value.ToString().Equals(""))
                    return;

                txt_a1.Text = dgvtt.Rows[i].Cells[0].Value.ToString();
                txt_a2.Text = "0.1";
                txt_a3.Text = dgvtt.Rows[i].Cells[4].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dgvtt.Rows[i].Cells[1].Value);
                dateTimePicker2.Value = Convert.ToDateTime(dgvtt.Rows[i].Cells[2].Value);
                trangthai_phieu = bool.Parse(dgvtt.Rows[i].Cells[5].Value.ToString());

                dateTimePicker2.MinDate = dateTimePicker1.Value;
            }
            else if (type <= 9)
            {
                txt_a1.Text = dgvtt.Rows[i].Cells[0].Value.ToString();
                txt_a2.Text = dgvtt.Rows[i].Cells[1].Value.ToString();
                txt_a3.Text = dgvtt.Rows[i].Cells[2].Value.ToString();
                txt_a4.Text = dgvtt.Rows[i].Cells[3].Value.ToString();
                txt_a5.Text = dgvtt.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void btn_taophieuhen_Click(object sender, EventArgs e)
        {
            if (txt_a1.Text.Equals("") || txt_a3.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu và tên khách hàng để tạo phiếu hẹn");
                return;
            }

            if (trangthai_phieu)
            {
                MessageBox.Show("Phiếu đã xuất");
                return;
            }

            dto_phieuthanhtoan dptt = new dto_phieuthanhtoan(0, DateTime.Now, int.Parse(txt_a1.Text), "0", "0", false);

            if (!bptt.check_ct_phieucamdo(dptt))
            {
                return;
            }

            Phieuhen ph = new Phieuhen();
            ph.tk = tk;
            ph.ten = ten;
            ph.Vaitro = Vaitro;
            ph.maphieu = int.Parse(txt_a1.Text);
            this.Close();
            ph.Show();
        }

        private void btn_phieuthanhtoan_Click(object sender, EventArgs e)
        {
            if (txt_a1.Text.Equals("") || txt_a3.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu và tên khách hàng để tạo phiếu thanhh toán");
                return;
            }

            if(trangthai_phieu)
            {
                MessageBox.Show("Phiếu đã xuất");
                return;
            }   

            dto_phieuthanhtoan dptt = new dto_phieuthanhtoan(0,DateTime.Now ,int.Parse(txt_a1.Text),"0","0",false);

            if(!bptt.check_ct_phieucamdo(dptt))
            {
                return;
            }

            string tong = bptt.tong(txt_a1.Text);

            string tienlai = bptt.tienlai(dptt);

            bptt.updatephieuthanhtoan(dptt, tienlai, tong);

            MessageBox.Show("Tạo phiếu thành công");

            PhieuThanhToan ptt = new PhieuThanhToan();

            ptt.maphieuthanhtoan = int.Parse(bptt.check_MaPhieuThanhToan(dptt));
            ptt.maphieu = int.Parse(txt_a1.Text);
            ptt.ten = ten;
            ptt.tk = tk;
            ptt.Vaitro = Vaitro;
            ptt.tong = tong;
            ptt.tienlai = tienlai;

            this.Close();
            ptt.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doanhthu dt = new Doanhthu();
            dt.Vaitro = Vaitro;
            this.Close();
            dt.Show();
        }

        private void btn_TìmKiem_Click(object sender, EventArgs e)
        {
            switch(type)
            {
                case 1: case 2: case 3:
                    {
                        dto_mathang dmh = new dto_mathang(0,txt_TimKiem.Text,0,false);

                        dgvtt.DataSource = bmh.getTimKiem_MH(dmh);
                    }break;
                case 4: case 5: case 6:
                    {
                        dto_khachhang dkh = new dto_khachhang(0, null, null, null, txt_TimKiem.Text, false);

                        dgvtt.DataSource = bcd.getTimKiem(dkh);
                    }
                    break;
                case 7: case 8: case 9:
                    {
                        dto_khachhang dkh = new dto_khachhang(0, null, null, null, txt_TimKiem.Text, false);

                        dgvtt.DataSource = bkh.getTimKiem_KH(dkh);
                    }
                    break;
                case 10:
                    {
                        dto_khachhang dkh = new dto_khachhang(0, null, null, null, txt_TimKiem.Text, false);

                        dgvtt.DataSource = bkh.getTimKiem_KHVP(dkh);
                    }
                    break;
            }    
        }

        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text.Equals("Số CMND") || txt_TimKiem.Text.Equals("Tên mặt hàng"))
            {
                txt_TimKiem.Text = null;
                txt_TimKiem.ForeColor = Color.Black;
            }
        }

        private void trang_chủ_Load(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = DateTime.Now;
            if(!Vaitro.Equals("Chủ tiệm"))
            {
                //thốngKêBáoCáoToolStripMenuItem.Visible = false;
                quảnLíNhânViênToolStripMenuItem.Visible = false;
            }
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanli_nhanvien qlnv = new Quanli_nhanvien();
            qlnv.Vaitro = Vaitro;
            this.Close();
            qlnv.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}