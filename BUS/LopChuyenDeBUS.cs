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

        public DataTable timLop(int id_cd, int hocky, int nam)//Tìm lớp theo id chuyên đề, năm, học kỳ
        {
            return LopChuyenDeDAO.Instance.timLop(id_cd, hocky, nam);
        }

        public int CheckIDLop(int id)//kiểm tra id lớp có tồn tại
        {
            return DAO.LopChuyenDeDAO.Instance.CheckIDLop(id);
        }

        public DataTable findLopByID(int idlop)//Tìm lớp theo ID
        {
            return LopChuyenDeDAO.Instance.findLopByID(idlop);
        }

        public DataTable LoadDS()
        {
            return DAO.LopChuyenDeDAO.Instance.LoadDS();
        }

        public int MoLop(int idlop, string tenlop, int idmon, int idgv, int hocky, int namhoc, int soluong)
        {
            LopChuyenDe lcd = new LopChuyenDe(idlop, tenlop, idmon, idgv, hocky, namhoc, soluong);
            return DAO.LopChuyenDeDAO.Instance.MoLop(lcd);
        }
    }
}
