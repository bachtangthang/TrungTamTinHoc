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
    public partial class fNhanViencs : Form
    {
        public fNhanViencs()
        {
            InitializeComponent();
        }

        private void bt_kiemtraID_Click(object sender, EventArgs e)
        {
            int val = BUS.HocVienBUS.Instance.Check_ID(int.Parse(tb_ID.Text));
            //int val = int.Parse(TextBox1.Text);
            int i = Convert.ToInt32(val);
            if (i == 0)
                MessageBox.Show("ID Học Viên Thỏa Mãn", "Thông báo");
            else if (i >= 1)
                MessageBox.Show("ID Học Viên đã tồn tại", "Thông báo");
        }

        private void btn_DangKyHV_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_ID.Text);
            string name = tb_name.Text;
            string sdt = tb_sdt.Text;
            string sex = cb_gioitinh.Text;
            DateTime dob = dt_ngaysinh.Value;
            BUS.HocVienBUS.Instance.DangKyHV(id, name, sdt, sex, dob);
        }

        private void btn_timkiemLop_Click(object sender, EventArgs e)
        {
            int hocky = int.Parse(tb_hocky.Text);
            int nam = int.Parse(tb_namhoc.Text);
            string tenlop = tb_tenMH.Text;
            if(cb_LoaiLop.Text == "Học phần")
            {

            }   
            else if (cb_LoaiLop.Text == "Chuyên đề")
            {
                int id_cd = BUS.ChuyenDeBUS.Instance.findID_by_Name(tenlop);
                dtgv_lophoc.DataSource = BUS.LopChuyenDeBUS.Instance.timLop(id_cd, hocky, nam);
            }
        }
    }
}
