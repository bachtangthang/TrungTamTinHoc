using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopChuyenDe
    {
        private int id_LopChuyenDe;
        private string tenLop;
        private int id_ChuyenDeMo;
        private int id_GiaoVien;
        private int hocKy;
        private int nam;

        public int Id_LopChuyenDe { get => id_LopChuyenDe; set => id_LopChuyenDe = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public int Id_ChuyenDeMo { get => id_ChuyenDeMo; set => id_ChuyenDeMo = value; }
        public int Id_GiaoVien { get => id_GiaoVien; set => id_GiaoVien = value; }
        public int HocKy { get => hocKy; set => hocKy = value; }
        public int Nam { get => nam; set => nam = value; }

        public LopChuyenDe(int id_lop, string ten, int id_cd, int id_gv, int hocky, int nam)
        {
            this.id_LopChuyenDe = id_lop;
            this.tenLop = ten;
            this.Id_ChuyenDeMo = id_cd;
            this.id_GiaoVien = id_gv;
            this.hocKy = hocky;
            this.nam = nam;
        }
    }
}
