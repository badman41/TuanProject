namespace QLhocsinhgiaovien.views
{
    partial class uctdiemchitiet
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
            this.dgvdiemchitiet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemchitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdiemchitiet
            // 
            this.dgvdiemchitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdiemchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiemchitiet.Location = new System.Drawing.Point(3, 3);
            this.dgvdiemchitiet.Name = "dgvdiemchitiet";
            this.dgvdiemchitiet.Size = new System.Drawing.Size(621, 215);
            this.dgvdiemchitiet.TabIndex = 0;
            // 
            // uctdiemchitiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvdiemchitiet);
            this.Name = "uctdiemchitiet";
            this.Size = new System.Drawing.Size(627, 418);
            this.Load += new System.EventHandler(this.uctdiemchitiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemchitiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdiemchitiet;
    }
}
