using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private int id_MH;
        private int id_HD;
        private float giatien;

        public int Id_MH { get => id_MH; set => id_MH = value; }
        public int Id_HD { get => id_HD; set => id_HD = value; }
        public float Giatien { get => giatien; set => giatien = value; }

        public ChiTietHoaDon(int mh, int hd, float tien)
        {
            this.id_MH = mh;
            this.id_HD = hd;
            this.giatien = tien;
        }
        public ChiTietHoaDon() { }
    }
}
