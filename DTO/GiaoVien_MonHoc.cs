using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVien_MonHoc
    {
        private int id_GiaoVien;
        private int id_MonHoc;

        public int Id_GiaoVien { get => id_GiaoVien; set => id_GiaoVien = value; }
        public int Id_MonHoc { get => id_MonHoc; set => id_MonHoc = value; }

        public GiaoVien_MonHoc(int gv, int mh)
        {
            this.id_GiaoVien = gv;
            this.id_MonHoc = mh;
        }
    }
}
