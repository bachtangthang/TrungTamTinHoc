using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LichThiDAO
    {
        private static LichThiDAO instance;

        public static LichThiDAO Instance { get { if (instance == null) instance = new LichThiDAO(); return instance; } }

        private LichThiDAO() { }

        public List<LichThi> Load(int idlop)
        {
            List<LichThi> lich = new List<LichThi>();
            string query = "select ID_LichThi, Ngay, PhongThi, ThoiGian from LICHTHI where LICHTHI.ID_LopHocPhan = " + idlop + "";
            DataTable data = DataProvider.Instance.ExecuxeQuery(query);

            foreach (DataRow item in data.Rows)
            {
                int id_lich = Convert.ToInt32(item["ID_LichThi"]);
                string phong = item["PhongThi"].ToString();
                string time = item["ThoiGian"].ToString();
                DateTime day = (DateTime)item["Ngay"];

                LichThi l = new LichThi(id_lich, phong, time, idlop, day);

                lich.Add(l);
            }
            return lich;
        }
    }
}
