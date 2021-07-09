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
    public partial class fDangNhap : Form
    {
        private int id;

        public int Id { get => id; set => id = value; }

        public fDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login(tb_TenDangNhap.Text, tb_MatKhau.Text) )//Login thành công
            {
                string role = BUS.NguoiDungBUS.Instance.loaiTK(tb_TenDangNhap.Text, tb_MatKhau.Text);//kiểm tra role
                if (role == "NhanVien")
                {
                    fNhanViencs f = new fNhanViencs();
                    loginUser.Id = BUS.NguoiDungBUS.Instance.getID(tb_TenDangNhap.Text, tb_MatKhau.Text);//Lưu lại id của nhân viên đăng nhập
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if(role == "GIAOVU")
                {
                    fGiaoVu f = new fGiaoVu();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }    
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }
        
        bool Login(string ten, string pass)//Hàm login
        {
            return BUS.NguoiDungBUS.Instance.Login(ten, pass);
        }
    }
}
