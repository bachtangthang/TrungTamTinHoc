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
    public class ChiTietHoaDonChuyenDeBUS
    {
        private static ChiTietHoaDonChuyenDeBUS instance;

        public static ChiTietHoaDonChuyenDeBUS Instance { get { if (instance == null) instance = new ChiTietHoaDonChuyenDeBUS(); return instance; } }

        private ChiTietHoaDonChuyenDeBUS() { }

        public int themCTHD(int mh, int hd, float tien)
        {
            ChiTietHoaDonChuyenDe cthd = new ChiTietHoaDonChuyenDe(mh, hd, tien);
            return DAO.ChiTietHoaDonChuyenDeDAO.Instance.ThemCTHD(cthd);
        }
    }
}
