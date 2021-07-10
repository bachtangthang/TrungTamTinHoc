using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichThi
    {
        private int id_LichThi;
        private string phong;
        private string thoigian;
        private int id_lop;
        private DateTime ngay;

        public int Id { get => id_LichThi; set => id_LichThi = value; }
        public string Phong { get => phong; set => phong = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
        public int Id_lop { get => id_lop; set => id_lop = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }

        public LichThi(int id, string phong, string tg, int id_lop, DateTime day)
        {
            this.id_LichThi = id;
            this.phong = phong;
            this.thoigian = tg;
            this.id_lop = id_lop;
            this.ngay = day;
        }
    }
}
