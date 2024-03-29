﻿using System;
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
        private int soluong;
        private int soluongtoida;

        public int Id_LopChuyenDe { get => id_LopChuyenDe; set => id_LopChuyenDe = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public int Id_ChuyenDeMo { get => id_ChuyenDeMo; set => id_ChuyenDeMo = value; }
        public int Id_GiaoVien { get => id_GiaoVien; set => id_GiaoVien = value; }
        public int HocKy { get => hocKy; set => hocKy = value; }
        public int Nam { get => nam; set => nam = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Soluongtoida { get => soluongtoida; set => soluongtoida = value; }

        public LopChuyenDe(int id_lop, string ten, int id_cd, int id_gv, int hocky, int nam, int soluong, int soluongtoida)
        {
            this.id_LopChuyenDe = id_lop;
            this.tenLop = ten;
            this.Id_ChuyenDeMo = id_cd;
            this.id_GiaoVien = id_gv;
            this.hocKy = hocky;
            this.nam = nam;
            this.soluong = soluong;
            this.soluongtoida = soluongtoida;
        }

        public LopChuyenDe(int id_lop, string ten, int id_cd, int id_gv, int hocky, int nam, int soluongtoida)
        {
            this.id_LopChuyenDe = id_lop;
            this.tenLop = ten;
            this.id_ChuyenDeMo = id_cd;
            this.id_GiaoVien = id_gv;
            this.hocKy = hocky;
            this.nam = nam;
            this.soluong = 0;
            this.soluongtoida = soluongtoida;
        }
    }
}
