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

        public int FindID_By_Name(string ten)//Tìm id chuyên đề thông qua tên
        {
            string query = "select ID_ChuyenDe from CHUYENDE where CHUYENDE.TenChuyenDe like '%"+ten+"%'";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
        }

        public float HocPhi(int id)//Lấy học phí thông qua id lớp
        {
            string query = "select cd.GiaTien from CHUYENDE cd, LOPCHUYENDE lcd where lcd.ID_LopChuyenDe = " + id + " and lcd.ID_ChuyenDeMo = cd.ID_ChuyenDe;  ";
            return Convert.ToSingle(DataProvider.Instance.ExecuteScalar(query));
        }

        public int idMH(int id_lop)//tìm id MH bằng ID lớp
        {
            string query = "select lcd.ID_ChuyenDeMo from LOPCHUYENDE lcd where lcd.ID_LopChuyenDe = " + id_lop + ";";
            return Convert.ToInt32(DAO.DataProvider.Instance.ExecuteScalar(query));
        }
    }
}
