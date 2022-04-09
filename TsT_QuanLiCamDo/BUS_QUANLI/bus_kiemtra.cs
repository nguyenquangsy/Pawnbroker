using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QUANLI;

namespace BUS_QUANLI
{
    public class bus_kiemtra
    {
        dal_kiemtra dkt = new dal_kiemtra();

        public bool check_con()
        {
            return dkt.check_con();
        }
    }
}
