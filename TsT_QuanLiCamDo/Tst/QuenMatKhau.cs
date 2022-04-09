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
    public partial class QuenMatKhau : Form
    {
        bus_dangnhap_dangky bdndk = new bus_dangnhap_dangky();

        public QuenMatKhau()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void btn_ktra_Click(object sender, EventArgs e)
        {
            dto_taikhoan dtk = new dto_taikhoan(txt_user.Text,null,txt_codeHD.Text,null,null);
            if(bdndk.checktaikhoan(dtk))
            {
                txt_mk.Enabled = true;
                txt_mkpre.Enabled = true;
                btn_xacnhan.Enabled = true;
                txt_user.Enabled = false;
                txt_codeHD.Enabled = false;
                btn_ktra.Enabled = false;
                pb_inf.BackgroundImage = Properties.Resources._true;
                return;
            }
            pb_inf.BackgroundImage = Properties.Resources._false;
            return;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            dto_taikhoan dtk = new dto_taikhoan(txt_user.Text, txt_mk.Text, null, null, null);

            if(bdndk.update_matkhau(dtk,txt_mkpre.Text))
            {
                this.Close();
                Form1 f = new Form1();
                f.Show();
            }    
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
