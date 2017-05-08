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

namespace QLhocsinhgiaovien
{
    public partial class Chucvu : DevExpress.XtraEditors.XtraForm
    {
        public Chucvu()
        {
            InitializeComponent();
        }
        int plag = 0;
        public void hienthidanhsachchucvu()
        {
            // tro toi data     
            dgvchucvu.DataSource = Model.Giaovienmod.filldatasetChucVu().Tables[0];
            dgvchucvu.BorderStyle = BorderStyle.Fixed3D;
            dgvchucvu.RowHeadersVisible = false;

        }
        void BindingCV()
        {
            cmbmacv.DataBindings.Clear();
            cmbmacv.DataBindings.Add("text", dgvchucvu.DataSource, "MaCV");
            txttenchucvu.DataBindings.Clear();
            txttenchucvu.DataBindings.Add("text", dgvchucvu.DataSource, "TenCV");
        }
        void loadcontrolMaCV()
        {
            cmbmacv.DataSource = Model.Giaovienmod.filldatasetChucVu().Tables[0];
            cmbmacv.DisplayMember = "MaCV";
            cmbmacv.ValueMember = "MaCV";
        }
        private void Chucvu_Load(object sender, EventArgs e)
        {
            hienthidanhsachchucvu();
            loadcontrolMaCV();
            BindingCV();
            dis_end(false);
        }
        void dis_end(bool e)
        {          
            btnhuy.Enabled = e;
            btnluu.Enabled = e;
            btnthem.Enabled = !e;
            btnsua.Enabled = !e;
            btnxoa.Enabled = !e;
        }
        void cleardata()
        {
            cmbmacv.Text = "";
            txttenchucvu.Text = "";          
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            plag = 0;
            cleardata();
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
            string _MaCV = "";
            try
            {
                _MaCV = cmbmacv.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa???", "xác nhận !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = controller.chucvucontroller.DeleteChucvu(_MaCV);
                if (i > 0)
                {
                    MessageBox.Show("xóa thành công !!!");
                    hienthidanhsachchucvu();
                    Chucvu_Load(sender, e);

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
            string _MaCV = "";
            try
            {
                _MaCV = cmbmacv.Text;
            }
            catch { }
            string _TenCV = "";
            try
            {
                _TenCV = txttenchucvu.Text;
            }
            catch { }        
            if (plag == 0)
            {
                //them moi 

                if (_MaCV == "" || _TenCV == "")
                {
                    MessageBox.Show("hãy điền đầy đủ thông tin !!!");
                }
                else
                {
                    int i = 0;
                    i = controller.chucvucontroller.Insearchchucvu(_MaCV,_TenCV);
                    if (i > 0)
                    {
                        MessageBox.Show("thêm mới thành công ");
                        hienthidanhsachchucvu();
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
                i = controller.chucvucontroller.Updatechucvu(_MaCV, _TenCV);
                if (i > 0)
                {
                    MessageBox.Show("sửa thành công ");
                    hienthidanhsachchucvu();
                    Chucvu_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("sửa KHÔNG thành công ");
                }
            }

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Chucvu_Load(sender, e);
            dis_end(false);
        }
    }
}