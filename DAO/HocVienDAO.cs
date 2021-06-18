using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string query = "select count * from HOCVIEN where HOCVIEN.ID = "+id+"  ";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
