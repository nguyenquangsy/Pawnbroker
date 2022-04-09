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
    public partial class Phieuhen : Form
    {
        bus_phieuthanhtoan bptt = new bus_phieuthanhtoan();

        public int maphieu;

        public string tk;
        public string ten;

        public string Vaitro;

        public Phieuhen()
        {
            InitializeComponent();
        }

        private void Phieuhen_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();

            DataTable dt1 = new DataTable();
            dt1 = bptt.get_ttkh(maphieu.ToString());

            ReportParameter[] text = new ReportParameter[8];

            text[0] = new ReportParameter("ngay",DateTime.Now.Day.ToString());
            text[1] = new ReportParameter("thang", DateTime.Now.Month.ToString());
            text[2] = new ReportParameter("nam", DateTime.Now.Year.ToString());
            text[3] = new ReportParameter("tenkhachhang", dt1.Rows[0][0].ToString());
            text[4] = new ReportParameter("sdt", dt1.Rows[0][1].ToString());
            text[5] = new ReportParameter("cmnd", dt1.Rows[0][2].ToString());
            text[6] = new ReportParameter("diachi", dt1.Rows[0][3].ToString());
            text[7] = new ReportParameter("sotien", bptt.tong(maphieu.ToString()));

            //this.reportViewer1.LocalReport.ReportPath = "../../Report2.rdlc";
            this.reportViewer1.LocalReport.SetParameters(text);

            DataTable dt = new DataTable();
            dt = bptt.get_Phieuhen(maphieu.ToString());

            ReportDataSource rprtDTSource = new ReportDataSource("DataSet1", dt);

            this.reportViewer1.LocalReport.DataSources.Add(rprtDTSource);
            this.reportViewer1.RefreshReport();
        }

        private void Phieuhen_FormClosed(object sender, FormClosedEventArgs e)
        {
            trang_chủ tc = new trang_chủ();

            tc.tk = tk;
            tc.ten = ten;
            tc.Vaitro = Vaitro;

            tc.Show();
        }
    }
}
