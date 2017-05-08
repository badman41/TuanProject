namespace QLhocsinhgiaovien.views
{
    partial class uctDiem
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
            this.dgvdiemtbchung = new System.Windows.Forms.DataGridView();
            this.lvDsHS = new System.Windows.Forms.ListView();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMaHS = new System.Windows.Forms.Label();
            this.txttbChung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxeploai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemtbchung)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdiemtbchung
            // 
            this.dgvdiemtbchung.AllowUserToAddRows = false;
            this.dgvdiemtbchung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdiemtbchung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiemtbchung.Location = new System.Drawing.Point(233, 3);
            this.dgvdiemtbchung.Name = "dgvdiemtbchung";
            this.dgvdiemtbchung.Size = new System.Drawing.Size(632, 99);
            this.dgvdiemtbchung.TabIndex = 1;
            // 
            // lvDsHS
            // 
            this.lvDsHS.Location = new System.Drawing.Point(3, 3);
            this.lvDsHS.MultiSelect = false;
            this.lvDsHS.Name = "lvDsHS";
            this.lvDsHS.Size = new System.Drawing.Size(229, 426);
            this.lvDsHS.TabIndex = 3;
            this.lvDsHS.UseCompatibleStateImageBehavior = false;
            this.lvDsHS.SelectedIndexChanged += new System.EventHandler(this.lvDsHS_SelectedIndexChanged);
            this.lvDsHS.Click += new System.EventHandler(this.lvDsHS_Click);
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(434, 108);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(100, 20);
            this.txtMaHS.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(238, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 258);
            this.panel1.TabIndex = 11;
            // 
            // lbMaHS
            // 
            this.lbMaHS.AutoSize = true;
            this.lbMaHS.Location = new System.Drawing.Point(337, 111);
            this.lbMaHS.Name = "lbMaHS";
            this.lbMaHS.Size = new System.Drawing.Size(71, 13);
            this.lbMaHS.TabIndex = 12;
            this.lbMaHS.Text = "Mã học sinh: ";
            // 
            // txttbChung
            // 
            this.txttbChung.Location = new System.Drawing.Point(662, 108);
            this.txttbChung.Name = "txttbChung";
            this.txttbChung.Size = new System.Drawing.Size(100, 20);
            this.txttbChung.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Điểm TB Chung:";
            // 
            // btnDiem
            // 
            this.btnDiem.Location = new System.Drawing.Point(387, 142);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(97, 23);
            this.btnDiem.TabIndex = 14;
            this.btnDiem.Text = "Điểm Chi Tiết";
            this.btnDiem.UseVisualStyleBackColor = true;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(490, 142);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(104, 23);
            this.btnhuy.TabIndex = 15;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click_1);
            // 
            // btnxeploai
            // 
            this.btnxeploai.Location = new System.Drawing.Point(600, 142);
            this.btnxeploai.Name = "btnxeploai";
            this.btnxeploai.Size = new System.Drawing.Size(104, 23);
            this.btnxeploai.TabIndex = 15;
            this.btnxeploai.Text = "Xếp Loại Học Sinh";
            this.btnxeploai.UseVisualStyleBackColor = true;
            this.btnxeploai.Click += new System.EventHandler(this.btnxeploai_Click);
            // 
            // uctDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnxeploai);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnDiem);
            this.Controls.Add(this.txttbChung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMaHS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.lvDsHS);
            this.Controls.Add(this.dgvdiemtbchung);
            this.Name = "uctDiem";
            this.Size = new System.Drawing.Size(868, 448);
            this.Load += new System.EventHandler(this.uctDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemtbchung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvdiemtbchung;
        private System.Windows.Forms.ListView lvDsHS;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMaHS;
        private System.Windows.Forms.TextBox txttbChung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxeploai;
    }
}
