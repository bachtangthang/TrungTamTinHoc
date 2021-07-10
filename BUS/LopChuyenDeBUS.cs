using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class LopChuyenDeBUS
    {
        private static LopChuyenDeBUS instance;

        public static LopChuyenDeBUS Instance { get { if (instance == null) instance = new LopChuyenDeBUS(); return instance; } }

        private LopChuyenDeBUS() { }

        public DataTable timLop(int id_cd, int hocky, int nam)
        {
            return LopChuyenDeDAO.Instance.timLop(id_cd, hocky, nam);
        }

        public int CheckIDLop(int id)
        {
            return DAO.LopChuyenDeDAO.Instance.CheckIDLop(id);
        }
    }
}
