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
            try
            {
                int val = BUS.HocVienBUS.Instance.Check_ID(int.Parse(tb_ID.Text));
                //int val = int.Parse(TextBox1.Text);
                int i = Convert.ToInt32(val);
                if (i == 0)
                    MessageBox.Show("ID Học Viên Thỏa Mãn", "Thông báo");
                else if (i >= 1)
                    MessageBox.Show("ID Học Viên đã tồn tại", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DangKyHV_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tb_ID.Text);
                string name = tb_name.Text;
                string sdt = tb_sdt.Text;
                string sex = cb_gioitinh.Text;
                DateTime dob = dt_ngaysinh.Value;
                BUS.HocVienBUS.Instance.DangKyHV(id, name, sdt, sex, dob);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_timkiemLop_Click(object sender, EventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            try
            {
                BUS.HocVien_DK_LopHocPhanBUS.Instance.LoadLop(dtgv_Lop, int.Parse(tb_Idlop.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Dangky_Click(object sender, EventArgs e)
        {
            try
            {
                int i = BUS.HocVien_DK_LopHocPhanBUS.Instance.DangKy(int.Parse(tb_IDHV.Text), int.Parse(tb_Idlop.Text));
                if (i == 1)
                    MessageBox.Show("Đăng ký thành công", "Thông báo");
                else
                    MessageBox.Show("Đăng ký không thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Học viên đã đăng ký môn học");
            }
        }

        private void bt_loadcd_Click(object sender, EventArgs e)
        {
            try
            {
                BUS.HocVien_DK_LopChuyenDeBUS.Instance.LoadLop(dtgv_chuyende, int.Parse(tb_idlop_dkcd.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_dkcd_Click(object sender, EventArgs e)
        {
            try
            {
                int i = BUS.HocVien_DK_LopChuyenDeBUS.Instance.DangKy(int.Parse(tb_idhv_dkcd.Text), int.Parse(tb_idlop_dkcd.Text));
                if (i == 1)
                    MessageBox.Show("Đăng ký thành công", "Thông báo");
                else
                    MessageBox.Show("Đăng ký không thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Học viên đã đăng ký môn học");
            }
        }

        private void bt_dangkythilai_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dtgv_dkthilai.SelectedCells[0].OwningRow;
                int id_tl = Convert.ToInt32(row.Cells["Id"].Value);
                if (BUS.HocVien_LichThiBUS.Instance.DangKy(int.Parse(id_hvthilai.Text), id_tl) == 1)
                {
                    MessageBox.Show("Thành công               ", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Học viên đã đăng ký", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_loadlichthi_Click(object sender, EventArgs e)
        {
            try
            {
                BUS.LichThiBUS.Instance.Load(dtgv_dkthilai, int.Parse(id_lopthilai.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
