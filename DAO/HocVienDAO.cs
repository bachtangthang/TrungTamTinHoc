using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HocVienDAO
    {
        private static HocVienDAO instance; 

        public static HocVienDAO Instance { get { if (instance == null) instance = new HocVienDAO(); return instance; } }

        private HocVienDAO() { }

        public List<DTO.HocVien> Xem()
        {
            List<DTO.HocVien> hocvien = new List<DTO.HocVien>() ;
            string query = "select * from HOCVIEN";
            DataTable data = DataProvider.Instance.ExecuxeQuery(query);

            foreach (DataRow item in data.Rows)
            {

            }    
            return hocvien;
        }

        public int check_ID(int id)
        {
            string query = "select count (*) from HOCVIEN where HOCVIEN.ID = "+id+"  ";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
        }

        public DataTable timkiemHV(int id)
        {
            string query = "select * from HOCVIEN where HOCVIEN.ID = "+id+" ";
            DataTable data = DataProvider.Instance.ExecuxeQuery(query);
            return data;
        }
        public int ThemHV(HocVien hv)
        {
            string query = "insert into HOCVIEN (ID, HoTen, SDT, GioiTinh, NgaySinh) values ("+hv.Id+", '"+hv.Hoten+"', '"+hv.Sdt+"', '"+hv.Sex+"', '"+hv.Ngaysinh+"');";//query them hocvien
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
