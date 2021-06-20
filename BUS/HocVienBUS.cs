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
    public class HocVienBUS
    {
        private static HocVienBUS instance;

        public static HocVienBUS Instance { get { if (instance == null) instance = new HocVienBUS(); return instance; } }

        private HocVienBUS() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = HocVienDAO.Instance.Xem();
        }

        public int Check_ID(int id)
        {
            return HocVienDAO.Instance.check_ID(id);
        }

        public int DangKyHV(int id, string name, string sdt, string sex, DateTime dob)
        {
            HocVien hv = new HocVien(id, name, sdt, sex, dob);
            return HocVienDAO.Instance.ThemHV(hv);
        }
    }
}
