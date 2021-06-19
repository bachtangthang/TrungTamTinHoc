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

        public List<ChuyenDe> Xem()//not done
        {
            List<ChuyenDe> cd = new List<ChuyenDe>();
            string query = "select * from CHUYENDE";
            DataTable data = DataProvider.Instance.ExecuxeQuery(query);

            foreach (DataRow item in data.Rows)
            {

            }
            return cd;
        }

        public int FindID_By_Name(string ten)
        {
            string query = "select ID_ChuyenDe from CHUYENDE where CHUYENDE.TenChuyenDe like '%"+ten+"%'";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
        }
    }
}
