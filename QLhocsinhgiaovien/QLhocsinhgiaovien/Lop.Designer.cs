namespace QLhocsinhgiaovien
{
    partial class Lop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenlop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtsoluong = new DevExpress.XtraEditors.TextEdit();
            this.cmbMalop = new System.Windows.Forms.ComboBox();
            this.dgvlop = new System.Windows.Forms.DataGridView();
            this.cmbMagv = new System.Windows.Forms.ComboBox();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXemgv = new DevExpress.XtraEditors.SimpleButton();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Magiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenlop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlop)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(124, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Lớp";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(128, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mã Lớp";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(321, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Số Lượng HS";
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(193, 48);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(100, 20);
            this.txtTenlop.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(321, 19);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Mã GV";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(409, 46);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 20);
            this.txtsoluong.TabIndex = 2;
            // 
            // cmbMalop
            // 
            this.cmbMalop.FormattingEnabled = true;
            this.cmbMalop.Location = new System.Drawing.Point(193, 19);
            this.cmbMalop.Name = "cmbMalop";
            this.cmbMalop.Size = new System.Drawing.Size(100, 21);
            this.cmbMalop.TabIndex = 3;
            // 
            // dgvlop
            // 
            this.dgvlop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Malop,
            this.Tenlop,
            this.Magiaovien,
            this.SoLuong});
            this.dgvlop.Location = new System.Drawing.Point(12, 188);
            this.dgvlop.Name = "dgvlop";
            this.dgvlop.Size = new System.Drawing.Size(599, 150);
            this.dgvlop.TabIndex = 4;
            // 
            // cmbMagv
            // 
            this.cmbMagv.FormattingEnabled = true;
            this.cmbMagv.Location = new System.Drawing.Point(409, 17);
            this.cmbMagv.Name = "cmbMagv";
            this.cmbMagv.Size = new System.Drawing.Size(100, 21);
            this.cmbMagv.TabIndex = 3;
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(475, 125);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 5;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(382, 125);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 6;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(287, 125);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(197, 125);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(103, 125);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnXemgv
            // 
            this.btnXemgv.Location = new System.Drawing.Point(515, 14);
            this.btnXemgv.Name = "btnXemgv";
            this.btnXemgv.Size = new System.Drawing.Size(75, 23);
            this.btnXemgv.TabIndex = 5;
            this.btnXemgv.Text = "Xem GV";
            this.btnXemgv.Click += new System.EventHandler(this.btnXemgv_Click);
            // 
            // Malop
            // 
            this.Malop.DataPropertyName = "Malop";
            this.Malop.HeaderText = "Mã Lớp";
            this.Malop.Name = "Malop";
            // 
            // Tenlop
            // 
            this.Tenlop.DataPropertyName = "Tenlop";
            this.Tenlop.HeaderText = "Tên Lớp";
            this.Tenlop.Name = "Tenlop";
            // 
            // Magiaovien
            // 
            this.Magiaovien.DataPropertyName = "Magiaovien";
            this.Magiaovien.HeaderText = "Mã Giáo Viên";
            this.Magiaovien.Name = "Magiaovien";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng Học Sinh";
            this.SoLuong.Name = "SoLuong";
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 346);
            this.Controls.Add(this.btnXemgv);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvlop);
            this.Controls.Add(this.cmbMagv);
            this.Controls.Add(this.cmbMalop);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtTenlop);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Name = "Lop";
            this.Text = "Lop";
            this.Load += new System.EventHandler(this.Lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenlop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTenlop;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtsoluong;
        private System.Windows.Forms.ComboBox cmbMalop;
        private System.Windows.Forms.DataGridView dgvlop;
        private System.Windows.Forms.ComboBox cmbMagv;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.SimpleButton btnXemgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Magiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}