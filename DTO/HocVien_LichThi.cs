using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocVien_LichThi
    {
        private int id_hv;
        private int id_lt;
        private DateTime ngaydk;
        private int diem;

        public int Id_hv { get => id_hv; set => id_hv = value; }
        public int Id_lt { get => id_lt; set => id_lt = value; }
        public DateTime Ngaydk { get => ngaydk; set => ngaydk = value; }
        public int Diem { get => diem; set => diem = value; }

        public HocVien_LichThi(int id_hv, int id_lt, DateTime ngaydk, int diem)
        {
            this.id_hv = id_hv;
            this.id_lt = id_lt;
            this.ngaydk = ngaydk;
            this.diem = diem;
        }

        public HocVien_LichThi(int id_hv, int id_lt)
        {
            this.id_hv = id_hv;
            this.id_lt = id_lt;
            this.ngaydk = DateTime.Now.Date;
        }
    }
}
