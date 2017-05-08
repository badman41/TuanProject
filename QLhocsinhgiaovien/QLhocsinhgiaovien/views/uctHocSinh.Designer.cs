namespace QLhocsinhgiaovien.views
{
    partial class uctHocSinh
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
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.cmbMaHS = new System.Windows.Forms.ComboBox();
            this.cmbGioitinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnXemlop = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.Hoten,
            this.Ngaysinh,
            this.Gioitinh,
            this.Diachi,
            this.Malop});
            this.dgvHocSinh.Location = new System.Drawing.Point(4, 194);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(865, 215);
            this.dgvHocSinh.TabIndex = 0;
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "MaHS";
            this.MaHS.Name = "MaHS";
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Hoten";
            this.Hoten.Name = "Hoten";
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngaysinh";
            this.Ngaysinh.Name = "Ngaysinh";
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Gioitinh";
            this.Gioitinh.Name = "Gioitinh";
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Diachi";
            this.Diachi.Name = "Diachi";
            // 
            // Malop
            // 
            this.Malop.DataPropertyName = "Malop";
            this.Malop.HeaderText = "Malop";
            this.Malop.Name = "Malop";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(578, 160);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(335, 160);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(416, 160);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(254, 160);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemlop);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.cmbMaLop);
            this.groupBox1.Controls.Add(this.cmbMaHS);
            this.groupBox1.Controls.Add(this.cmbGioitinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(98, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(158, 81);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(83, 20);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(158, 54);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(154, 20);
            this.txtHoten.TabIndex = 2;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(465, 27);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(100, 20);
            this.txtDiachi.TabIndex = 2;
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(465, 53);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(83, 21);
            this.cmbMaLop.TabIndex = 1;
            // 
            // cmbMaHS
            // 
            this.cmbMaHS.FormattingEnabled = true;
            this.cmbMaHS.Location = new System.Drawing.Point(158, 25);
            this.cmbMaHS.Name = "cmbMaHS";
            this.cmbMaHS.Size = new System.Drawing.Size(83, 21);
            this.cmbMaHS.TabIndex = 1;
            // 
            // cmbGioitinh
            // 
            this.cmbGioitinh.FormattingEnabled = true;
            this.cmbGioitinh.Location = new System.Drawing.Point(158, 108);
            this.cmbGioitinh.Name = "cmbGioitinh";
            this.cmbGioitinh.Size = new System.Drawing.Size(83, 21);
            this.cmbGioitinh.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "MaHS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Học Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(497, 160);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 1;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnXemlop
            // 
            this.btnXemlop.Location = new System.Drawing.Point(576, 54);
            this.btnXemlop.Name = "btnXemlop";
            this.btnXemlop.Size = new System.Drawing.Size(75, 23);
            this.btnXemlop.TabIndex = 4;
            this.btnXemlop.Text = "Xem Lớp";
            this.btnXemlop.Click += new System.EventHandler(this.btnXemlop_Click);
            // 
            // uctHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvHocSinh);
            this.Name = "uctHocSinh";
            this.Size = new System.Drawing.Size(872, 421);
            this.Load += new System.EventHandler(this.uctHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.ComboBox cmbGioitinh;
        private System.Windows.Forms.ComboBox cmbMaHS;
        private System.Windows.Forms.Button btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnXemlop;
    }
}
