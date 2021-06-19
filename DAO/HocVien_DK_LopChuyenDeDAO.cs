using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HocVien_DK_LopChuyenDeDAO
    {
        private static HocVien_DK_LopChuyenDeDAO instance;

        public static HocVien_DK_LopChuyenDeDAO Instance { get { if (instance == null) instance = new HocVien_DK_LopChuyenDeDAO(); return instance; } }

        private HocVien_DK_LopChuyenDeDAO() { }

        public int dangky(HocVien_DK_LopChuyenDe dk)
        {
            string query = "insert into HOCVIEN_DANGKY_LOPChuyenDe (ID_HocVien, ID_LopChuyenDe) values (" + dk.Id_HV + ", " + dk.Id_Lop + ");";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public List<HocVien> LoadLop(int id)
        {
            List<HocVien> listHV = new List<HocVien>();
            string query = "select ID_HocVien, HoTen, SDT, GioiTinh, NgaySinh from HOCVIEN_DANGKY_LOPCHUYENDE, HOCVIEN where HOCVIEN_DANGKY_LOPCHUYENDE.ID_LopChuyenDe = " + id + " and HOCVIEN_DANGKY_LOPCHUYENDE.ID_HocVien = HOCVIEN.ID";
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
