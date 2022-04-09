using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QUANLI;
using DTO_QUANLI;

namespace Tst
{
    public partial class Quanli_nhanvien : Form
    {
        bus_dangnhap_dangky bdndk = new bus_dangnhap_dangky();

        public string Vaitro;

        public Quanli_nhanvien()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            trang_chủ tc = new trang_chủ();
            tc.Vaitro = Vaitro;
            this.Close();
            tc.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            dto_taikhoan dtk = new dto_taikhoan(txt_TenTaiKhoan.Text, null, null, null, null);

            bdndk.del_NhanVien(dtk);

            dtgv.DataSource = bdndk.getNhanVien();
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1)
                return;
            txt_HoTen.Text = dtgv.Rows[i].Cells[0].Value.ToString();
            txt_MatKhau.Text = dtgv.Rows[i].Cells[1].Value.ToString();
            txt_TenTaiKhoan.Text = dtgv.Rows[i].Cells[2].Value.ToString();
        }

        private void Quanli_nhanvien_Load(object sender, EventArgs e)
        {
            dtgv.DataSource = bdndk.getNhanVien();
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
