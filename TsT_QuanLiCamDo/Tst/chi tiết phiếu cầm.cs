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
    public partial class chi_tiết_phiếu_cầm : Form
    {
        public int str;
        public string ten;
        public string Vaitro;
        int type;
        public bool trangthai_phieu = false;

        bus_ct_phieucamdo bctpcd = new bus_ct_phieucamdo();

        public chi_tiết_phiếu_cầm()
        {
            InitializeComponent();
            lb_name.Text = "Mã phiếu: " + str;
            txt_tenkhachhang.Text = ten;

            dto_ct_phieucamdo dctpcd = new dto_ct_phieucamdo(0, str, 0, null,false);

            bctpcd.getctphieucamdo(dctpcd);
            this.ControlBox = false;

            if(trangthai_phieu)
            {
                bth_them.Enabled = false;
                bth_xoa.Enabled = false;
                bth_sua.Enabled = false;
            }    
        }

        private void ht_them_Click(object sender, EventArgs e)
        {
            type = 1;
            bth_them.BackColor = Color.Red;
            bth_xoa.BackColor = Color.White;
            bth_sua.BackColor = Color.White;
            cbb_TenMatHang.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trang_chủ tc = new trang_chủ();
            tc.Vaitro = Vaitro;
            this.Close();
            tc.Show();
        }

        private void bth_xoa_Click(object sender, EventArgs e)
        {
            type = 2;
            bth_them.BackColor = Color.White;
            bth_xoa.BackColor = Color.Red;
            bth_sua.BackColor = Color.White;
            cbb_TenMatHang.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bth_sua_Click(object sender, EventArgs e)
        {
            type = 3;
            bth_them.BackColor = Color.White;
            bth_xoa.BackColor = Color.White;
            bth_sua.BackColor = Color.Red;
            cbb_TenMatHang.Enabled = false;
        }

        private void bht_ok_Click(object sender, EventArgs e)
        {
            switch(type)
            {
                case 1:
                    {
                        dto_ct_phieucamdo dctpcd = new dto_ct_phieucamdo(0, str, int.Parse(txt_soluong.Text), txt_tiencam.Text,false);
                        dto_mathang dmh = new dto_mathang(0, cbb_TenMatHang.Text,0,false);

                        bctpcd.themctphieu(dctpcd, dmh);
                        dataGridView1.DataSource = bctpcd.getctphieucamdo(dctpcd);
                    }
                    break;
                case 2:
                    {
                        dto_ct_phieucamdo dctpcd = new dto_ct_phieucamdo(0, str, int.Parse(txt_soluong.Text), txt_tiencam.Text,false);
                        dto_mathang dmh = new dto_mathang(0, cbb_TenMatHang.Text, 0,false);

                        bctpcd.xoactphieu(dctpcd, dmh);
                        dataGridView1.DataSource = bctpcd.getctphieucamdo(dctpcd);
                    }
                    break;
                case 3:
                    {
                        dto_ct_phieucamdo dctpcd = new dto_ct_phieucamdo(0, str, int.Parse(txt_soluong.Text), txt_tiencam.Text,false);
                        dto_mathang dmh = new dto_mathang(0, cbb_TenMatHang.Text, 0,false);

                        bctpcd.suactphieu(dctpcd, dmh);
                        dataGridView1.DataSource = bctpcd.getctphieucamdo(dctpcd);
                    }
                    break;
            }
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void chi_tiết_phiếu_cầm_Load(object sender, EventArgs e)
        {
            lb_name.Text = "Mã phiếu: " + str;
            txt_tenkhachhang.Text = ten;

            dto_ct_phieucamdo dctpcd = new dto_ct_phieucamdo(0, str, 0, null,false);

            dataGridView1.DataSource = bctpcd.getctphieucamdo(dctpcd);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ControlBox = false;

            if (trangthai_phieu)
            {
                bth_them.Enabled = false;
                bth_xoa.Enabled = false;
                bth_sua.Enabled = false;
            }

            if (!trangthai_phieu)
            {
                cbb_TenMatHang.DataSource = bctpcd.getmathang();
                cbb_TenMatHang.DisplayMember = "TENMATHANG";
                cbb_TenMatHang.ValueMember = "TENMATHANG";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_tenkhachhang.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cbb_TenMatHang.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_soluong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_tiencam.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_tiencam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
