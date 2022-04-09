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
    public partial class tìm_kiếm_khách_hàng : Form
    {
        public string Vaitro;

        bus_khachhang bkh = new bus_khachhang();

        public tìm_kiếm_khách_hàng()
        {
            InitializeComponent();
            dataGridView1.DataSource = bkh.getdanhsachtimkiem(); //đổ dữ liệu vào datagridview
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            dto_khachhang dkh = new dto_khachhang(0,null,null,null, txt_timkiem.Text, false);

            dataGridView1.DataSource = bkh.gettimkiem(dkh); //đổ dữ liệu vào datagridview
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
