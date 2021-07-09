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
    public class ChiTietHoaDonBUS
    {
        private static ChiTietHoaDonBUS instance;

        public static ChiTietHoaDonBUS Instance { get { if (instance == null) instance = new ChiTietHoaDonBUS(); return instance; } }

        private ChiTietHoaDonBUS() { }

        public int themCTHD(int mh, int hd, float tien)
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon(mh, hd, tien);
            return DAO.ChiTietHoaDonDAO.Instance.ThemCTHD(cthd);
        }
    }
}
