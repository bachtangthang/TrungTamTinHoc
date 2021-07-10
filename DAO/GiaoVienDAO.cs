using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        public static GiaoVienDAO Instance { get { if (instance == null) instance = new GiaoVienDAO(); return instance; } }

        private GiaoVienDAO() { }

        public int CheckIDGV(int id)
        {
            string query = "select count (*) from GIAOVIEN where GIAOVIEN.ID_GiaoVien = " + id + "; ";
            return Convert.ToInt32(DAO.DataProvider.Instance.ExecuteScalar(query));
        }
    }
}
