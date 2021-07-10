using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class GiaoVien_ChuyenDeBUS
    {
        private static GiaoVien_ChuyenDeBUS instance;

        public static GiaoVien_ChuyenDeBUS Instance { get { if (instance == null) instance = new GiaoVien_ChuyenDeBUS(); return instance; } }

        private GiaoVien_ChuyenDeBUS() { }

        public int Check_GV_CD(int idGV, int idMH)
        {
            return DAO.GiaoVien_ChuyenDeDAO.Instance.Check_GV_CD(idGV, idMH);
        }
    }
}
