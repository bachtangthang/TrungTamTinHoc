﻿using System;
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

        public int findID_by_Name(string tenlop)
        {
            return DAO.ChuyenDeDAO.Instance.FindID_By_Name(tenlop);
        }

        public float HocPhi(int id)
        {
            return DAO.ChuyenDeDAO.Instance.HocPhi(id);
        }

        public int idMH(int id_lop)//Tìm id môn học bằng id lớp
        {
            return DAO.ChuyenDeDAO.Instance.idMH(id_lop);
        }
    }
}
