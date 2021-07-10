using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiaoVien_MonHocDAO
    {
        private static GiaoVien_MonHocDAO instance;

        public static GiaoVien_MonHocDAO Instance { get { if (instance == null) instance = new GiaoVien_MonHocDAO(); return instance; } }
    
        private GiaoVien_MonHocDAO() { }

        public int Check_GV_MH(int idGV, int idMH)
        {
            string query = "select count (*) from GIAOVIEN_MONHOC where ID_GiaoVien = " + idGV + " and ID_MonHoc = " + idMH + " ; ";
            return Convert.ToInt32(DAO.DataProvider.Instance.ExecuteScalar(query));
        }    
    }
}
