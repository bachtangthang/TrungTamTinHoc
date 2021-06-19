using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHocPhan
    {
        private int id_Lop;
        private string tenLop;
        private int id_MH;
        private int id_GV;
        private int hocky;
        private int nam;
        private int soluong;
        private int soluongtoida;

        public int Id_Lop { get => id_Lop; set => id_Lop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public int Id_MH { get => id_MH; set => id_MH = value; }
        public int Id_GV { get => id_GV; set => id_GV = value; }
        public int Hocky { get => hocky; set => hocky = value; }
        public int Nam { get => nam; set => nam = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Soluongtoida { get => soluongtoida; set => soluongtoida = value; }

        public LopHocPhan(int id_lop, string ten, int id_cd, int id_gv, int hocky, int nam, int soluong, int soluongtoida)
        {
            this.id_Lop = id_lop;
            this.tenLop = ten;
            this.id_MH = id_cd;
            this.id_GV = id_gv;
            this.hocky = hocky;
            this.nam = nam;
            this.soluong = soluong;
            this.soluongtoida = soluongtoida;
        }
    }
}
