using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVien_ChuyenDe
    {
        private int idGV;
        private int idCD;

        public int IdGV { get => idGV; set => idGV = value; }
        public int IdCD { get => idCD; set => idCD = value; }

        public GiaoVien_ChuyenDe(int gv, int cd)
        {
            this.idGV = gv;
            this.idCD = cd;
        }
    }
}
