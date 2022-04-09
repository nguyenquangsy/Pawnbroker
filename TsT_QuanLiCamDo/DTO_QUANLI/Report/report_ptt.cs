using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLI
{
    public class report_ptt
    {
        string tenmathang;
        int soluong;
        float tiencam;

        public string Tenmathang { get => tenmathang; set => tenmathang = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Tiencam { get => tiencam; set => tiencam = value; }

        public report_ptt()
        {

        }

        public report_ptt(string ptt_tenmathang, int ptt_soluong, float pt_tiencam)
        {
            this.Tenmathang = ptt_tenmathang;
            this.Soluong = ptt_soluong;
            this.Tiencam = pt_tiencam;
        }
    }
}
