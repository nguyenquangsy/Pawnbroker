using Microsoft.Reporting.WinForms;
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
    public partial class PhieuThanhToan : Form
    {
        public int maphieuthanhtoan;
        public int maphieu;

        public string tk;
        public string ten;

        public string tienlai;
        public string tong;

        public string Vaitro;

        bus_phieuthanhtoan bptt = new bus_phieuthanhtoan();

        public PhieuThanhToan()
        {
            InitializeComponent();
        //    this.ControlBox = false;
        }

        private void PhieuThanhToan_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();

            DataTable dt1 = new DataTable();
            dt1 = bptt.get_ttkh(maphieu.ToString());

            ReportParameter[] text = new ReportParameter[8];
            //(int.Parse(tienlai) + int.Parse(tong)).ToString()
            text[0] = new ReportParameter("ma_ptt", maphieuthanhtoan.ToString());
            text[1] = new ReportParameter("ngaythanhtoan", DateTime.Now.ToString());
            text[2] = new ReportParameter("tenkhachhang", dt1.Rows[0][0].ToString());
            text[3] = new ReportParameter("sdt", dt1.Rows[0][1].ToString());
            text[4] = new ReportParameter("cmnd", dt1.Rows[0][2].ToString());
            text[5] = new ReportParameter("diachi", dt1.Rows[0][3].ToString());
            text[6] = new ReportParameter("tienlai",tienlai);
            text[7] = new ReportParameter("tongtienthanhtoan",(float.Parse(tienlai) + float.Parse(tong)).ToString());

            //this.reportViewer1.LocalReport.ReportPath = "../../Report1.rdlc";
            this.reportViewer1.LocalReport.SetParameters(text);

            DataTable dt = new DataTable();
            dt = bptt.get_PhieuThanhToan(maphieuthanhtoan.ToString());

            ReportDataSource rprtDTSource = new ReportDataSource("DataSet1" ,dt);

            this.reportViewer1.LocalReport.DataSources.Add(rprtDTSource);
            this.reportViewer1.RefreshReport();
        }

        private void PhieuThanhToan_FormClosed(object sender, FormClosedEventArgs e)
        {
            trang_chủ tc = new trang_chủ();
            tc.ten = ten;
            tc.tk = tk;
            tc.Vaitro = Vaitro;
            //this.Close();
            tc.Show();
        }
    }
}
