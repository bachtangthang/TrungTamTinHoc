using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HocVien_DK_LopHocPhanDAO
    {
        private static HocVien_DK_LopHocPhanDAO instance;

        public static HocVien_DK_LopHocPhanDAO Instance { get { if (instance == null) instance = new HocVien_DK_LopHocPhanDAO(); return instance; } }

        private HocVien_DK_LopHocPhanDAO() { }

        public int dangky(HocVien_DK_LopHocPhan dk)
        {
            string query = "insert into HOCVIEN_DANGKY_LOPHOCPHAN (ID_HocVien, ID_Lop) values ("+dk.Id_HV+", "+dk.Id_Lop+");";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public List<HocVien> LoadLop(int id)
        {
            List<HocVien> listHV = new List<HocVien> ();
            string query = "select ID_HocVien, HoTen, SDT, GioiTinh, NgaySinh from HOCVIEN_DANGKY_LOPHOCPHAN, HOCVIEN where HOCVIEN_DANGKY_LOPHOCPHAN.ID_Lop = " + id+ " and HOCVIEN_DANGKY_LOPHOCPHAN.ID_HocVien = HOCVIEN.ID";
            DataTable data = DataProvider.Instance.ExecuxeQuery(query);

            foreach (DataRow item in data.Rows)
            {
                int id_hv = Convert.ToInt32(item["ID_HocVien"]);
                string hoten = item["HoTen"].ToString();
                string sdt = item["SDT"].ToString();
                string sex = item["GioiTinh"].ToString();
                DateTime dob = (DateTime)item["NgaySinh"];

                HocVien newHV = new HocVien(id_hv, hoten, sdt, sex, dob);

                listHV.Add(newHV);
            }    
            return listHV;
        }
    }
}
