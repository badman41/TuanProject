using DXApplication1.DAL;
using DXApplication1.Model;
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
   public class NhomHangController : _ControllerBase<NHOMHANG>
    {
        public DataTable GetList()
        {
            return DAL.DataAccess.ExecQuery("select MaNhom,TenNhom from NHOMHANG");
        }
    }
}
