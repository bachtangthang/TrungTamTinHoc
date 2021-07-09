using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private int id;
        private int nguoiThucHien;
        private int id_Hv;
        private float tongTien;

        public int Id { get => id; set => id = value; }
        public int NguoiThucHien { get => nguoiThucHien; set => nguoiThucHien = value; }
        public int Id_Hv { get => id_Hv; set => id_Hv = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }

        public HoaDon(int nguoithuchien, int id_hv, float tongtien)
        {
            this.nguoiThucHien = nguoithuchien;
            this.id_Hv = id_hv;
            this.tongTien = tongtien;
        }
        public HoaDon()
        {

        }
    }
}
