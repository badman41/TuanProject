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
using QLhocsinhgiaovien.controller;
using QLhocsinhgiaovien.Model;

namespace QLhocsinhgiaovien
{
    public partial class Phancongday : DevExpress.XtraEditors.XtraForm
    {
        public Phancongday()
        {
            InitializeComponent();
        }
        private string MaGV;
        public void loadDSLop(string tenGV,string maGV)
        {
            //DataTable dt = Model.Giaovienmod.filldatasetGiaovien().Tables[0];
            //cmbGiaoVien.DataSource = dt;
            //cmbGiaoVien.DisplayMember = "Hoten";
            //cmbGiaoVien.ValueMember = "Magiaovien";
            lblTenGV.Text = tenGV;
            MaGV = maGV;

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
            List<Tiet2> lst = pcc.lstLichDay2;
            string []a = new string[2];
            int[,] t = new int[12,7];
            foreach(DataRow dr in dt.Rows)
            {
                a = dr[0].ToString().Split('-');
                if (a[0] == "T2")
                {
                    int tiet = int.Parse(a[1]);
                    if (tiet > 0 && tiet < 13)
                    {
                        lst[tiet - 1].T2 = true;
                        t[tiet - 1, 1] = 1;
                    }
                }
                if (a[0] == "T3")
                {
                    int tiet = int.Parse(a[1]);
                    if (tiet > 0 && tiet < 13)
                    {
                        lst[tiet - 1].T3 = true;
                        t[tiet - 1, 2] = 1;
                    }
                }
                if (a[0] == "T4")
                {
                    int tiet = int.Parse(a[1]);
                    if (tiet > 0 && tiet < 13)
                    {
                        lst[tiet - 1].T4 = true;
                        t[tiet - 1, 3] = 1;
                    }
                }
                if (a[0] == "T5")
                {
                    int tiet = int.Parse(a[1]);
                    if (tiet > 0 && tiet < 13)
                    {
                        lst[tiet - 1].T5 = true;
                        t[tiet - 1, 4] = 1;
                    }

                }
                if (a[0] == "T6")
                {
                    int tiet = int.Parse(a[1]);
                    if (tiet > 0 && tiet < 13)
                    {
                        lst[tiet - 1].T6 = true;
                        t[tiet - 1, 5] = 1;
                    }
                }
                if (a[0] == "T7")
                {
                    int tiet = int.Parse(a[1]);
                    if (tiet > 0 && tiet < 13)
                    {
                        lst[tiet - 1].T7 = true;
                        t[tiet - 1, 6] = 1;
                    }
                }

            }
       
            dgvphancongday.DataSource = lst;
            for(int i = 0; i < 12; i++)
            {
                for(int j = 1; j < 7; j++)
                {
                    if (t[i, j] == 1)
                    {
                        dgvphancongday.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                        dgvphancongday.Rows[i].Cells[j].ReadOnly = true;
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
            loadlichDayTheoGVvsLop(MaGV);
            
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //string ma = cmbGiaoVien.SelectedValue.ToString().Trim();
            //    loadlichDayTheoGVvsLop(ma);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {


            int dem = 0;

            foreach (DataGridViewRow dr in dgvphancongday.Rows)
            {
                
                    dem++;

                for (int i = 1; i < 7; i++)
                {

                    if (dr.Cells[i].Value.ToString() == "True")
                    {
                       
                        Phancongdaymod pc = new Phancongdaymod()
                        {
                            Magiaovien = MaGV,
                            Malop = cmbLop.SelectedValue.ToString(),

                            Lichday = dgvphancongday.Columns[i].Name.ToString() + "-" + dr.Cells[0].Value.ToString()

                        };
                        
                        new PhancongdayController().ThemLichday(pc);
                       

                    }

                }

              
            }
            XtraMessageBox.Show("thêm lịch dạy thành công");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}