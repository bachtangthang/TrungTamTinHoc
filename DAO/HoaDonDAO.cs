using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance { get { if (instance == null) instance = new HoaDonDAO(); return instance; } }

        private HoaDonDAO() { }

        public int themHD(HoaDon hd)
        {
            string query = "insert into HOADON (NguoiThucHien, ID_HocVien, TongTien)values ("+hd.NguoiThucHien+", "+hd.Id_Hv+", "+hd.TongTien+"); ";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
