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
using System.Data.SqlClient;

namespace Tst
{
    public partial class Form1 : Form
    {
        bus_dangnhap_dangky bdndk = new bus_dangnhap_dangky();
        bus_kiemtra bkt = new bus_kiemtra();

        public int a;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Đăng_ký dk = new Đăng_ký();
            this.Hide();
            dk.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dto_taikhoan dtk = new dto_taikhoan(user.Text, pass.Text, null, null, null);

            if (!bkt.check_con())
            {
                return;
            }

            if (bdndk.check(dtk))
            {
                trang_chủ tc = new trang_chủ();
                tc.tk = user.Text;
                dtk = new dto_taikhoan(user.Text, null, null, null, null);

                tc.Vaitro = bdndk.getVaiTro_TK(dtk);
                this.Hide();
                tc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu của bạn bị sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = !pass.UseSystemPasswordChar;

            if (!pass.UseSystemPasswordChar)
            {
                lb_show.Image = Properties.Resources.show;
            }
            else
            {
                lb_show.Image = Properties.Resources.chrome_GEENzwCl0P;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lb_QuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuenMatKhau qmk = new QuenMatKhau();
            qmk.Show();
        }
    }
}
