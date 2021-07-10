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
    public class HocVien_DK_LopChuyenDeBUS
    {
        private static HocVien_DK_LopChuyenDeBUS instance;

        public static HocVien_DK_LopChuyenDeBUS Instance { get { if (instance == null) instance = new HocVien_DK_LopChuyenDeBUS(); return instance; } }

        private HocVien_DK_LopChuyenDeBUS() { }

        public int DangKy(int id_HV, int id_Lop)
        {
            HocVien_DK_LopChuyenDe dk = new HocVien_DK_LopChuyenDe(id_HV, id_Lop);
            return DAO.HocVien_DK_LopChuyenDeDAO.Instance.dangky(dk);
        }

        public void LoadLop(DataGridView data, int id)
        {
            data.DataSource = DAO.HocVien_DK_LopChuyenDeDAO.Instance.LoadLop(id);
        }

        public void load(DataGridView data, int id)
        {
            data.DataSource = DAO.HocVien_DK_LopChuyenDeDAO.Instance.load(id);
        }

        public bool NhapDiem(DataGridView data)
        {
            List<HocVien_DK_LopChuyenDe> listHV = new List<HocVien_DK_LopChuyenDe>();
            foreach (DataGridViewRow row in data.Rows)
            {
                int id_hv = Convert.ToInt32(row.Cells["Id_HV"].Value);
                int id_lop = Convert.ToInt32(row.Cells["Id_Lop"].Value);
                bool pass = (bool)row.Cells["is_Pass"].Value;
                int diem = Convert.ToInt32(row.Cells["Diem"].Value);

                HocVien_DK_LopChuyenDe hv = new HocVien_DK_LopChuyenDe(id_lop, id_hv, pass, diem);

                listHV.Add(hv);
            }

            return DAO.HocVien_DK_LopChuyenDeDAO.Instance.NhapDiem(listHV);
        }
    }
}
