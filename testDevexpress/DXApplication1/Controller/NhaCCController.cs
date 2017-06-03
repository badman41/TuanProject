using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Controller
{
    class NhaCCController
    {
        public DataTable GetList()
        {
            return DAL.DataAccess.ExecQuery("select MaNCC,TenNCC from NHACUNGCAP");
        }

    }
}
