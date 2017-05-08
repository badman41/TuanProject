using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLhocsinhgiaovien.Model
{
    class PhanCongMod
    {
        public DataTable GetALL()
        {
            return Model.connection.FillDataTable("select Giaovien.Magiaovien 'MGV',Hoten 'Họ tên',NgaySinh 'Ngày sinh',Giaovien.GioiTinh 'Giới tính',BangMonHoc.TenMonHoc 'Dạy môn',lop.Malop,Tenlop 'Lớp',Phancongday.LichDay"
                                  +" from Giaovien join Phancongday on Giaovien.Magiaovien = Phancongday.Magiaovien"
                                    + " join Lop on Phancongday.Malop = Lop.Malop"
                                       + "left join BangMonHoc on Giaovien.MaMon = BangMonHoc.MaMon");
        }
    }
}
