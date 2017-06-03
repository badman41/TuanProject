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

namespace DXApplication1.View._UC
{
    public partial class HangHoa : UserControl
    {
        HangHoaController hh = new HangHoaController();
        int choice = 0;
        public HangHoa()
        {
            InitializeComponent();
            dataGridViewX1.DataSource = hh.GetAllHangHoa();
            comboBoxEx2.DataSource = (new NhomHangController()).GetList();
            comboBoxEx2.DisplayMember = "TenNhom";
            comboBoxEx2.ValueMember = "MaNhom";
            comboBoxEx1.DataSource = (new NhaCCController()).GetList();
            comboBoxEx1.DisplayMember = "TenNCC";
            comboBoxEx1.ValueMember = "MaNCC";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Enable(true);
            dataGridViewX1.DataSource = hh.GetAllHangHoa();
            String idLast = dataGridViewX1.Rows[dataGridViewX1.Rows.Count - 1].Cells[0].Value.ToString();
            textBoxX3.Text = "HH" + (Convert.ToInt32(idLast.Remove(0, 2)) + 1);
            textBoxX2.Text = "";
            textBoxX1.Text = "";
            textBoxX4.Text = "";
            textBoxX5.Text = "";
            textBoxX6.Text = "";
            choice = 1;
        }
        private void Enable(bool s)
        {
            toolStripButton1.Enabled = !s;
            toolStripButton2.Enabled = !s;
            toolStripButton2.Enabled = !s;
            toolStripButton3.Enabled = !s;
            toolStripButton4.Enabled = s;
            toolStripButton5.Enabled = s;
            textBoxX1.Enabled = s;
            textBoxX2.Enabled = s;
            //  textBoxX3.Enabled = s;
            textBoxX4.Enabled = s;
            textBoxX5.Enabled = s;
            textBoxX6.Enabled = s;
            comboBoxEx1.Enabled = s;
            comboBoxEx2.Enabled = s;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            HANGHOA hanghoa = new HANGHOA();
            hanghoa.MaHH = textBoxX3.Text;
            hanghoa.TenHH = textBoxX2.Text;
            hanghoa.NoiSX = textBoxX1.Text;
            hanghoa.MaNCC = comboBoxEx1.SelectedValue.ToString();
            hanghoa.DonGia = textBoxX6.Text;
            hanghoa.DonGiaBan = textBoxX5.Text;
            hanghoa.DonVi = textBoxX4.Text;
            hanghoa.MaNhom = comboBoxEx2.SelectedValue.ToString(); ;
            if (choice == 1)
            {
                //them
                hh.InsertHangHoa(hanghoa);
                MessageBox.Show("Yes");
            }
            if (choice == 2)
            {
                //sua
                hh.UpdateHangHoa(hanghoa);
                MessageBox.Show("Yes");
            }
            dataGridViewX1.DataSource = hh.GetAllHangHoa();
            Enable(false);

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Enable(false);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Enable(true);
            toolStripButton1.Enabled = false;
            choice = 2;
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cells = dataGridViewX1.CurrentRow.Cells;
            textBoxX3.Text = cells[0].Value.ToString();
            textBoxX2.Text = cells[1].Value.ToString();
            textBoxX1.Text = cells[2].Value.ToString();
            textBoxX4.Text = cells[3].Value.ToString();
            textBoxX5.Text = cells[4].Value.ToString();
            textBoxX6.Text = cells[5].Value.ToString();
            comboBoxEx1.SelectedValue = cells[6].Value;
            comboBoxEx2.SelectedValue = cells[7].Value;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                hh.DeleteHangHoa(textBoxX3.Text);
                MessageBox.Show("Thanh cong");
                dataGridViewX1.DataSource = hh.GetAllHangHoa();
            }


        }
    }
}
