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
    public class LichThiBUS
    {
        private static LichThiBUS instance;

        public static LichThiBUS Instance { get { if (instance == null) instance = new LichThiBUS(); return instance; } }

        private LichThiBUS() { }

        public void Load(DataGridView data, int idlop)
        {
            data.DataSource = DAO.LichThiDAO.Instance.Load(idlop);
        }
    }
}
