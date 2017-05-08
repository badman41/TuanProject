namespace QLhocsinhgiaovien
{
    partial class Phancongday
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dgvphancongday = new System.Windows.Forms.DataGridView();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.T3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.T4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.T5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.T6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.T7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphancongday)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblTenGV);
            this.groupControl1.Controls.Add(this.cmbLop);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(710, 187);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Chi Tiết Phân Công Dạy";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(100, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Giáo Viên";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(240, 150);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Hủy";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(148, 150);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Lưu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dgvphancongday
            // 
            this.dgvphancongday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvphancongday.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvphancongday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvphancongday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphancongday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tiet,
            this.T2,
            this.T3,
            this.T4,
            this.T5,
            this.T6,
            this.T7});
            this.dgvphancongday.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvphancongday.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgvphancongday.Location = new System.Drawing.Point(0, 205);
            this.dgvphancongday.Name = "dgvphancongday";
            this.dgvphancongday.Size = new System.Drawing.Size(734, 297);
            this.dgvphancongday.TabIndex = 2;
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(166, 78);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(121, 21);
            this.cmbLop.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(100, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Lớp";
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Location = new System.Drawing.Point(166, 40);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(35, 13);
            this.lblTenGV.TabIndex = 15;
            this.lblTenGV.Text = "label1";
            // 
            // Tiet
            // 
            this.Tiet.DataPropertyName = "Tiết";
            this.Tiet.HeaderText = "Tiết";
            this.Tiet.Name = "Tiet";
            this.Tiet.ReadOnly = true;
            // 
            // T2
            // 
            this.T2.DataPropertyName = "T2";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.NullValue = false;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Red;
            this.T2.DefaultCellStyle = dataGridViewCellStyle13;
            this.T2.HeaderText = "Thứ 2";
            this.T2.Name = "T2";
            // 
            // T3
            // 
            this.T3.DataPropertyName = "T3";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.NullValue = false;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Red;
            this.T3.DefaultCellStyle = dataGridViewCellStyle14;
            this.T3.HeaderText = "Thứ 3";
            this.T3.Name = "T3";
            // 
            // T4
            // 
            this.T4.DataPropertyName = "T4";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = false;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Red;
            this.T4.DefaultCellStyle = dataGridViewCellStyle15;
            this.T4.HeaderText = "Thứ 4";
            this.T4.Name = "T4";
            this.T4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.T4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // T5
            // 
            this.T5.DataPropertyName = "T5";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.NullValue = false;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Red;
            this.T5.DefaultCellStyle = dataGridViewCellStyle16;
            this.T5.HeaderText = "Thứ 5";
            this.T5.Name = "T5";
            this.T5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.T5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // T6
            // 
            this.T6.DataPropertyName = "T6";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.NullValue = false;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Red;
            this.T6.DefaultCellStyle = dataGridViewCellStyle17;
            this.T6.HeaderText = "Thứ 6";
            this.T6.Name = "T6";
            this.T6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.T6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // T7
            // 
            this.T7.DataPropertyName = "T7";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.NullValue = false;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Red;
            this.T7.DefaultCellStyle = dataGridViewCellStyle18;
            this.T7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.T7.HeaderText = "Thứ 7";
            this.T7.Name = "T7";
            this.T7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.T7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Phancongday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 502);
            this.Controls.Add(this.dgvphancongday);
            this.Controls.Add(this.groupControl1);
            this.Name = "Phancongday";
            this.Text = "Phancongday";
            this.Load += new System.EventHandler(this.Phancongday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphancongday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridView dgvphancongday;
        private System.Windows.Forms.ComboBox cmbLop;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn T2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn T3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn T4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn T5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn T6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn T7;
    }
}