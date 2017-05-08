using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLhocsinhgiaovien.controller;
using QLhocsinhgiaovien.Model;
using DevExpress.XtraEditors;
using DemoDataGridView;

namespace QLhocsinhgiaovien.views
{
    public partial class UCPhanCongDay : UserControl
    {
        public UCPhanCongDay()
        {
            InitializeComponent();
        }

        private int check = 0;
        public void loadDSGV()
        {
            DataTable dt = Model.Giaovienmod.filldatasetGiaovien().Tables[0];
            cmbGiaoVien.DataSource = dt;
            cmbGiaoVien.DisplayMember = "Hoten";
            cmbGiaoVien.ValueMember = "Magiaovien";

            DataTable dt2 = Model.lopmod.filldatasetlop().Tables[0];
            cmbLop.DataSource = dt2;
            cmbLop.DisplayMember = "Tenlop";
            cmbLop.ValueMember = "Malop";

        }
        public void loadlichDayTheoGV(string maGV)
        {
            dgvphancongday.DataSource = new PhancongdayController().LayDSlichDay(maGV).Tables[0];
        }
        public void loadlichDayTheoGVvsLop(string maGV)
        {
            PhancongdayController pcc = new PhancongdayController();
            DataTable dt = new PhancongdayController().LayDSlichDay(maGV).Tables[0];
            List<Tiet> lst = pcc.lstLichDay;
            string[] a = new string[2];
            int[,] t = new int[12, 7];
            foreach (DataRow dr in dt.Rows)
            {
                a = dr[0].ToString().Split('-');
                if (a[0] == "T2")
                {
                    int tiet = int.Parse(a[1]);
                    if (tiet > 0 && tiet < 13)
                    {
                        lst[tiet - 1].T2 = dr[1].ToString();
                        t[tiet - 1, 1] = 1;
                    }
                }
                if (a[0] == "T3")
                {
                    int tiet = int.Parse(a[1]);
                    if (tiet > 0 && tiet < 13)
                    {
                        lst[tiet-1].T3 = dr[1].ToString();
                        t[tiet-1, 2] = 1;
                    }
                }
                if (a[0] == "T4")
                {
                    int tiet = int.Parse(a[1]);
                    if (tiet > 0 && tiet < 13)
                    {
                        lst[tiet - 1].T4 = dr[1].ToString();
                        t[tiet - 1, 3] = 1;
                    }
                }
                if (a[0] == "T5")
                {
                    int tiet = int.Parse(a[1]);
                    if (tiet > 0 && tiet < 13)
                    {
                        lst[tiet - 1].T5 = dr[1].ToString();
                        t[tiet - 1, 4] = 1;
                    }

                }
                if (a[0] == "T6")
                {
                    int tiet = int.Parse(a[1]);
                    if (tiet > 0 && tiet < 13)
                    {
                        lst[tiet - 1].T6 = dr[1].ToString();
                        t[tiet - 1, 5] = 1;
                    }
                }
                if (a[0] == "T7")
                {
                    int tiet = int.Parse(a[1]);
                    if (tiet > 0 && tiet < 13)
                    {
                        lst[tiet - 1].T7 = dr[1].ToString();
                        t[tiet - 1, 6] = 1;
                    }
                }

            }
            dgvphancongday.DataSource = lst;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    if (t[i, j] == 1)
                    {
                        dgvphancongday.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                    }
                }
            }

            //dgvphancongday.Columns.Add("Tiet", "Tiết");
            //for (int i = 1; i < 13; i++)
            //{
            //    dgvphancongday.Rows[i - 1].Cells[0]. = i.ToString();
            //}
        }
        private void Phancongday_Load(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            string ma = cmbGiaoVien.SelectedValue.ToString().Trim();
            loadlichDayTheoGVvsLop(ma);
            simpleButton1.Enabled = true;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Phancongday pcc = new Phancongday();
            pcc.loadDSLop(cmbGiaoVien.Text, cmbGiaoVien.SelectedValue.ToString());
            pcc.ShowDialog();
            string ma = cmbGiaoVien.SelectedValue.ToString().Trim();
            loadlichDayTheoGVvsLop(ma);
        }

        private void dgvphancongday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell dg = dgvphancongday.CurrentCell;
            int n = 0;
            lblThu.Text = dgvphancongday.Columns[dg.ColumnIndex].Name.ToString().Trim();
            lblTiet.Text = dgvphancongday.Rows[dg.RowIndex].Cells[0].Value.ToString().Trim();
            if (int.TryParse(dg.Value.ToString(),out n))
            {
                
            }
           else cmbLop.Text = dg.Value.ToString().Trim(); 

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            cmbLop.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXem.Enabled = false;
            btnHuy.Enabled = true;
            cmbGiaoVien.Enabled = false;
            check = 1;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXem.Enabled = false;
            btnHuy.Enabled = true;
            cmbGiaoVien.Enabled = false;
            check = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check == 2)
            {
                if (lblThu.Text == "" || lblTiet.Text == ""||cmbLop.Text=="_")
                {
                    MessageBox.Show("Chọn 1 lịch dạy để xóa");
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn xóa lịch dạy lớp " + cmbLop.Text + " vào " + lblThu.Text + " tiết " + lblTiet.Text + "?", "Hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        new PhancongdayController().XoalichDay(cmbGiaoVien.SelectedValue.ToString().Trim(), lblThu.Text.Trim() + "-" + lblTiet.Text.Trim());
                        XtraMessageBox.Show("Xóa thành công");
                        loadlichDayTheoGVvsLop(cmbGiaoVien.SelectedValue.ToString());
                    }
                    lblThu.Text = "";
                    lblTiet.Text = "";
                }
              
            }
            if (check == 1)
            {
                if (lblThu.Text == "" || lblTiet.Text == "")
                {
                    MessageBox.Show("Chọn 1 lịch dạy để sửa");
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn sửa lịch dạy lớp vào " + lblThu.Text + " tiết " + lblTiet.Text + "?", "Hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Phancongdaymod pcm = new Phancongdaymod()
                        {
                            Magiaovien = cmbGiaoVien.SelectedValue.ToString().Trim(),
                            Malop = cmbLop.SelectedValue.ToString().Trim(),
                            Lichday = lblThu.Text.Trim() + "-" + lblTiet.Text.Trim()
                        };
                        new PhancongdayController().SuaLichday(pcm);
                        MessageBox.Show("Sửa thành công");
                        loadlichDayTheoGVvsLop(cmbGiaoVien.SelectedValue.ToString());
                    }
                }
               

            }
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXem.Enabled = true;
            btnXoa.Enabled = true;
            cmbGiaoVien.Enabled = true;
            btnHuy.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXem.Enabled = true;
            btnXoa.Enabled = true;
            cmbGiaoVien.Enabled = true;
            btnHuy.Enabled = false;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            // Lấy về nguồn dữ liệu cần Export là 1 DataTable
            // DataTable này mỗi bạn lấy mỗi khác. 
            // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
            // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
            // DataGridView nhé 
            //DataTable dt = (DataTable)dgvphancongday.DataSource;
            excel.Export(dgvphancongday, "Danh sach", "lỊCH DẠY CỦA GIÁO VIÊN :"+cmbGiaoVien.Text);
        }
    }
}
