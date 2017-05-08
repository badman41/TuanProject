namespace QLhocsinhgiaovien
{
    partial class Chucvu
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbmacv = new System.Windows.Forms.ComboBox();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txttenchucvu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvchucvu = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttenchucvu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchucvu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(630, 155);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbmacv);
            this.groupControl1.Controls.Add(this.btnhuy);
            this.groupControl1.Controls.Add(this.btnluu);
            this.groupControl1.Controls.Add(this.btnxoa);
            this.groupControl1.Controls.Add(this.btnsua);
            this.groupControl1.Controls.Add(this.btnthem);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txttenchucvu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(620, 145);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chi Tiết Chức Vụ";
            // 
            // cmbmacv
            // 
            this.cmbmacv.FormattingEnabled = true;
            this.cmbmacv.Location = new System.Drawing.Point(123, 41);
            this.cmbmacv.Name = "cmbmacv";
            this.cmbmacv.Size = new System.Drawing.Size(121, 21);
            this.cmbmacv.TabIndex = 3;
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(443, 94);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 2;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(350, 94);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(255, 94);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(165, 94);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(71, 94);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(313, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tên Chức Vụ";
            // 
            // txttenchucvu
            // 
            this.txttenchucvu.Location = new System.Drawing.Point(405, 38);
            this.txttenchucvu.Name = "txttenchucvu";
            this.txttenchucvu.Size = new System.Drawing.Size(100, 20);
            this.txttenchucvu.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(60, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã Chức Vụ";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvchucvu);
            this.panelControl2.Location = new System.Drawing.Point(12, 173);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(630, 198);
            this.panelControl2.TabIndex = 1;
            // 
            // dgvchucvu
            // 
            this.dgvchucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchucvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV});
            this.dgvchucvu.Location = new System.Drawing.Point(5, 5);
            this.dgvchucvu.Name = "dgvchucvu";
            this.dgvchucvu.Size = new System.Drawing.Size(620, 188);
            this.dgvchucvu.TabIndex = 0;
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã Chức Vụ";
            this.MaCV.Name = "MaCV";
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Tên Chức Vụ";
            this.TenCV.Name = "TenCV";
            // 
            // Chucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 383);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Chucvu";
            this.Text = "Chucvu";
            this.Load += new System.EventHandler(this.Chucvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttenchucvu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchucvu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txttenchucvu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dgvchucvu;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.ComboBox cmbmacv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
    }
}