using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ChiTietHoaDonChuyenDeDAO
    {
        private static ChiTietHoaDonChuyenDeDAO instance;

        public static ChiTietHoaDonChuyenDeDAO Instance { get { if (instance == null) instance = new ChiTietHoaDonChuyenDeDAO(); return instance; } }

        private ChiTietHoaDonChuyenDeDAO() { }

        public int ThemCTHD(ChiTietHoaDonChuyenDe cthd)
        {
            string query = "insert into CHITIETHOADONCHUYENDE values (" + cthd.Id_HD + ", " + cthd.Id_MH + ", " + cthd.Giatien + "); ";
            return DAO.DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}