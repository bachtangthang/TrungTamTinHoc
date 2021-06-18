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
            if (val == 0)
                MessageBox.Show("ID Học Vien Thỏa Mãn", "Thông báo");
            else if (val >= 1)
                MessageBox.Show("ID Học Viên đã tồn tại", "Thông báo");
        }

        private void btn_DangKyHV_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_ID.Text);
            string name = tb_name.Text;
            string sdt = tb_sdt.Text;
            string sex = cb_gioitinh.Text;
            DateTime dob = dt_ngaysinh.Value;
        }
    }
}
