namespace QLhocsinhgiaovien
{
    partial class dsgiaovien
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
            this.dgvdsgv = new System.Windows.Forms.DataGridView();
            this.txttimkiem = new DevExpress.XtraEditors.TextEdit();
            this.btntimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttimkiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdsgv
            // 
            this.dgvdsgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsgv.Location = new System.Drawing.Point(5, 71);
            this.dgvdsgv.Name = "dgvdsgv";
            this.dgvdsgv.Size = new System.Drawing.Size(550, 201);
            this.dgvdsgv.TabIndex = 0;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(147, 27);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(168, 20);
            this.txttimkiem.TabIndex = 2;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(321, 25);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 3;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // dsgiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 288);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.dgvdsgv);
            this.Name = "dsgiaovien";
            this.Text = "dsgiaovien";
            this.Load += new System.EventHandler(this.dsgiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttimkiem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdsgv;
        private DevExpress.XtraEditors.TextEdit txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
    }
}