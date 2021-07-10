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
    public class LopHocPhanBUS
    {
        private static LopHocPhanBUS instance;

        public static LopHocPhanBUS Instance { get { if (instance == null) instance = new LopHocPhanBUS(); return instance; } }

        private LopHocPhanBUS() { }

        public DataTable timLop(int id_cd, int hocky, int nam)
        {
            return LopHocPhanDAO.Instance.timLop(id_cd, hocky, nam);
        }

        public int CheckIDLop(int id)
        {
            return DAO.LopHocPhanDAO.Instance.CheckIDLop(id);
        }
    }
}
