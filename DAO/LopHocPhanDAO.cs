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
    }
}
