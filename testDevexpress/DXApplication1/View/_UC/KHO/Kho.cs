using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication1.Controller;
using Model;
using DXApplication1.Model;

namespace DXApplication1.View._UC
{
    public partial class Kho : UserControl
    {
        private KhoController kho = new KhoController();
        int i = 0;
        public Kho()
        {
            InitializeComponent();
            Controller.NhanVienController nv = new Controller.NhanVienController();
            LoadData();
            DataTable dt = nv.GetAllData();
            comboBoxEx1.DataSource = dt;
            comboBoxEx1.DisplayMember = dt.Columns[1].ColumnName;
            comboBoxEx1.ValueMember = dt.Columns[0].ColumnName;
        }

        private void IsEnable(bool yes)
        {
            toolStripButton2.Enabled = yes;
            toolStripButton3.Enabled = yes;
            toolStripButton4.Enabled = !yes;
            toolStripButton5.Enabled = !yes;
            textBoxX1.Enabled = !yes;
            textBoxX2.Enabled = !yes;
            textBoxX3.Enabled = !yes;
            comboBoxEx1.Enabled = !yes;
        }

        private void LoadData()
        {
            dataGridViewX1.DataSource = kho.getAllKho();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            i = 1;
            textBoxX1.Text = "";
            textBoxX2.Text = "";
            textBoxX3.Text = "";
            IsEnable(false);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (textBoxX3.Text.Equals(""))
            {

                MessageBox.Show("Chua chon");
            }
            i = 2;
            IsEnable(false);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (i==1) {
                //them
                KhoModel k = new KhoModel();
                k.MaKho = textBoxX3.Text;
                k.MaNV = comboBoxEx1.SelectedValue.ToString();
                k.TenKho = textBoxX2.Text;
                k.ViTri = textBoxX1.Text;
                kho.InsertKho(k);
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            if (i == 2)
            {
                //sua
                KhoModel k = new KhoModel();
                k.MaKho = textBoxX3.Text;
                k.MaNV = comboBoxEx1.SelectedValue.ToString();
                k.TenKho = textBoxX2.Text;
                k.ViTri = textBoxX1.Text;
                kho.UpdateKho(k);
                MessageBox.Show("Sửa thành công");
                LoadData();
            }
            IsEnable(true);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            IsEnable(true);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (!textBoxX3.Text.Equals(""))
            {
                kho.DeleteKho(textBoxX3.Text);
                MessageBox.Show("Xóa thành công");
            }
              
            else
                MessageBox.Show("Chua chon kho");
            LoadData();
            IsEnable(false);
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cells = dataGridViewX1.CurrentRow.Cells;
            textBoxX3.Text = cells[0].Value.ToString();
            textBoxX2.Text = cells[1].Value.ToString();
            textBoxX1.Text = cells[2].Value.ToString();
            comboBoxEx1.SelectedValue = cells[3].Value;
        }
    }
}
