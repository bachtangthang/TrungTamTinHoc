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
    public class MonHocBUS
    {
        private static MonHocBUS instance;

        public static MonHocBUS Instance { get { if (instance == null) instance = new MonHocBUS(); return instance; } }

        private MonHocBUS() { }

        public void Xem(DataGridView data)
        {
            //data.DataSource = ChuyenDeDAO.Instance.
        }

        public int findID_by_Name(string tenlop)//Tìm id môn học bằng tên lớp
        {
            return DAO.MonHocDAO.Instance.FindID_By_Name(tenlop);
        }

        public float HocPhi(int id)
        {
            return DAO.MonHocDAO.Instance.HocPhi(id);
        }

        public int idMH(int id_lop)//Tìm id môn học bằng id lớp
        {
            return DAO.MonHocDAO.Instance.idMH(id_lop);
        }
    }
}
