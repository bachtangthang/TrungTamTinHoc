using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiaoVien_ChuyenDeDAO
    {
        private static GiaoVien_ChuyenDeDAO instance;

        public static GiaoVien_ChuyenDeDAO Instance { get { if (instance == null) instance = new GiaoVien_ChuyenDeDAO(); return instance; } }

        private GiaoVien_ChuyenDeDAO() { }

        public int Check_GV_CD(int idGV, int idMH)
        {
            string query = "select count (*) from GIAOVIEN_CHUYENDE where ID_GiaoVien = " + idGV + " and ID_ChuyenDe = " + idMH + " ; ";
            return Convert.ToInt32(DAO.DataProvider.Instance.ExecuteScalar(query));
        }
    }
}
