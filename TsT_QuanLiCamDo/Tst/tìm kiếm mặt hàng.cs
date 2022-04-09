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
    public partial class tìm_kiếm_mặt_hàng : Form
    {
        public string Vaitro;

        bus_mathang bmh = new bus_mathang();

        public tìm_kiếm_mặt_hàng()
        {
            InitializeComponent();
            dataGridView1.DataSource = bmh.getdanhsachtimkiem(); //đổ dữ liệu vào datagridview
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ControlBox = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            trang_chủ tc = new trang_chủ();
            tc.Vaitro = Vaitro;
            this.Close();
            tc.Show();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            dto_mathang dmh = new dto_mathang(0,txt_tenmathang.Text,0,false);

            dataGridView1.DataSource = bmh.gettimkiem(dmh); //đổ dữ liệu vào datagridview
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tìm_kiếm_mặt_hàng_Load(object sender, EventArgs e)
        {
            
        }
    }
}
