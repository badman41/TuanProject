using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLhocsinhgiaovien.Model
{
    class diemchitietmod
    {

        public static DataSet filldatasetdiem()
        {
            // goi thu tuc dataset 
            return Model.connection.FillDataSet("spgetdiemchitiet", CommandType.StoredProcedure);
        }
    }
}
