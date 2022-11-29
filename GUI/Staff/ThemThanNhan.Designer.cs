namespace GUI.Staff
{
    partial class ThemThanNhan
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
            this.dataGridView_listPeople = new System.Windows.Forms.DataGridView();
            this.IDbenhnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExist = new System.Windows.Forms.Button();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID_relative = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNonExist = new System.Windows.Forms.Button();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_listPeople
            // 
            this.dataGridView_listPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_listPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDbenhnhan,
            this.firstName,
            this.lastName,
            this.sex});
            this.dataGridView_listPeople.Location = new System.Drawing.Point(12, 71);
            this.dataGridView_listPeople.Name = "dataGridView_listPeople";
            this.dataGridView_listPeople.Size = new System.Drawing.Size(393, 492);
            this.dataGridView_listPeople.TabIndex = 1;
            this.dataGridView_listPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_listPeople_CellContentClick);
            // 
            // IDbenhnhan
            // 
            this.IDbenhnhan.HeaderText = "ID người";
            this.IDbenhnhan.Name = "IDbenhnhan";
            this.IDbenhnhan.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Họ";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Tên";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.HeaderText = "Giới tính";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // btnExist
            // 
            this.btnExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.Location = new System.Drawing.Point(503, 139);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(121, 75);
            this.btnExist.TabIndex = 3;
            this.btnExist.Text = "Thêm người đã có";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(566, 412);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(262, 20);
            this.dtpBirthday.TabIndex = 64;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmbSex.Location = new System.Drawing.Point(566, 368);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(262, 21);
            this.cmbSex.TabIndex = 63;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(566, 328);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(262, 20);
            this.txtLastName.TabIndex = 62;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(566, 286);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(262, 20);
            this.txtFirstName.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(451, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Họ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID thân nhân";
            // 
            // txtID_relative
            // 
            this.txtID_relative.Enabled = false;
            this.txtID_relative.Location = new System.Drawing.Point(566, 238);
            this.txtID_relative.Name = "txtID_relative";
            this.txtID_relative.ReadOnly = true;
            this.txtID_relative.Size = new System.Drawing.Size(262, 20);
            this.txtID_relative.TabIndex = 55;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(707, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 33);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(454, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 30);
            this.textBox1.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 67;
            this.label1.Text = "Thêm thân nhân";
            // 
            // btnNonExist
            // 
            this.btnNonExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNonExist.Location = new System.Drawing.Point(667, 139);
            this.btnNonExist.Name = "btnNonExist";
            this.btnNonExist.Size = new System.Drawing.Size(121, 75);
            this.btnNonExist.TabIndex = 68;
            this.btnNonExist.Text = "Thêm người chưa có";
            this.btnNonExist.UseVisualStyleBackColor = true;
            this.btnNonExist.Click += new System.EventHandler(this.btnNonExist_Click);
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(566, 543);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(262, 20);
            this.txtCardID.TabIndex = 76;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(566, 506);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(262, 20);
            this.txtPhone.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(447, 547);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 72;
            this.label9.Text = "CMND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 71;
            this.label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(566, 454);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(262, 20);
            this.txtAddress.TabIndex = 69;
            // 
            // ThemThanNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 580);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnNonExist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID_relative);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.dataGridView_listPeople);
            this.Name = "ThemThanNhan";
            this.Text = "ThemThanNhan";
            this.Load += new System.EventHandler(this.ThemThanNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_listPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDbenhnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID_relative;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNonExist;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
    }
}