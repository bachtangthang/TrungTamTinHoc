using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public List<HocVien> LoadLop(int id)//load danh sach thong tin SV cua 1 lop
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

        public List<HocVien_DK_LopHocPhan> load(int id)//load danh sach SV de nhap diem
        {
            List<HocVien_DK_LopHocPhan> listHV = new List<HocVien_DK_LopHocPhan> ();
            string query = "Select  ID_HocVien, Diem, is_Pass from HOCVIEN_DANGKY_LOPHOCPHAN where ID_Lop = " + id + "";
            DataTable data = DataProvider.Instance.ExecuxeQuery(query);

            foreach (DataRow item in data.Rows)
            {
                int id_hv = Convert.ToInt32(item["ID_HocVien"]);
                bool is_pass;
                if (item["is_Pass"] is DBNull)
                {
                    is_pass = false;
                }
                else
                {
                    is_pass = (bool)item["is_Pass"];
                }
                if(!(item["Diem"] is DBNull))
                {
                    int diem = Convert.ToInt32(item["Diem"]);
                    HocVien_DK_LopHocPhan newHV = new HocVien_DK_LopHocPhan(id, id_hv, is_pass,  diem);
                    listHV.Add(newHV);
                }                    
                else
                {
                    HocVien_DK_LopHocPhan newHV = new HocVien_DK_LopHocPhan(id, id_hv, is_pass);
                    listHV.Add(newHV);
                }
            }    

            return listHV;
        }
    
        public int KTHV(int idhv, int idlop)
        {
            string query = "select count (*) from HOCVIEN_DANGKY_LOPHOCPHAN where ID_HOCVIEN = " + idhv + " and ID_Lop = " + idlop + "; ";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
        }
   
        public bool NhapDiem(List<HocVien_DK_LopHocPhan> listHV)
        {
            foreach(HocVien_DK_LopHocPhan hv in listHV)
            {
                string query = "Update HOCVIEN_DANGKY_LOPHOCPHAN set is_Pass = '"+hv.Is_Pass+"' , Diem = "+hv.Diem+" where ID_HocVien = "+hv.Id_HV+" and ID_Lop = "+hv.Id_Lop+"; ";
                DAO.DataProvider.Instance.ExecuteNonQuery(query);
            }
            return true;
        }
    }
}
