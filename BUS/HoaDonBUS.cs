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
    public class HoaDonBUS
    {
        private static HoaDonBUS instance;

        public static HoaDonBUS Instance { get { if (instance == null) instance = new HoaDonBUS(); return instance; } }


        private HoaDonBUS()
        {

        }

        public int themHD(int id_nv, int hv, float tien)
        {
            HoaDon hd = new HoaDon(id_nv, hv, tien);
            return DAO.HoaDonDAO.Instance.themHD(hd);
        }

        public int idHD()
        {
            return DAO.HoaDonDAO.Instance.idHD();
        }
    }
}
