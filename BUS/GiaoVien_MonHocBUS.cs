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
    public class GiaoVien_MonHocBUS
    {
        private static GiaoVien_MonHocBUS instance;

        public static GiaoVien_MonHocBUS Instance { get { if (instance == null) instance = new GiaoVien_MonHocBUS(); return instance; } }
    
        private GiaoVien_MonHocBUS() { }

        public int Check_GV_MH(int idGV, int idMH)
        {
            return DAO.GiaoVien_MonHocDAO.Instance.Check_GV_MH(idGV, idMH);
        }    
    }
}
