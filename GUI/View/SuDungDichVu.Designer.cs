namespace GUI.View
{
    partial class SuDungDichVu
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
            this.dataGridView_Service = new System.Windows.Forms.DataGridView();
            this.serviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataGridView_usingService = new System.Windows.Forms.DataGridView();
            this.idDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usingService)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Service
            // 
            this.dataGridView_Service.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceID,
            this.serviceName,
            this.price});
            this.dataGridView_Service.Location = new System.Drawing.Point(12, 107);
            this.dataGridView_Service.Name = "dataGridView_Service";
            this.dataGridView_Service.Size = new System.Drawing.Size(400, 264);
            this.dataGridView_Service.TabIndex = 2;
            this.dataGridView_Service.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Service_CellContentDoubleClick);
            // 
            // serviceID
            // 
            this.serviceID.HeaderText = "Mã dịch vụ";
            this.serviceID.Name = "serviceID";
            this.serviceID.ReadOnly = true;
            // 
            // serviceName
            // 
            this.serviceName.HeaderText = "Tên dịch vụ";
            this.serviceName.Name = "serviceName";
            this.serviceName.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Giá dịch vụ";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(440, 301);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(348, 45);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(440, 358);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(348, 77);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dataGridView_usingService
            // 
            this.dataGridView_usingService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_usingService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_usingService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDichVu,
            this.tenDichVu,
            this.quantity});
            this.dataGridView_usingService.Location = new System.Drawing.Point(440, 107);
            this.dataGridView_usingService.Name = "dataGridView_usingService";
            this.dataGridView_usingService.Size = new System.Drawing.Size(348, 188);
            this.dataGridView_usingService.TabIndex = 5;
            this.dataGridView_usingService.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_usingService_CellValueChanged);
            // 
            // idDichVu
            // 
            this.idDichVu.HeaderText = "Mã dịch vụ";
            this.idDichVu.Name = "idDichVu";
            this.idDichVu.ReadOnly = true;
            // 
            // tenDichVu
            // 
            this.tenDichVu.HeaderText = "Tên dịch vụ";
            this.tenDichVu.Name = "tenDichVu";
            this.tenDichVu.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Số lượng";
            this.quantity.Name = "quantity";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(12, 390);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(400, 45);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dịch vụ sử dụng";
            // 
            // SuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dataGridView_usingService);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dataGridView_Service);
            this.Name = "SuDungDichVu";
            this.Text = "SuDungDichVu";
            this.Load += new System.EventHandler(this.SuDungDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Service)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usingService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Service;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataGridView_usingService;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}