using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLhocsinhgiaovien.views
{
    public partial class uctdiemchitiet : UserControl
    {
        public uctdiemchitiet()
        {
            InitializeComponent();
        }
        public static uctdiemchitiet uctdct = new uctdiemchitiet();// tạo mới form
        public void hienthidanhsachdiem()
        {
            // tro toi data     
            dgvdiemchitiet.DataSource = Model.diemchitietmod.filldatasetdiem().Tables[0];
            dgvdiemchitiet.BorderStyle = BorderStyle.Fixed3D;
            // dgvHocSinh.Dock = DockStyle.Fill;
            dgvdiemchitiet.RowHeadersVisible = false;

        }
        private void uctdiemchitiet_Load(object sender, EventArgs e)
        {
            hienthidanhsachdiem();
        }
    }
}
