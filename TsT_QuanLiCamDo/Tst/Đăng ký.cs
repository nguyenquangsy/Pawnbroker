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
using BUS_QUANLI;
using DTO_QUANLI;

namespace Tst
{
    public partial class Đăng_ký : Form
    {
        bus_dangnhap_dangky bdndk = new bus_dangnhap_dangky();
        bus_kiemtra bkt = new bus_kiemtra();

        public Đăng_ký()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            if (!bkt.check_con())
            {
                return;
            }

            if (txt_user.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");

                return;
            }
            if (txt_pass.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            if(txt_xn_pass.Equals(""))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu!");
                return;
            }    
            if(!txt_pass.Text.Equals(txt_xn_pass.Text))
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng!");
                return;
            }

            if (txt_HoTen.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!");
                return;
            }

            if (cb_VaiTro.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn vai trò của bạn!");
                return;
            }


            dto_taikhoan dtl = new dto_taikhoan(txt_user.Text, txt_pass.Text, "74156" ,txt_HoTen.Text,cb_VaiTro.Text);

            if(bdndk.them(dtl))
            {
                MessageBox.Show("Thêm thành công");
                Form1 dn = new Form1();
                this.Close();
                dn.Show();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 dn = new Form1();
            this.Close();
            dn.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = !txt_pass.UseSystemPasswordChar;
            txt_xn_pass.UseSystemPasswordChar = !txt_xn_pass.UseSystemPasswordChar;
        }

        private void btn_NhapMaDangKy_Click(object sender, EventArgs e)
        {
            if(bdndk.checkdangky())
            {
                txt_user.Enabled = true;
                txt_pass.Enabled = true;
                txt_xn_pass.Enabled = true;
                btn_DangKy.Enabled = true;
                //button1.Enabled = false;
                txt_HoTen.Enabled = true;
                cb_VaiTro.Enabled = true;
                ckbShowPassword.Enabled = true;
            }    
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Mật khẩu")
            {
                txt_pass.Text = null;
                txt_pass.ForeColor = Color.Black;
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_xn_pass_Enter(object sender, EventArgs e)
        {
            if (txt_xn_pass.Text == "Nhập lại mật khẩu")
            {
                txt_xn_pass.Text = null;
                txt_xn_pass.ForeColor = Color.Black;
                txt_xn_pass.UseSystemPasswordChar = true;
            }
        }
        private void txt_user_Enter(object sender, EventArgs e)
        {

            if (txt_user.Text == "Nhập tên tài khoản")
            {
                txt_user.Text = null;
                txt_user.ForeColor = Color.Black;            
            }

            
        }
        private void txt_HoTen_Enter(object sender, EventArgs e)
        {
            if (txt_HoTen.Text == "Nhập họ và tên")
            {
                txt_HoTen.Text = null;
                txt_HoTen.ForeColor = Color.Black;
               
            }
        }

        private void txt_xn_pass_TextChanged(object sender, EventArgs e)
        {
            if(txt_pass.Text == txt_xn_pass.Text)
            {
                pb_check.BackgroundImage = Properties.Resources._true;
            }
            else
            {
                pb_check.BackgroundImage = Properties.Resources._false;
            }
        }

        private void txt_xn_pass_Leave(object sender, EventArgs e)
        {
            /*if (txt_pass.Text == txt_xn_pass.Text)
            {
                pb_check.BackgroundImage = Properties.Resources._true;
            }
            else
            {
                pb_check.BackgroundImage = Properties.Resources._false;
            }*/
        }
    }
}
