using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LopChuyenDeDAO
    {
        private static LopChuyenDeDAO instance;

        public static LopChuyenDeDAO Instance
        {
            get { if (instance == null) instance = new LopChuyenDeDAO(); return instance; }
        }

        private LopChuyenDeDAO() { }

        public DataTable timLop(int id_cd, int hocky, int nam)
        {
            string query = "select * from LOPCHUYENDE where LOPCHUYENDE.ID_ChuyenDeMo = " + id_cd + " and HocKy = " + hocky + " and NamHoc = " + nam + "";
            return DataProvider.Instance.ExecuxeQuery(query);
        }

        public int CheckIDLop(int id)//Kiểm tra id lớp có tồn tại
        {
            string query = "Select count (*) from LOPCHUYENDE where ID_LopChuyenDe = " + id + ";";
            return Convert.ToInt32(DAO.DataProvider.Instance.ExecuteScalar(query));
        }

        public DataTable findLopByID(int idlop)//tìm lớp theo ID
        {
            string query = "select * from LOPCHUYENDE where ID_LopChuyenDe = " + idlop + ";";
            return DAO.DataProvider.Instance.ExecuxeQuery(query);
        }

        public DataTable LoadDS()
        {
            string query = "select * from LOPCHUYENDE ";
            return DAO.DataProvider.Instance.ExecuxeQuery(query);
        }

        public int MoLop(LopChuyenDe lcd)
        {
            string query = "insert into LOPCHUYENDE values (" + lcd.Id_LopChuyenDe + ", '" + lcd.TenLop + "', " + lcd.Id_ChuyenDeMo + ", " + lcd.Id_GiaoVien + ", " + lcd.HocKy + ", " + lcd.Nam + ", "+lcd.Soluong+", "+lcd.Soluongtoida+");";
            return DAO.DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
