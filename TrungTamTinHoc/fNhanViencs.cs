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
        private int id;

        public int Id { get => id; set => id = value; }

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
                int val = BUS.HocVienBUS.Instance.Check_ID(int.Parse(tb_ID.Text));
                //int val = int.Parse(TextBox1.Text);
                int i = Convert.ToInt32(val);
                if (i >= 1)
                    MessageBox.Show("ID Học Viên đã tồn tại, vui lòng chọn ID khác", "Thông báo");
                else if(i == 0)
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
                if (cb_LoaiLop.Text == "Học phần")//test data: Bryn Caldicot, hk 1 nam 2020
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

        private void bt_Load_Click(object sender, EventArgs e)//Load danh sách học viên của 1 lớp
        {
            try
            {
                BUS.HocVien_DK_LopHocPhanBUS.Instance.LoadLop(dtgv_Lop, int.Parse(tb_Idlop.Text));

                tb_HocPhi.Text = BUS.MonHocBUS.Instance.HocPhi(int.Parse(tb_Idlop.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Dangky_Click(object sender, EventArgs e)//Đăng ký lớp học phần cho học viên
        {
            try
            {
                int i = BUS.HocVien_DK_LopHocPhanBUS.Instance.DangKy(int.Parse(tb_IDHV.Text), int.Parse(tb_Idlop.Text));//Thêm vào bảng HocVien_DK_LopHocPhan
                if (i == 1)
                    MessageBox.Show("Đăng ký thành công", "Thông báo");
                else
                    MessageBox.Show("Đăng ký không thành công", "Thông báo");

                try
                {
                    themHoaDon(loginUser.Id,int.Parse(tb_IDHV.Text), int.Parse(tb_HocPhi.Text));//Thêm vào bảng HOADON
                    try
                    {
                        int id_mh = BUS.MonHocBUS.Instance.idMH(int.Parse(tb_Idlop.Text));
                        int id_hd = BUS.HoaDonBUS.Instance.idHD();
                        BUS.ChiTietHoaDonBUS.Instance.themCTHD(id_mh, id_hd, float.Parse(tb_HocPhi.Text));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_loadcd_Click(object sender, EventArgs e)//Load danh sách học viên của 1 lớp chuyên đề
        {
            try
            {
                BUS.HocVien_DK_LopChuyenDeBUS.Instance.LoadLop(dtgv_chuyende, int.Parse(tb_idlop_dkcd.Text));

                tb_HPCD.Text = BUS.ChuyenDeBUS.Instance.HocPhi(int.Parse(tb_idlop_dkcd.Text)).ToString();
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
                int i = BUS.HocVien_DK_LopChuyenDeBUS.Instance.DangKy(int.Parse(tb_idhv_dkcd.Text), int.Parse(tb_idlop_dkcd.Text));//Thêm vào bảng HocVien_DK_LopChuyenDe
                if (i == 1)
                    MessageBox.Show("Đăng ký thành công", "Thông báo");
                else
                    MessageBox.Show("Đăng ký không thành công", "Thông báo");
                try
                {
                    themHoaDon(loginUser.Id, int.Parse(tb_idhv_dkcd.Text), int.Parse(tb_HPCD.Text));//Thêm vào bảng HOADON
                    try
                    {
                        int id_mh = BUS.ChuyenDeBUS.Instance.idMH(int.Parse(tb_idlop_dkcd.Text));
                        int id_hd = BUS.HoaDonBUS.Instance.idHD();
                        BUS.ChiTietHoaDonChuyenDeBUS.Instance.themCTHD(id_mh, id_hd, float.Parse(tb_HPCD.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                int val = BUS.HocVien_DK_LopHocPhanBUS.Instance.KTHV(int.Parse(id_hvthilai.Text), int.Parse(id_lopthilai.Text));
                if (val < 1)
                {
                    MessageBox.Show("Học viên không đăng ký lớp học phần này", "Thông báo");
                }
                else if(val >=1)
                {
                    DataGridViewRow row = dtgv_dkthilai.SelectedCells[0].OwningRow;
                    int id_tl = Convert.ToInt32(row.Cells["Id"].Value);
                    if (BUS.HocVien_LichThiBUS.Instance.DangKy(int.Parse(id_hvthilai.Text), id_tl) == 1)
                    {
                        MessageBox.Show("Thành công               ", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thành công", "Thông báo");
                    }
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

        private void bt_TKHocVien_Click(object sender, EventArgs e)//Tìm kiếm học viên theo ID
        {
            try
            {
                dtgv_HocVien.DataSource = BUS.HocVienBUS.Instance.TKHocVien(int.Parse(tb_ID.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_KTHV_Click(object sender, EventArgs e)//Kiểm tra học viên có đăng ký học phần hay không
        {
            try
            {
                int val = BUS.HocVien_DK_LopHocPhanBUS.Instance.KTHV(int.Parse(id_hvthilai.Text), int.Parse(id_lopthilai.Text));
                if (val >= 1)
                {
                    MessageBox.Show("Học viên có đăng ký lớp học phần này", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Học viên không đăng ký lớp học phần này", "Thông báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int themHoaDon(int id_nv, int id_hv, float tien)
        {
            return BUS.HoaDonBUS.Instance.themHD(id_nv, id_hv, tien);
        }

        private void bt_LoadHD_Click(object sender, EventArgs e)
        {
            dtgv_HoaDon.DataSource = BUS.HoaDonBUS.Instance.loadHD();
        }
    }

    public class loginUser
    {
        private static int id;

        public static int Id { get => id; set => id = value; }
    }
}
