using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class HocVienDAO
    {
        private static HocVienDAO instance; 

        public static HocVienDAO Instance { get { if (instance == null) instance = new HocVienDAO(); return instance; } }

        private HocVienDAO() { }

        public List<DTO.HocVien> Xem()
        {
            List<DTO.HocVien> hocvien = new List<DTO.HocVien>() ;
            return hocvien;
        }
    }
}
