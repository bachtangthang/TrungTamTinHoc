using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NguoiDungDAO
    {
        private static NguoiDungDAO instance;

        public static NguoiDungDAO Instance { get { if (instance == null) instance = new NguoiDungDAO(); return instance; } }

        private NguoiDungDAO() { }

        public bool Login(string ten, string pass)
        {
            string query = "select * from NGUOIDUNG nd where nd.username = '" + ten + "' and nd.pass = '" + pass + "'; ";
            DataTable result = DataProvider.Instance.ExecuxeQuery(query);
            return result.Rows.Count > 0;
        }

        public string loaiTK(string ten, string pass)
        {
            string query = "select nd.loai from NGUOIDUNG nd where nd.username = '" +ten+ "' and nd.pass = '" +pass+ "'; ";
            return Convert.ToString(DataProvider.Instance.ExecuteScalar(query));
        }
    }
}
