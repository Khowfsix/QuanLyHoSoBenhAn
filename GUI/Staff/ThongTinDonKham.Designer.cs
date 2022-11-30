﻿namespace GUI.Staff
{
    partial class ThongTinDonKham
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtExamID = new System.Windows.Forms.TextBox();
            this.txtpPatientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExamDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVeins = new System.Windows.Forms.TextBox();
            this.txtBloodPressure = new System.Windows.Forms.TextBox();
            this.txtBreathing = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSymptom = new System.Windows.Forms.RichTextBox();
            this.txtPreliminaryDiagnosis = new System.Windows.Forms.RichTextBox();
            this.txtFinalDiagnosis = new System.Windows.Forms.RichTextBox();
            this.txtTreatmentDirection = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView_listMedicine = new System.Windows.Forms.DataGridView();
            this.idMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin đơn khám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID đơn khám";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtExamID
            // 
            this.txtExamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamID.Location = new System.Drawing.Point(244, 59);
            this.txtExamID.Name = "txtExamID";
            this.txtExamID.ReadOnly = true;
            this.txtExamID.Size = new System.Drawing.Size(204, 26);
            this.txtExamID.TabIndex = 2;
            // 
            // txtpPatientID
            // 
            this.txtpPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpPatientID.Location = new System.Drawing.Point(244, 113);
            this.txtpPatientID.Name = "txtpPatientID";
            this.txtpPatientID.ReadOnly = true;
            this.txtpPatientID.Size = new System.Drawing.Size(204, 26);
            this.txtpPatientID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID bệnh nhân";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(244, 165);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(204, 26);
            this.txtPatientName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Họ tên bệnh nhân";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorID.Location = new System.Drawing.Point(244, 220);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.ReadOnly = true;
            this.txtDoctorID.Size = new System.Drawing.Size(204, 26);
            this.txtDoctorID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID bác sĩ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorName.Location = new System.Drawing.Point(244, 282);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.ReadOnly = true;
            this.txtDoctorName.Size = new System.Drawing.Size(204, 26);
            this.txtDoctorName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Họ tên bác sĩ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtExamDate
            // 
            this.txtExamDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamDate.Location = new System.Drawing.Point(244, 337);
            this.txtExamDate.Name = "txtExamDate";
            this.txtExamDate.ReadOnly = true;
            this.txtExamDate.Size = new System.Drawing.Size(204, 26);
            this.txtExamDate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày khám";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(472, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mạch";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(472, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Huyết áp";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(472, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nhịp thở";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(472, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Thân nhiệt";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(472, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Cân nặng";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(472, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Chiều cao";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVeins
            // 
            this.txtVeins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVeins.Location = new System.Drawing.Point(628, 337);
            this.txtVeins.Name = "txtVeins";
            this.txtVeins.ReadOnly = true;
            this.txtVeins.Size = new System.Drawing.Size(204, 26);
            this.txtVeins.TabIndex = 29;
            // 
            // txtBloodPressure
            // 
            this.txtBloodPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodPressure.Location = new System.Drawing.Point(628, 282);
            this.txtBloodPressure.Name = "txtBloodPressure";
            this.txtBloodPressure.ReadOnly = true;
            this.txtBloodPressure.Size = new System.Drawing.Size(204, 26);
            this.txtBloodPressure.TabIndex = 28;
            // 
            // txtBreathing
            // 
            this.txtBreathing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreathing.Location = new System.Drawing.Point(628, 220);
            this.txtBreathing.Name = "txtBreathing";
            this.txtBreathing.ReadOnly = true;
            this.txtBreathing.Size = new System.Drawing.Size(204, 26);
            this.txtBreathing.TabIndex = 27;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(628, 165);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.ReadOnly = true;
            this.txtTemperature.Size = new System.Drawing.Size(204, 26);
            this.txtTemperature.TabIndex = 26;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(628, 113);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(204, 26);
            this.txtWeight.TabIndex = 25;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(628, 59);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(204, 26);
            this.txtHeight.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 732);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 20);
            this.label16.TabIndex = 37;
            this.label16.Text = "Hướng điều trị";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 621);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(184, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "Chuẩn đoán sau cùng";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 521);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 20);
            this.label18.TabIndex = 35;
            this.label18.Text = "Chuẩn đoán sơ bộ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 432);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 20);
            this.label19.TabIndex = 34;
            this.label19.Text = "Tình trạng hiện tại";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSymptom
            // 
            this.txtSymptom.Location = new System.Drawing.Point(244, 397);
            this.txtSymptom.Name = "txtSymptom";
            this.txtSymptom.ReadOnly = true;
            this.txtSymptom.Size = new System.Drawing.Size(588, 78);
            this.txtSymptom.TabIndex = 38;
            this.txtSymptom.Text = "";
            // 
            // txtPreliminaryDiagnosis
            // 
            this.txtPreliminaryDiagnosis.Location = new System.Drawing.Point(244, 499);
            this.txtPreliminaryDiagnosis.Name = "txtPreliminaryDiagnosis";
            this.txtPreliminaryDiagnosis.ReadOnly = true;
            this.txtPreliminaryDiagnosis.Size = new System.Drawing.Size(588, 78);
            this.txtPreliminaryDiagnosis.TabIndex = 39;
            this.txtPreliminaryDiagnosis.Text = "";
            // 
            // txtFinalDiagnosis
            // 
            this.txtFinalDiagnosis.Location = new System.Drawing.Point(244, 596);
            this.txtFinalDiagnosis.Name = "txtFinalDiagnosis";
            this.txtFinalDiagnosis.ReadOnly = true;
            this.txtFinalDiagnosis.Size = new System.Drawing.Size(588, 78);
            this.txtFinalDiagnosis.TabIndex = 40;
            this.txtFinalDiagnosis.Text = "";
            // 
            // txtTreatmentDirection
            // 
            this.txtTreatmentDirection.Location = new System.Drawing.Point(244, 702);
            this.txtTreatmentDirection.Name = "txtTreatmentDirection";
            this.txtTreatmentDirection.ReadOnly = true;
            this.txtTreatmentDirection.Size = new System.Drawing.Size(588, 78);
            this.txtTreatmentDirection.TabIndex = 41;
            this.txtTreatmentDirection.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(888, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(289, 31);
            this.label14.TabIndex = 42;
            this.label14.Text = "Danh sách đơn thuốc";
            // 
            // dataGridView_listMedicine
            // 
            this.dataGridView_listMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_listMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicine,
            this.medicineName,
            this.quantity});
            this.dataGridView_listMedicine.Location = new System.Drawing.Point(894, 223);
            this.dataGridView_listMedicine.Name = "dataGridView_listMedicine";
            this.dataGridView_listMedicine.Size = new System.Drawing.Size(374, 318);
            this.dataGridView_listMedicine.TabIndex = 43;
            // 
            // idMedicine
            // 
            this.idMedicine.HeaderText = "ID thuốc";
            this.idMedicine.Name = "idMedicine";
            this.idMedicine.ReadOnly = true;
            // 
            // medicineName
            // 
            this.medicineName.HeaderText = "Tên thuốc";
            this.medicineName.Name = "medicineName";
            this.medicineName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Số lượng";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // ThongTinDonKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 809);
            this.Controls.Add(this.dataGridView_listMedicine);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTreatmentDirection);
            this.Controls.Add(this.txtFinalDiagnosis);
            this.Controls.Add(this.txtPreliminaryDiagnosis);
            this.Controls.Add(this.txtSymptom);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtVeins);
            this.Controls.Add(this.txtBloodPressure);
            this.Controls.Add(this.txtBreathing);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtExamDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpPatientID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExamID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinDonKham";
            this.Text = "ThongTinDonKham";
            this.Load += new System.EventHandler(this.ThongTinDonKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExamID;
        private System.Windows.Forms.TextBox txtpPatientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExamDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVeins;
        private System.Windows.Forms.TextBox txtBloodPressure;
        private System.Windows.Forms.TextBox txtBreathing;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox txtSymptom;
        private System.Windows.Forms.RichTextBox txtPreliminaryDiagnosis;
        private System.Windows.Forms.RichTextBox txtFinalDiagnosis;
        private System.Windows.Forms.RichTextBox txtTreatmentDirection;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView_listMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}