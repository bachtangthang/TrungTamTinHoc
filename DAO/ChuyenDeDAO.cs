using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ChuyenDeDAO
    {
        private static ChuyenDeDAO instance;

        public static ChuyenDeDAO Instance { get { if (instance == null) instance = new ChuyenDeDAO(); return instance; } }

        private ChuyenDeDAO() { }

        public List<ChuyenDe> Xem()
        {
            List<ChuyenDe> cd = new List<ChuyenDe>();
            string query = "select * from CHUYENDE";
            DataTable data = DataProvider.Instance.ExecuxeQuery(query);

            foreach (DataRow item in data.Rows)
            {

            }
            return cd;
        }
    }
}
