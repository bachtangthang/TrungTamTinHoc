using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuyenDe
    {
        private int id;
        private string ten;
        private float gia;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public float Gia { get => gia; set => gia = value; }

        public ChuyenDe(int id, string ten, float gia)
        {
            this.id = id;
            this.ten = ten;
            this.gia = gia;
        }
    }
}
