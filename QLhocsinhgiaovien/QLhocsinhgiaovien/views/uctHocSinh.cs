using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLhocsinhgiaovien.views
{
    public partial class uctHocSinh : UserControl
    {
        public uctHocSinh()
        {
            InitializeComponent();
        }
        int plag = 0;
        public static uctHocSinh uctHS = new uctHocSinh();// tạo mới form
        public void hienthidanhsachhocsinh()
        {
            // tro toi data     
            dgvHocSinh.DataSource = Model.Hocsinhmod.filldatasethocsinh().Tables[0];
            dgvHocSinh.BorderStyle = BorderStyle.Fixed3D;
            // dgvHocSinh.Dock = DockStyle.Fill;
            dgvHocSinh.RowHeadersVisible = false;
        }
        void BindingHS()
        {
            cmbMaHS.DataBindings.Clear();
            cmbMaHS.DataBindings.Add("text", dgvHocSinh.DataSource, "MaHS");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("text", dgvHocSinh.DataSource, "Hoten");
            cmbGioitinh.DataBindings.Clear();
            cmbGioitinh.DataBindings.Add("text", dgvHocSinh.DataSource, "Gioitinh");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("text", dgvHocSinh.DataSource, "Ngaysinh");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("text", dgvHocSinh.DataSource, "Diachi");
            cmbMaLop.DataBindings.Clear();
            cmbMaLop.DataBindings.Add("text", dgvHocSinh.DataSource, "Malop");
        }
        void loadcontrolMaHS()
        {
            cmbMaHS.DataSource = Model.Hocsinhmod.FillDataSet_spgetMaHS().Tables[0];
            cmbMaHS.DisplayMember = "MaHS";
            cmbMaHS.ValueMember = "MaHS";
        }
        void loadcontrolMalop()
        {
            cmbMaLop.DataSource = Model.Hocsinhmod.FillDataSet_spgetMalop().Tables[0];
            cmbMaLop.DisplayMember = "Malop";
            cmbMaLop.ValueMember = "Malop";
        }
        void loadcontrolGioitinh()
        {
            cmbGioitinh.Items.Clear();
            cmbGioitinh.Items.Add("Nam");
            cmbGioitinh.Items.Add("Nữ");
        }
        private void uctHocSinh_Load(object sender, EventArgs e)
        {
            hienthidanhsachhocsinh();
            BindingHS();
            loadcontrolMaHS();
            loadcontrolMalop();
            loadcontrolGioitinh();
            dis_end(false);

        }
        void dis_end(bool e)
        {
            cmbMaHS.Enabled = e;

            btnhuy.Enabled = e;
            btnLuu.Enabled = e;
            btnthem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;

        }
        void cleardata()
        {
            cmbMaHS.Text = Model.connection.ExcuteScalar(string.Format("select MaHS=dbo.fcgetMahocsinh()"));
            txtHoten.Text = "";
            dtpNgaySinh.Text = "";
            cmbGioitinh.Text = "";
            txtDiachi.Text = "";
            cmbMaLop.Text = "";     
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            plag = 1;
            dis_end(true);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            uctHocSinh_Load(sender, e);
            dis_end(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaHS = "";
            try
            {
                _MaHS = cmbMaHS.Text;
            }
            catch { }
            string _Hoten = "";
            try
            {
                _Hoten = txtHoten.Text;
            }
            catch { }
            DateTime _Ngaysinh = dtpNgaySinh.Value;
            string _Gioitinh = "";
            try
            {
                _Gioitinh = cmbGioitinh.Text;
            }
            catch { }
            string _Diachi = "";
            try
            {
                _Diachi = txtDiachi.Text;
            }
            catch { }
            string _Malop = "";
            try
            {
                _Malop = cmbMaLop.Text;
            }
            catch { }
            if (plag == 0)
            {
                //them moi 
                if (_MaHS == "" || _Hoten == "")
                {
                    MessageBox.Show("hãy điền đầy đủ thông tin !!!");
                }
                else
                {
                    int i = 0;
                    i = controller.hocsinhcontroller.Insearchhocsinh(_MaHS, _Hoten, _Ngaysinh, _Gioitinh, _Diachi, _Malop);
                    if (i > 0)
                    {
                        MessageBox.Show("thêm mới thành công ");
                        hienthidanhsachhocsinh();
                    }
                    else
                       {           //xét xem đã có MaHS trong csdl hay chưa
                                    //if ()
                                    //{

                                    //}
                        MessageBox.Show("thêm mới KHÔNG thành công ,hãy chọn lớp cho học sinh !!!");
                    }
                }
            }
            else
            {   //sua
                int i = 0;
                i = controller.hocsinhcontroller.Updatehocsinh(_MaHS, _Hoten, _Ngaysinh, _Gioitinh, _Diachi, _Malop);
                if (i > 0)
                {
                    MessageBox.Show("sửa thành công ");
                    hienthidanhsachhocsinh();
                    uctHocSinh_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("sửa KHÔNG thành công ");
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            plag = 0;
            cleardata();
            cmbMaHS.Enabled = false;
            dis_end(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dis_end(true);
            string _MaHS = "";
            try
            {
                _MaHS = cmbMaHS.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa???", "xác nhận !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = controller.hocsinhcontroller.Deletehocsinh(_MaHS);
                if (i > 0)
                {
                    MessageBox.Show("xóa thành công !!!");
                    hienthidanhsachhocsinh();
                    uctHocSinh_Load(sender, e);

                }
                else
                {
                    MessageBox.Show("xóa không thành công !!!");
                }
            }
            else
                return;
        }

        private void btnXemlop_Click(object sender, EventArgs e)
        {
            Lop l = new Lop();
            l.ShowDialog();
        }
    }
}