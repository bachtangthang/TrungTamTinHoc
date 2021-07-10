using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAO
{
    public class HocVien_LichThiDAO
    {
        private static HocVien_LichThiDAO instance;

        public static HocVien_LichThiDAO Instance { get { if (instance == null) instance = new HocVien_LichThiDAO(); return instance; } }

        private HocVien_LichThiDAO() { }

        public int DangKy(HocVien_LichThi hv)//Đăng ký thi lại
        {
            string query = "Insert into HOCVIEN_LICHTHI (ID_HocVien, ID_LichThi, ngayDK) values (" + hv.Id_hv + ", "+hv.Id_lt+ ", GETDATE())";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int KiemTraDKLichThi(int idHV, int idLT)//Kiểm tra học viên đã đk lịch thi chưa
        {
            string query = "select count (*) from HOCVIEN_LICHTHI where ID_HocVien = " + idHV + " and ID_LichThi = " + idLT + ";";
            return Convert.ToInt32(DAO.DataProvider.Instance.ExecuteScalar(query));
        }
    }
}
