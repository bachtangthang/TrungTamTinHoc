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

        public DataTable findLopByID(int idlop)
        {
            return LopHocPhanDAO.Instance.findLopByID(idlop);
        }

        public DataTable LoadDS()
        {
            return LopHocPhanDAO.Instance.LoadDS();
        }

        public int MoLop(int idlop, string tenlop, int idmon, int idgv, int hocky, int namhoc, int soluong)
        {
            LopHocPhan lhp = new LopHocPhan(idlop, tenlop, idmon, idgv, hocky, namhoc, soluong);
            return DAO.LopHocPhanDAO.Instance.MoLop(lhp);
        }

        public DataTable timLopV2(string mh, int hocky, int nam)
        {
            return LopHocPhanDAO.Instance.timLopV2(mh, hocky, nam);
        }
    }
}
