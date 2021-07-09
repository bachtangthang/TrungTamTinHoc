using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class MonHocDAO
    {
        private static MonHocDAO instance;

        public static MonHocDAO Instance { get { if (instance == null) instance = new MonHocDAO(); return instance; } }

        private MonHocDAO() { }

        public int FindID_By_Name(string ten)
        {
            string query = "select ID_MonHoc from MONHOC where MONHOC.Ten like '%" + ten + "%'";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
        }

        public float HocPhi(int id)
        {
            string query = "select mh.HocPhi from MONHOC mh, LOPHOCPHAN lhp where lhp.ID_Lop = " + id + " and lhp.ID_MonHoc = mh.ID_MonHoc;  ";
            return Convert.ToSingle(DataProvider.Instance.ExecuteScalar(query));
        }
    }
}
