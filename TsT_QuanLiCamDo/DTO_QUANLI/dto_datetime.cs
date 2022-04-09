using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLI
{
    public class dto_datetime
    {
        string ngay;
        string thang;
        string nam;

        public dto_datetime()
        {

        }

        public dto_datetime(string dt_ngay, string dt_thang, string dt_nam)
        {
            this.Ngay = dt_ngay;
            this.Thang = dt_thang;
            this.Nam = dt_nam;
        }

        public string Ngay { get => ngay; set => ngay = value; }
        public string Thang { get => thang; set => thang = value; }
        public string Nam { get => nam; set => nam = value; }
    }
}
