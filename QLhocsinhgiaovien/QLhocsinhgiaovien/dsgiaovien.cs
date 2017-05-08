using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QLhocsinhgiaovien.Model;

namespace QLhocsinhgiaovien
{
    public partial class dsgiaovien : DevExpress.XtraEditors.XtraForm
    {
        public dsgiaovien()
        {
            InitializeComponent();
        }
        public void hienthidanhsachGiaovien()
        {
            // tro toi data     
            dgvdsgv.DataSource = Model.Giaovienmod.filldatasetGiaovien().Tables[0];
            dgvdsgv.BorderStyle = BorderStyle.Fixed3D;
            dgvdsgv.RowHeadersVisible = false;

        }
        public void hienthitimkiem()
        {
            DataTable dt = new DataTable();
            string sqltimkiem = "select * from Giaovien where Giaovien.Hoten like N'%" + txttimkiem.Text + "% ' or Giaovien.Magiaovien like N'%" + txttimkiem.Text + "% ' or Giaovien.GioiTinh like N'%" + txttimkiem.Text + "% ' or Giaovien.Quequan like N'%" + txttimkiem.Text + "% ' ";
            SqlCommand cmd = new SqlCommand(sqltimkiem, connection.Getconnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            da.Dispose();
            dgvdsgv.DataSource = dt;
        }
        private void dsgiaovien_Load(object sender, EventArgs e)
        {
            hienthidanhsachGiaovien();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hienthitimkiem();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            hienthitimkiem();
        }
    }
}