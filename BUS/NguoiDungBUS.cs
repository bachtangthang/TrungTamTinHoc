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
    public class NguoiDungBUS
    {
        private static NguoiDungBUS instance;

        public static NguoiDungBUS Instance { get { if (instance == null) instance = new NguoiDungBUS(); return instance; } }

        private NguoiDungBUS() { }

        public bool Login(string ten, string mk)
        {
            return DAO.NguoiDungDAO.Instance.Login(ten, mk);
        }

        public string loaiTK(string ten, string mk)
        {
            return DAO.NguoiDungDAO.Instance.loaiTK(ten, mk);
        }
    }
}
