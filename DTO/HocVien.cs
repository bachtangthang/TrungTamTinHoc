using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocVien
    {
        private int id;
        private string hoten;
        private string sdt;
        private string sex;
        private DateTime ngaysinh;

        public int Id { get => id; set => id = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }

        public HocVien(int id, string name, string sdt, string sex, DateTime dob)
        {
            this.id = id;
            this.hoten = name;
            this.sdt = sdt;
            this.sex = sex;
            this.ngaysinh = dob;
        }

        public HocVien()
        {

        }
    }
}
