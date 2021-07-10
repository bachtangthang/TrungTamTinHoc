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

        public int KTHV(int idhv, int idlop)
        {
            return DAO.HocVien_DK_LopHocPhanDAO.Instance.KTHV(idhv, idlop);
        }

        public bool NhapDiem(DataGridView data)
        {
            List<HocVien_DK_LopHocPhan> listHV = new List<HocVien_DK_LopHocPhan>();
            foreach (DataGridViewRow row in data.Rows)
            {
                int id_hv = Convert.ToInt32(row.Cells["Id_HV"].Value);
                int id_lop = Convert.ToInt32(row.Cells["Id_Lop"].Value);
                bool pass = (bool)row.Cells["is_Pass"].Value;
                int diem = Convert.ToInt32(row.Cells["Diem"].Value);

                HocVien_DK_LopHocPhan hv = new HocVien_DK_LopHocPhan(id_lop, id_hv, pass, diem);

                listHV.Add(hv);
            }

            return DAO.HocVien_DK_LopHocPhanDAO.Instance.NhapDiem(listHV);
        }
    }
}
