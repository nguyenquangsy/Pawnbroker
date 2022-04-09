using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QUANLI
{
    public class dal_kiemtra :Connection
    {
        public bool check_con()
        {
            return Open_Sql();
        }
    }
}
