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
    public class HocVien_DK_LopHocPhanBUS
    {
        private static HocVien_DK_LopHocPhanBUS instance;

        public static HocVien_DK_LopHocPhanBUS Instance { get { if (instance == null) instance = new HocVien_DK_LopHocPhanBUS(); return instance; } }

        private HocVien_DK_LopHocPhanBUS() { }
        
        public int DangKy(int id_HV, int id_Lop)
        {
            HocVien_DK_LopHocPhan dk = new HocVien_DK_LopHocPhan(id_HV, id_Lop);
            return DAO.HocVien_DK_LopHocPhanDAO.Instance.dangky(dk);
        }
        
        public void LoadLop(DataGridView data, int id)
        {
            data.DataSource = DAO.HocVien_DK_LopHocPhanDAO.Instance.LoadLop(id);
        }

        public void load(DataGridView data, int id)
        {
            data.DataSource = DAO.HocVien_DK_LopHocPhanDAO.Instance.load(id);
        }

    }
}
