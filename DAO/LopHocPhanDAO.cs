using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LopHocPhanDAO
    {
        private static LopHocPhanDAO instance;

        public static LopHocPhanDAO Instance { get { if (instance == null) instance = new LopHocPhanDAO(); return instance; } }

        private LopHocPhanDAO() { }

        public DataTable timLop(int id_hp, int hocky, int nam)
        {
            string query = "select * from LOPHOCPHAN where LOPHOCPHAN.ID_MonHoc = " + id_hp + " and HocKy = " + hocky + " and NamHoc = " + nam + "";
            return DataProvider.Instance.ExecuxeQuery(query);
        }

        public int CheckIDLop(int id)//kiểm tra id lớp có tồn tại
        {
            string query = "Select count (*) from LOPHOCPHAN where ID_Lop = "+id+";";
            return Convert.ToInt32(DAO.DataProvider.Instance.ExecuteScalar(query));
        }

        public DataTable findLopByID(int idlop)//tìm lớp theo id
        {
            string query = "select * from LOPHOCPHAN where ID_Lop = " + idlop + ";";
            return DAO.DataProvider.Instance.ExecuxeQuery(query);
        }
        public DataTable LoadDS()
        {
            string query = "select * from LOPHOCPHAN ";
            return DAO.DataProvider.Instance.ExecuxeQuery(query);
        }

        public int MoLop(LopHocPhan lhp)
        {
            string query = "insert into LOPHOCPHAN values (" + lhp.Id_Lop + ", " + lhp.Soluong + ", " + lhp.Soluongtoida + ", '" + lhp.TenLop + "', " + lhp.Id_MH + ", " + lhp.Id_GV + ", " + lhp.Hocky + ", " + lhp.Nam + ");";
            return DAO.DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable timLopV2(string mh, int hocky, int nam)
        {
            string query = "select * from LOPHOCPHAN lhp, MONHOC mh where lhp.ID_MonHoc = mh.ID_MonHoc and mh.ten like '%" + mh + "%' and lhp.HocKy = " + hocky + " and lhp.NamHoc = " + nam + "";
            return DataProvider.Instance.ExecuxeQuery(query);
        }
    }
}
