 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL_QUANLI
{
    public class Connection
    {
        //protected SqlConnection connectionString = new SqlConnection(@"Data Source=192.168.43.26;Initial Catalog=QLCD;User ID=sa;password=1");

        protected SqlConnection connectionString = new SqlConnection(@"Data Source=.;Initial Catalog=QLCD;Integrated Security=True");

        protected bool Open_Sql()
        {
            try
            {
                connectionString.Open();
                connectionString.Close();
                return true;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối với server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}