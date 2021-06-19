using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class LopChuyenDeBUS
    {
        private static LopChuyenDeBUS instance;

        public static LopChuyenDeBUS Instance { get { if (instance == null) instance = new LopChuyenDeBUS(); return instance; } }

        private LopChuyenDeBUS() { }

        public void Xem(DataGridView data)
        {
            //data.DataSource = LopChuyenDeDAO.Instance.
        }
    }
}
