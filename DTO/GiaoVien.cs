using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVien
    {
        private int id_gv;
        private string hoten;
        private string sdt;
        private DateTime dob;
        private string sex;

        public int Id_gv { get => id_gv; set => id_gv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Sex { get => sex; set => sex = value; }

        public GiaoVien(int gv, string ten, string sdt, DateTime dob, string sex)
        {
            this.id_gv = gv;
            this.hoten = ten;
            this.sdt = sdt;
            this.dob = dob;
            this.sex = sex;
        }
    }
}
