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

        public List<LopChuyenDe> Xem_Theo_Lop()//not done
        {
            List<LopChuyenDe> lop = new List<LopChuyenDe>();
            string query1 = "select * from LOPCHUYENDE where ";
            string query2 = "select * from LOPHOCPHAN where";
            DataTable data = DataProvider.Instance.ExecuxeQuery(query1);

            foreach (DataRow item in data.Rows)
            {

            }    
            return lop;
        }

        public DataTable timLop(int id_cd, int hocky, int nam)
        {
            string query = "select * from LOPCHUYENDE where LOPCHUYENDE.ID_ChuyenDeMo = " + id_cd + " and HocKy = " + hocky + " and NamHoc = " + nam + "";
            return DataProvider.Instance.ExecuxeQuery(query);
        }

        public int CheckIDLop(int id)
        {
            string query = "Select count (*) from LOPCHUYENDE where ID_LopChuyenDe = " + id + ";";
            return Convert.ToInt32(DAO.DataProvider.Instance.ExecuteScalar(query));
        }
    }
}
