using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        public static ChiTietHoaDonDAO Instance { get { if (instance == null) instance = new ChiTietHoaDonDAO(); return instance; } }

        private ChiTietHoaDonDAO() { }

        public int ThemCTHD(ChiTietHoaDon cthd)
        {
            string query = "insert into CHITIETHOADON values (" + cthd.Id_MH + ", " + cthd.Id_HD + ", " + cthd.Giatien + "); ";
            return DAO.DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
