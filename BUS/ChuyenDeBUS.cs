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
    public class ChuyenDeBUS
    {
        private static ChuyenDeBUS instance;

        public static ChuyenDeBUS Instance { get { if (instance == null) instance = new ChuyenDeBUS(); return instance; } }

        private ChuyenDeBUS() { }

        public void Xem(DataGridView data)
        {
            //data.DataSource = ChuyenDeDAO.Instance.
        }
    }
}
