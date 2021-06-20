using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrungTamTinHoc
{
    public partial class fGiaoVu : Form
    {
        public fGiaoVu()
        {
            InitializeComponent();
        }

        private void btn_timkiemLop_Click(object sender, EventArgs e)
        {
            int hocky = int.Parse(tb_hocky.Text);
            int nam = int.Parse(tb_namhoc.Text);
            string tenlop = tb_tenMH.Text;
            if (cb_LoaiLop.Text == "Học phần")
            {
                int id_mh = BUS.MonHocBUS.Instance.findID_by_Name(tenlop);
                dtgv_lophoc.DataSource = BUS.LopHocPhanBUS.Instance.timLop(id_mh, hocky, nam);
            }
            else if (cb_LoaiLop.Text == "Chuyên đề")
            {
                int id_cd = BUS.ChuyenDeBUS.Instance.findID_by_Name(tenlop);
                dtgv_lophoc.DataSource = BUS.LopChuyenDeBUS.Instance.timLop(id_cd, hocky, nam);
            }
        }
    }
}
