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
using DTO_QUANLI;
using BUS_QUANLI;

namespace Tst
{
    public partial class Thay_đổi_mật_khảu : Form
    {
        bus_dangnhap_dangky bddndk = new bus_dangnhap_dangky();

        public string tk;
        public string Vaitro;

        public Thay_đổi_mật_khảu()
        {
            InitializeComponent();
            this.ControlBox = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            trang_chủ tc = new trang_chủ();
            tc.Vaitro = Vaitro;
            this.Close();
            tc.Show();
        }

        private void btn_xn_Click(object sender, EventArgs e)
        {
            if(txt_old_pass.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu củ");
                return;
            }    

            if(txt_new_pass.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập khẩu mới");
                return;
            }    

            if(txt_confirm_pass.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu mới");
                return;
            }    

            dto_taikhoan dtk = new dto_taikhoan(tk, txt_new_pass.Text, null,null,null);

            if (bddndk.thaydoimatkhau(dtk, txt_confirm_pass.Text, txt_old_pass.Text))
            {
                trang_chủ tc = new trang_chủ();
                tc.Vaitro = Vaitro;
                this.Close();
                tc.Show();
            }
        }

        private void Thay_đổi_mật_khảu_Load(object sender, EventArgs e)
        {

        }
    }
}
