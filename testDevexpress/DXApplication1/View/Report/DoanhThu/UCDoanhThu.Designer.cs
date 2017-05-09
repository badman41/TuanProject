namespace DXApplication1.View._UC
{
    partial class UCDoanhThu
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
            this.tabNhanVien = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNV = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grC = new DevExpress.XtraGrid.GridControl();
            this.grV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.cmbXemTheo = new System.Windows.Forms.ComboBox();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNam = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblThang = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnXem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabNhanVien)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            this.tabNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblThang)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.tabNhanVien.Appearance.Options.UseBackColor = true;
            this.tabNhanVien.Controls.Add(this.tabNV);
            this.tabNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabNhanVien.Location = new System.Drawing.Point(0, 0);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabNhanVien.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNV});
            this.tabNhanVien.RegularSize = new System.Drawing.Size(1075, 570);
            this.tabNhanVien.SelectedPage = this.tabNV;
            this.tabNhanVien.Size = new System.Drawing.Size(1075, 570);
            this.tabNhanVien.TabIndex = 4;
            this.tabNhanVien.Text = "NHÂN VIÊN";
            this.tabNhanVien.Click += new System.EventHandler(this.tabNhanVien_Click);
            // 
            // tabNV
            // 
            this.tabNV.Caption = "HÀNG HÓA";
            this.tabNV.Controls.Add(this.btnXem);
            this.tabNV.Controls.Add(this.groupControl2);
            this.tabNV.Controls.Add(this.grC);
            this.tabNV.Name = "tabNV";
            this.tabNV.Size = new System.Drawing.Size(1057, 525);
            // 
            // grC
            // 
            this.grC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grC.Location = new System.Drawing.Point(0, 167);
            this.grC.MainView = this.grV;
            this.grC.Name = "grC";
            this.grC.Size = new System.Drawing.Size(1057, 358);
            this.grC.TabIndex = 7;
            this.grC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grV});
            this.grC.Click += new System.EventHandler(this.grC_Click);
            this.grC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grC_MouseClick);
            // 
            // grV
            // 
            this.grV.GridControl = this.grC;
            this.grV.Name = "grV";
            this.grV.OptionsView.ShowGroupPanel = false;
            this.grV.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grV_RowCellClick);
            this.grV.MouseLeave += new System.EventHandler(this.grC_Click);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(60, 160);
            this.bar2.FloatSize = new System.Drawing.Size(236, 41);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(147, 236);
            this.bar3.FloatSize = new System.Drawing.Size(128, 31);
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.layoutControl2);
            this.groupControl2.Location = new System.Drawing.Point(6, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1051, 125);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Thời gian";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.cmbXemTheo);
            this.layoutControl2.Controls.Add(this.cmbThang);
            this.layoutControl2.Controls.Add(this.cmbNam);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 20);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1047, 103);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // cmbXemTheo
            // 
            this.cmbXemTheo.BackColor = System.Drawing.Color.White;
            this.cmbXemTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXemTheo.FormattingEnabled = true;
            this.cmbXemTheo.Items.AddRange(new object[] {
            "Tháng này",
            "Năm nay",
            "Tháng",
            "Năm"});
            this.cmbXemTheo.Location = new System.Drawing.Point(60, 12);
            this.cmbXemTheo.Name = "cmbXemTheo";
            this.cmbXemTheo.Size = new System.Drawing.Size(92, 21);
            this.cmbXemTheo.TabIndex = 40;
            this.cmbXemTheo.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // cmbThang
            // 
            this.cmbThang.BackColor = System.Drawing.Color.White;
            this.cmbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThang.Enabled = false;
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbThang.Location = new System.Drawing.Point(452, 55);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(118, 21);
            this.cmbThang.TabIndex = 39;
            // 
            // cmbNam
            // 
            this.cmbNam.BackColor = System.Drawing.Color.White;
            this.cmbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNam.Enabled = false;
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Items.AddRange(new object[] {
            "2016",
            "2015",
            "2014",
            "2013"});
            this.cmbNam.Location = new System.Drawing.Point(452, 12);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(118, 21);
            this.cmbNam.TabIndex = 36;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.lblNam,
            this.lblThang});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1030, 106);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.cmbXemTheo;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem1";
            this.layoutControlItem10.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 250, 2, 2);
            this.layoutControlItem10.Size = new System.Drawing.Size(392, 86);
            this.layoutControlItem10.Text = "Xem theo";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(45, 13);
            // 
            // lblNam
            // 
            this.lblNam.Control = this.cmbNam;
            this.lblNam.Location = new System.Drawing.Point(392, 0);
            this.lblNam.Name = "lblNam";
            this.lblNam.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 450, 2, 20);
            this.lblNam.Size = new System.Drawing.Size(618, 43);
            this.lblNam.Text = "Năm";
            this.lblNam.TextSize = new System.Drawing.Size(45, 13);
            // 
            // lblThang
            // 
            this.lblThang.Control = this.cmbThang;
            this.lblThang.Location = new System.Drawing.Point(392, 43);
            this.lblThang.Name = "lblThang";
            this.lblThang.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 450, 2, 20);
            this.lblThang.Size = new System.Drawing.Size(618, 43);
            this.lblThang.Text = "Tháng :";
            this.lblThang.TextSize = new System.Drawing.Size(45, 13);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXem.Location = new System.Drawing.Point(59, 134);
            this.btnXem.Name = "btnXem";
            this.btnXem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXem.Size = new System.Drawing.Size(76, 27);
            this.btnXem.TabIndex = 12;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // UCDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabNhanVien);
            this.Name = "UCDoanhThu";
            this.Size = new System.Drawing.Size(1075, 570);
            ((System.ComponentModel.ISupportInitialize)(this.tabNhanVien)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabPane tabNhanVien;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNV;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraGrid.GridControl grC;
        private DevExpress.XtraGrid.Views.Grid.GridView grV;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private System.Windows.Forms.ComboBox cmbXemTheo;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.ComboBox cmbNam;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem lblNam;
        private DevExpress.XtraLayout.LayoutControlItem lblThang;
        private System.Windows.Forms.Button btnXem;
    }
}
