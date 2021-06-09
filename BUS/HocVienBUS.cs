using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class HocVienBUS
    {
        private static HocVienBUS instance;

        public static HocVienBUS Instance { get { if (instance == null) instance = new HocVienBUS(); return instance; } }

        private HocVienBUS() { }
        public void Xem(DataGridView data)
        {

        }
    }
}
