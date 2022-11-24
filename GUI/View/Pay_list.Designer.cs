namespace GUI.View
{
    partial class HoaDon_list
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BenhNhan,
            this.BacSi,
            this.HoaDon,
            this.TongGia});
            this.dataGridView1.Location = new System.Drawing.Point(16, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // BenhNhan
            // 
            this.BenhNhan.HeaderText = "Bệnh nhân";
            this.BenhNhan.Name = "BenhNhan";
            // 
            // BacSi
            // 
            this.BacSi.HeaderText = "Bác sĩ";
            this.BacSi.Name = "BacSi";
            // 
            // HoaDon
            // 
            this.HoaDon.HeaderText = "Hóa đơn";
            this.HoaDon.Name = "HoaDon";
            // 
            // TongGia
            // 
            this.TongGia.HeaderText = "Tổng giá";
            this.TongGia.Name = "TongGia";
            // 
            // HoaDon_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HoaDon_list";
            this.Text = "HoaDon_list";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGia;
    }
}