using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDung
    {
        private string userName;
        private string pass;
        private string loai;
        private int id;

        public string UserName { get => userName; set => userName = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Loai { get => loai; set => loai = value; }
        public int Id { get => id; set => id = value; }

        public NguoiDung(string ten, string mk, string loai, int id)
        {
            this.userName = ten;
            this.pass = mk;
            this.loai = loai;
            this.id = id;
        }
                
     }

}

