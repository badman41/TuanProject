using DXApplication1.DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Controller
{
    class HangHoaController :_ControllerBase<HANGHOA>
    {
        public DataTable LayDonGia(string ma)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@MaHH", ma);
          

            return DataAccess.ExecQuery("HANGHOA_LayDonGia", sp);
        }
        public DataTable LayDonGiaBan(string ma)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@MaHH", ma);
            return DataAccess.ExecQuery("HANGHOA_LayDonGiaBan", sp);
        }
        public DataTable GetAllHangHoa()
        {
            return DataAccess.ExecQuery("select HANGHOA.*,NHACUNGCAP.TenNCC,NHOMHANG.TenNhom from HANGHOA join NHACUNGCAP on HANGHOA.MaNCC=NHACUNGCAP.MaNCC join NHOMHANG on HANGHOA.MaNhom=NHOMHANG.MaNhom");
        }
        public HANGHOA GetHangHoa(String id)
        {
            DataTable dt = DataAccess.ExecQuery("select HANGHOA.*,NHACUNGCAP.TenNCC,NHOMHANG.TenNhom from HANGHOA join NHACUNGCAP on HANGHOA.MaNCC=NHACUNGCAP.MaNCC join NHOMHANG on HANGHOA.MaNhom=NHOMHANG.MaNhom where  where MaHH='" + id + "'");
            HANGHOA hh = new HANGHOA();
            hh.MaHH = dt.Rows[0][0].ToString();
            hh.TenHH = dt.Rows[0][1].ToString();
            hh.NoiSX = dt.Rows[0][2].ToString();
            hh.DonGia = dt.Rows[0][5].ToString();
            hh.DonGiaBan = dt.Rows[0][4].ToString();
            hh.DonVi = dt.Rows[0][3].ToString();
            hh.MaNCC = dt.Rows[0][6].ToString();
            hh.MaNhom = dt.Rows[0][7].ToString();
            return hh;
        }
        public void InsertHangHoa(HANGHOA hh)
        {
            DataAccess.ExecNonQuery("insert into HANGHOA values('" + hh.MaHH + "','" + hh.TenHH + "','" + hh.NoiSX
                + "','" + hh.DonVi + "','" + hh.DonGiaBan + "','" + hh.DonGia + "','" + hh.MaNCC + "','" + hh.MaNhom + "')");
        }
        public void UpdateHangHoa(HANGHOA hh)
        {
            DataAccess.ExecNonQuery("update HANGHOA set TenHH='" + hh.TenHH + "',NoiSX='" + hh.NoiSX
                + "',DonVi='" + hh.DonVi + "',DonGia='" + hh.DonGia + "',DonGiaBan='" +
                    hh.DonGiaBan + "',MaNCC='" + hh.MaNCC + "',MaNhom='" + hh.MaNhom + "'  where MaHH='" + hh.MaHH + "'");
        }
        public void DeleteHangHoa(String id)
        {
            DataAccess.ExecNonQuery("delete HANGHOA where HANGHOA.MaHH='" + id + "'");
        }
    }
}
