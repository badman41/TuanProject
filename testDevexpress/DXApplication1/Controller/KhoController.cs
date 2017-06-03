using DXApplication1.DAL;
using DXApplication1.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Controller
{
    class KhoController//:_ControllerBase<KhoModel>
    {
        public DataTable getAllKho()
        {
            return DataAccess.ExecQuery("select * from KHO");
        }
        public KhoModel GetKho(String id)
        {
            DataTable dt=DataAccess.ExecQuery("select * from KHO where MaKho='"+id+"'");
            return new KhoModel(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
        }
        public void InsertKho(KhoModel kho)
        {
            DataAccess.ExecNonQuery("insert into Kho values('"+kho.MaKho+"','"+kho.TenKho+"','"+kho.ViTri+"','"+kho.MaNV+"') ");
        }
        public void UpdateKho(KhoModel kho)
        {
            DataAccess.ExecNonQuery("update kho set ViTri='"+kho.ViTri+"',TenKho='"+kho.TenKho+"',MaNV='"+kho.MaNV+"' where MaKho='"+kho.MaKho+"'");
        }
        public void DeleteKho(String idKho)
        {
            DataAccess.ExecNonQuery("delete KHO where MaKho='"+idKho+"'");
        }
    }
}
