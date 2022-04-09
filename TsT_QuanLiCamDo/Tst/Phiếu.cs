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
    public partial class Phiếu : Form
    {
        public string Vaitro;
        bus_camdo bcd = new bus_camdo();

        public Phiếu()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btn_phieuquahan_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bcd.getphieugiahan();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
        }

        private void btn_phieudangcam_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bcd.getphieudangcam();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_phieudatra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bcd.getphieudatra();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            trang_chủ tc = new trang_chủ();
            tc.Vaitro = Vaitro;
            this.Close();
            tc.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
