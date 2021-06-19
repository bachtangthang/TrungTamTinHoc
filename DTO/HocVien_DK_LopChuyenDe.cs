using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocVien_DK_LopChuyenDe
    {
        private int id_HV;
        private int id_Lop;
        private bool is_Pass;
        private int diem;

        public int Id_HV { get => id_HV; set => id_HV = value; }
        public int Id_Lop { get => id_Lop; set => id_Lop = value; }
        public bool Is_Pass { get => is_Pass; set => is_Pass = value; }
        public int Diem { get => diem; set => diem = value; }

        public HocVien_DK_LopChuyenDe(int hv, int lop, bool ispass, int diem)
        {
            this.id_HV = hv;
            this.id_Lop = lop;
            this.is_Pass = ispass;
            this.diem = diem;
        }

        public HocVien_DK_LopChuyenDe(int hv, int lop)
        {
            this.id_HV = hv;
            this.id_Lop = lop;
        }
    }
}
