namespace GUI.Doctor
{
    partial class frmMedicineGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedGID = new System.Windows.Forms.TextBox();
            this.txtMedGName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDetele = new System.Windows.Forms.Button();
            this.btnUpate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvMedG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm thuốc";
            // 
            // txtMedGID
            // 
            this.txtMedGID.Enabled = false;
            this.txtMedGID.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedGID.Location = new System.Drawing.Point(316, 23);
            this.txtMedGID.Name = "txtMedGID";
            this.txtMedGID.Size = new System.Drawing.Size(242, 40);
            this.txtMedGID.TabIndex = 1;
            // 
            // txtMedGName
            // 
            this.txtMedGName.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedGName.Location = new System.Drawing.Point(316, 84);
            this.txtMedGName.Name = "txtMedGName";
            this.txtMedGName.Size = new System.Drawing.Size(242, 40);
            this.txtMedGName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhóm thuốc";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(30, 467);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 46);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDetele
            // 
            this.btnDetele.AutoSize = true;
            this.btnDetele.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDetele.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetele.ForeColor = System.Drawing.Color.White;
            this.btnDetele.Location = new System.Drawing.Point(220, 467);
            this.btnDetele.Name = "btnDetele";
            this.btnDetele.Size = new System.Drawing.Size(158, 46);
            this.btnDetele.TabIndex = 6;
            this.btnDetele.Text = "Detele";
            this.btnDetele.UseVisualStyleBackColor = false;
            this.btnDetele.Click += new System.EventHandler(this.btnDetele_Click);
            // 
            // btnUpate
            // 
            this.btnUpate.AutoSize = true;
            this.btnUpate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpate.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpate.ForeColor = System.Drawing.Color.White;
            this.btnUpate.Location = new System.Drawing.Point(401, 467);
            this.btnUpate.Name = "btnUpate";
            this.btnUpate.Size = new System.Drawing.Size(150, 46);
            this.btnUpate.TabIndex = 7;
            this.btnUpate.Text = "Update";
            this.btnUpate.UseVisualStyleBackColor = false;
            this.btnUpate.Click += new System.EventHandler(this.btnUpate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRefresh.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(30, 553);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(158, 46);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(401, 553);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvMedG
            // 
            this.dgvMedG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedG.Location = new System.Drawing.Point(30, 146);
            this.dgvMedG.Name = "dgvMedG";
            this.dgvMedG.RowHeadersVisible = false;
            this.dgvMedG.RowHeadersWidth = 82;
            this.dgvMedG.RowTemplate.Height = 33;
            this.dgvMedG.Size = new System.Drawing.Size(528, 281);
            this.dgvMedG.TabIndex = 10;
            this.dgvMedG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedG_CellClick);
            // 
            // frmMedicineGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(599, 633);
            this.Controls.Add(this.dgvMedG);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpate);
            this.Controls.Add(this.btnDetele);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMedGName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMedGID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(625, 704);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(625, 704);
            this.Name = "frmMedicineGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhóm thuốc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMedicineGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMedGID;
        private System.Windows.Forms.TextBox txtMedGName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDetele;
        private System.Windows.Forms.Button btnUpate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvMedG;
    }
}