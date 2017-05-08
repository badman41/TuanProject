namespace QLhocsinhgiaovien.views
{
    partial class UCPhanCongDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvphancongday = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbGiaoVien = new System.Windows.Forms.ComboBox();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.lblThu = new System.Windows.Forms.Label();
            this.lblTiet = new System.Windows.Forms.Label();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphancongday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvphancongday
            // 
            this.dgvphancongday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvphancongday.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvphancongday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvphancongday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphancongday.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvphancongday.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgvphancongday.Location = new System.Drawing.Point(0, 216);
            this.dgvphancongday.Name = "dgvphancongday";
            this.dgvphancongday.Size = new System.Drawing.Size(936, 323);
            this.dgvphancongday.TabIndex = 4;
            this.dgvphancongday.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphancongday_CellContentClick);
            this.dgvphancongday.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphancongday_CellContentClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.lblTiet);
            this.groupControl1.Controls.Add(this.lblThu);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.cmbLop);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cmbGiaoVien);
            this.groupControl1.Controls.Add(this.btnXem);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Location = new System.Drawing.Point(32, 16);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(869, 174);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Chi Tiết Phân Công Dạy";
            // 
            // cmbGiaoVien
            // 
            this.cmbGiaoVien.FormattingEnabled = true;
            this.cmbGiaoVien.Location = new System.Drawing.Point(194, 45);
            this.cmbGiaoVien.Name = "cmbGiaoVien";
            this.cmbGiaoVien.Size = new System.Drawing.Size(121, 21);
            this.cmbGiaoVien.TabIndex = 11;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(194, 102);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem lịch dạy";
            this.btnXem.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(100, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Giáo Viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(262, 146);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(181, 146);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(100, 146);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmbLop
            // 
            this.cmbLop.Enabled = false;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(598, 113);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(121, 21);
            this.cmbLop.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(527, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(21, 15);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Lớp";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(521, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 15);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Thứ:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(526, 80);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(21, 15);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Tiết";
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(426, 146);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Luu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblThu
            // 
            this.lblThu.AutoSize = true;
            this.lblThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblThu.Location = new System.Drawing.Point(595, 41);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(0, 13);
            this.lblThu.TabIndex = 19;
            // 
            // lblTiet
            // 
            this.lblTiet.AutoSize = true;
            this.lblTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTiet.Location = new System.Drawing.Point(595, 80);
            this.lblTiet.Name = "lblTiet";
            this.lblTiet.Size = new System.Drawing.Size(0, 13);
            this.lblTiet.TabIndex = 20;
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(345, 146);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Enabled = false;
            this.simpleButton1.Location = new System.Drawing.Point(520, 146);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "Xuất Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // UCPhanCongDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvphancongday);
            this.Controls.Add(this.groupControl1);
            this.Name = "UCPhanCongDay";
            this.Size = new System.Drawing.Size(936, 539);
            this.Load += new System.EventHandler(this.Phancongday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphancongday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvphancongday;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmbGiaoVien;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbLop;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label lblTiet;
        private System.Windows.Forms.Label lblThu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
