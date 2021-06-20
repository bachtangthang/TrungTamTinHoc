using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class HocVien_LichThiBUS
    {
        private static HocVien_LichThiBUS instance;

        public static HocVien_LichThiBUS Instance { get { if (instance == null) instance = new HocVien_LichThiBUS(); return instance; } }

        private HocVien_LichThiBUS() { }
        
        public int DangKy(int id_hv, int id_lt)
        {
            HocVien_LichThi hv = new HocVien_LichThi(id_hv, id_lt);
            return DAO.HocVien_LichThiDAO.Instance.DangKy(hv);
        }
    }
}
