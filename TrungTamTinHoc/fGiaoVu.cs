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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_Loai.Text == "Học phần")
                {
                    BUS.HocVien_DK_LopHocPhanBUS.Instance.load(dtgv_nhapdiem, int.Parse(id_lop.Text));
                }
                else if (cb_Loai.Text == "Chuyên đề")
                {
                    BUS.HocVien_DK_LopChuyenDeBUS.Instance.load(dtgv_nhapdiem, int.Parse(id_lop.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_NhapDiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_Loai.Text == "Học phần")
                {
                    BUS.HocVien_DK_LopHocPhanBUS.Instance.NhapDiem(dtgv_nhapdiem);
                }
                else if (cb_Loai.Text == "Chuyên đề")
                {
                    BUS.HocVien_DK_LopChuyenDeBUS.Instance.NhapDiem(dtgv_nhapdiem);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        public int CheckIDGV(int id)//Hàm kiểm tra giáo viên có tồn tại
        {
            try
            {
                return BUS.GiaoVienBUS.Instance.CheckIDGV(id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int CheckIDLopHP(int id)//Hàm kiểm tra ID lớp Học phần có thỏa mãn
        {
            try
            {
                return BUS.LopHocPhanBUS.Instance.CheckIDLop(id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int CheckIDLopCD(int id)//Hàm kiểm tra ID lớp Chuyên đề có thỏa mãn
        {
            try
            {
                return BUS.LopChuyenDeBUS.Instance.CheckIDLop(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void btn_CheckIDLop_Click(object sender, EventArgs e)
        {
            if(cb_LoaiMon.Text == "Học phần")
            {
                try
                {
                    int val = CheckIDLopHP(int.Parse(tb_IDLop.Text));
                    if (val >=1)
                    {
                        MessageBox.Show("ID lớp đã tồn tại", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("ID lớp không tồn tại", "Thông báo");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }   
            else if(cb_LoaiMon.Text == "Chuyên đề")
            {
                try
                {
                    int val = CheckIDLopCD(int.Parse(tb_IDLop.Text));
                    if (val >= 1)
                    {
                        MessageBox.Show("ID lớp đã tồn tại", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("ID lớp không tồn tại", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
        }

        private void btn_CheckIDGV_Click(object sender, EventArgs e)
        {
            try
            {
                int val = CheckIDGV(int.Parse(tb_IDGV.Text));
                if (val >= 1)
                {
                    MessageBox.Show("Giáo Viên có tồn tại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Giáo Viên không tồn tại", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int Check_GV_MH(int idGV, int idMH)//Kiểm tra giáo viên có thể dạy môn học không
        {
            try
            {
                return BUS.GiaoVien_MonHocBUS.Instance.Check_GV_MH(idGV, idMH);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int Check_GV_CD(int idGV, int idMH)//Kiểm tra giáo viên có thể dạy Chuyên đề không
        {
            try
            {
                return BUS.GiaoVien_ChuyenDeBUS.Instance.Check_GV_CD(idGV, idMH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void btn_KT_GVMH_Click(object sender, EventArgs e)
        {
            if (cb_LoaiMon.Text == "Học phần")
            {
                try
                {
                    int val = Check_GV_MH(int.Parse(tb_IDGV.Text), int.Parse(tb_IDMH.Text));
                    if (val >= 1)
                    {
                        MessageBox.Show("Giáo viên đủ điều kiện dạy môn học", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Giáo viên không dủ điều kiện dạy môn học", "Thông báo");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(cb_LoaiMon.Text == "Chuyên đề")
            {
                try
                {
                    int val = Check_GV_CD(int.Parse(tb_IDGV.Text), int.Parse(tb_IDMH.Text));
                    if (val >= 1)
                    {
                        MessageBox.Show("Giáo viên đủ điều kiện dạy môn học", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Giáo viên không dủ điều kiện dạy môn học", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
        }

        private void btn_TKLop_Click(object sender, EventArgs e)
        {
            if(cb_KieuMon.Text == "Học phần")
            {
                try
                {
                    dtgv_dsLop.DataSource = BUS.LopHocPhanBUS.Instance.findLopByID(int.Parse(tb_Lop.Text));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
            else if(cb_KieuMon.Text == "Chuyên đề")
            {
                try
                {
                    dtgv_dsLop.DataSource = BUS.LopChuyenDeBUS.Instance.findLopByID(int.Parse(tb_Lop.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
        }

        private void btn_LoadLop_Click(object sender, EventArgs e)
        {
            if (cb_KieuMon.Text == "Học phần")
            {
                try
                {
                    dtgv_dsLop.DataSource = BUS.LopHocPhanBUS.Instance.LoadDS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cb_KieuMon.Text == "Chuyên đề")
            {
                try
                {
                    dtgv_dsLop.DataSource = BUS.LopChuyenDeBUS.Instance.LoadDS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_MoLop_Click(object sender, EventArgs e)
        {

        }

        public int MoLop(int idlop, string tenlop, int idmon, int idgv, int hocky, int namhoc, int soluong)
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
