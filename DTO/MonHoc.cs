using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc
    {
        private int id;
        private float hocphi;
        private string mota;
        private string ten;
        private int id_HP;

        public int Id { get => id; set => id = value; }
        public float Hocphi { get => hocphi; set => hocphi = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Mota { get => mota; set => mota = value; }
        public int Id_HP { get => id_HP; set => id_HP = value; }

        public MonHoc(int id, string ten, float hocphi, string mota, int id_hp)
        {
            this.id = id;
            this.ten = ten;
            this.hocphi = hocphi;
            this.mota = mota;
            this.id_HP = id_hp;
        }
    }
}
