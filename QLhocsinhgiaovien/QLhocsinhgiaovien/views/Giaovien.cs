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
    public partial class Giaovien : UserControl
    {
        public Giaovien()
        {
            InitializeComponent();
        }
        int plag =0;
        public static Giaovien uctGiaovien = new Giaovien();// tạo mới form
        public void hienthidanhsachGiaovien()
        {
            // tro toi data     
            dgvGiaovien.DataSource = Model.Giaovienmod.filldatasetGiaovien().Tables[0];
            dgvGiaovien.BorderStyle = BorderStyle.Fixed3D;
            dgvGiaovien.RowHeadersVisible = false;

        }
        void BindingGV()
        {
            cmbMaGV.DataBindings.Clear();
            cmbMaGV.DataBindings.Add("text", dgvGiaovien.DataSource, "Magiaovien");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("text", dgvGiaovien.DataSource, "Hoten");
            cmbGioitinh.DataBindings.Clear();
            cmbGioitinh.DataBindings.Add("text", dgvGiaovien.DataSource, "Gioitinh");
            dtpNgaysinh.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Add("text", dgvGiaovien.DataSource, "Ngaysinh");
            txtQuequan.DataBindings.Clear();
            txtQuequan.DataBindings.Add("text", dgvGiaovien.DataSource, "Quequan");
            cmbMaMon.DataBindings.Clear();
            cmbMaMon.DataBindings.Add("text", dgvGiaovien.DataSource, "MaMon");
            txtHocham.DataBindings.Clear();
            txtHocham.DataBindings.Add("text", dgvGiaovien.DataSource, "HocHam");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("text", dgvGiaovien.DataSource, "Sdt");
            cmbMaCV.DataBindings.Clear();
            cmbMaCV.DataBindings.Add("text", dgvGiaovien.DataSource, "MaCV");
            txtTinhtrang.DataBindings.Clear();
            txtTinhtrang.DataBindings.Add("text", dgvGiaovien.DataSource, "Tinhtrang");
        }
        void loadcontrolMaGV()
        {
            cmbMaGV.DataSource = Model.Giaovienmod.FillDataSet_spgetMaGV().Tables[0];
            cmbMaGV.DisplayMember = "MaGV";
            cmbMaGV.ValueMember = "Magiaovien";
        }
        void loadcontrolMaMon()
        {
            cmbMaMon.DataSource = Model.Giaovienmod.FillDataSet_spgetMaMon().Tables[0];
            cmbMaMon.DisplayMember = "MaMon";
            cmbMaMon.ValueMember = "MaMon";
        }
        void loadcontrolMaCV()
        {
            cmbMaCV.DataSource = Model.Giaovienmod.FillDataSet_spgetMaCV().Tables[0];
            cmbMaCV.DisplayMember = "MaCV";
            cmbMaCV.ValueMember = "MaCV";
        }
        void loadcontrolGioitinh()
        {
            cmbGioitinh.Items.Clear();
            cmbGioitinh.Items.Add("Nam");
            cmbGioitinh.Items.Add("Nữ");
        }
        void dis_end(bool e)
        {
            cmbMaGV.Enabled = e;
            
            btnhuy.Enabled = e;
            btnluu.Enabled = e;
            btnthem.Enabled = !e;
            btnsua.Enabled = !e;
            btnxoa.Enabled = !e;

        }
        private bool check(String mgv)
        {
            bool check = true;
            foreach(DataGridViewRow row in dgvGiaovien.Rows)
            {
                if (row.Cells[0].Value.ToString().CompareTo (mgv)==0)
                    check= false;
            }
            return check;
        }
        private void Giaovien_Load(object sender, EventArgs e)
        {
            hienthidanhsachGiaovien();
            BindingGV();
            loadcontrolMaGV();
            loadcontrolMaCV();
            loadcontrolGioitinh();
            loadcontrolMaMon();
            dis_end(false);
        }
        void cleardata()
        {
            cmbMaGV.Text = Model.connection.ExcuteScalar(string.Format("select MaGV=dbo.fcgetMagiaovien()"));
            txtHoten.Text = "";
            dtpNgaysinh.Text = "";
            cmbGioitinh.Text = "";
            txtQuequan.Text = "";
            txtHocham.Text = "";
            cmbMaMon.Text = "";
            txtSdt.Text = "";
            txtTinhtrang.Text = "";
            cmbMaCV.Text = "";
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Giaovien_Load(sender, e);
            dis_end(false);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            plag = 0;
            cleardata();
            cmbMaGV.Enabled = false;
            dis_end(true);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            plag = 1;
            dis_end(true);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            dis_end(true);
            string _MaGV = "";
            try
            {
                _MaGV = cmbMaGV.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa???", "xác nhận !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = controller.giaoviencontroller.Deletegiaovien(_MaGV);
                if (i > 0)
                {
                    MessageBox.Show("xóa thành công !!!");
                    hienthidanhsachGiaovien();
                    Giaovien_Load(sender, e);

                }
                else
                {
                    MessageBox.Show("xóa không thành công !!!");
                }
            }
            else
                return;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //if (!check(cmbMaGV.Text))
            //    MessageBox.Show("sssss");

            string _Magiaovien = "";
            try
            {
                _Magiaovien = cmbMaGV.Text;
            }
            catch { }
            string _Hoten = "";
            try
            {
                _Hoten = txtHoten.Text;
            }
            catch { }
            DateTime _Ngaysinh = dtpNgaysinh.Value;
            string _Gioitinh = "";
            try
            {
                _Gioitinh = cmbGioitinh.Text;
            }
            catch { }
            string _Hocham = "";
            try
            {
                _Hocham = txtHocham.Text;
            }
            catch { }
            string _MaMon = "";
            try
            {
                _MaMon = cmbMaMon.Text;
            }
            catch { }
            string _Quequan = "";
            try
            {
                _Quequan = txtQuequan.Text;
            }
            catch { }
            string _Sdt = "";
            try
            {
                _Sdt = txtSdt.Text;
            }
            catch { }
            string _MaCV = "";
            try
            {
                _MaCV = cmbMaCV.Text;
            }
            catch { }
            string _Tinhtrang = "";
            try
            {
                _Tinhtrang = txtTinhtrang.Text;
            }
            catch { }
            if (plag == 0)
            {
                //them moi 
              
                if (_Magiaovien == "" || _Hoten == "")
                {
                    MessageBox.Show("hãy điền đầy đủ thông tin !!!");
                }
                else
                {
                    int i = 0;
                    i = controller.giaoviencontroller.Insearchgiaovien(_Magiaovien, _Hoten, _Ngaysinh, _Gioitinh, _Quequan, _MaMon, _Hocham, _Sdt, _MaCV, _Tinhtrang);
                     if (i > 0)
                        {
                            MessageBox.Show("thêm mới thành công ");
                            hienthidanhsachGiaovien();
                        }
                        else
                        {
                        MessageBox.Show("thêm mới KHÔNG thành công !!! bạn phải ghi rõ chức vụ ");
                    }                                                 
                }
            }
            else
            {   //sua
                int i = 0;
                i = controller.giaoviencontroller.Updategiaovien(_Magiaovien, _Hoten, _Ngaysinh, _Gioitinh, _Quequan, _MaMon, _Hocham, _Sdt, _MaCV, _Tinhtrang);
                if (i > 0)
                {
                    MessageBox.Show("sửa thành công ");
                    hienthidanhsachGiaovien();
                    Giaovien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("sửa KHÔNG thành công ");
                }
            }
        }

        private void dgvGiaovien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnxemchucvu_Click(object sender, EventArgs e)
        {
            Chucvu cv = new Chucvu();
            cv.ShowDialog();
        }
    }
}
