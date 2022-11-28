using BUS;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmExamine : Form
    {
        DoctorBUS doctorBUS;
        PatientBUS patientBUS;
        ExaminationBUS examinationBUS;
        PrescriptionBUS prescriptionBUS;
        public frmExamine()
        {
            InitializeComponent();
            doctorBUS = new DoctorBUS();
            patientBUS = new PatientBUS();
            examinationBUS = new ExaminationBUS();
            prescriptionBUS = new PrescriptionBUS();
        }

        private void FindAllPatientWait()
        {
            
            /*patientBUS.FindAllPatientWait(dgvPatientWait);*/
        }

        private void frmExamine_Load(object sender, EventArgs e)
        {
            this.LoadData();

        }

        private void dgvPatientWait_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDataPatientWait(e.RowIndex);
        }

        private void GetDataPatientWait(int rowIndex)
        {
            try
            {
                if (rowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvPatientWait.Rows[rowIndex];
                    this.txtMaBN.Text = (string)row.Cells[0].Value;
                    this.txtTen.Text = (string)row.Cells[1].Value;
                    this.txtHo.Text = (string)row.Cells[2].Value;
                    this.txtGioiTinh.Text = (string)row.Cells[3].Value;
                    this.txtNgaySinh.Text = row.Cells[4].Value.ToString();
                    this.txtDiaChi.Text = (string)row.Cells[5].Value;
                    this.txtSDT.Text = (string)row.Cells[6].Value;
                    this.txtCMND.Text = (string)row.Cells[7].Value;
                    this.txtNgheNghiep.Text = (string)row.Cells[8].Value;
                    this.txtBHYT.Text = (string)row.Cells[9].Value;
                    this.txtLyDoKham.Text = (string)row.Cells[10].Value;
                }
            }
            catch (Exception)
            {

                //throw;
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ISCheckInputExam())
            {
                try
                {
                    bool ins = examinationBUS.InsertExamination((string)this.txtMaBN.Text,
                                                        (string)this.txtMaBS.Text,
                                                        double.Parse(this.txtChieuCao.Text),
                                                        double.Parse(this.txtCanNang.Text),
                                                        double.Parse(this.txtNhietDo.Text),
                                                        int.Parse(this.txtNhipTho.Text),
                                                        (string)this.txtTTHT.Text,
                                                        int.Parse(this.txtMach.Text),
                                                        int.Parse(this.txtHuyetAp.Text),
                                                        (string)this.txtCDSB.Text,
                                                        (string)this.txtCDSC.Text,
                                                        (string)this.txtHDT.Text);

                    if (ins)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.LoadData();
                    }    
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LoadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadData();
            }    
        }

        private void LoadData()
        {
            doctorBUS.FindDepartmentNameByDoctorId(this.txtKhoaKham, "NV02");
            doctorBUS.FindFullNameDoctorByDoctorId(this.txtTenBS, "NV01");
            this.FindAllPatientWait();
           /* patientBUS.CountPatientsWait(txtCountPatientsWait);*/
            this.GetDataPatientWait(0);
            examinationBUS.GetExaminateIDNext(txtMaKhamBenh);

            this.txtChieuCao.ResetText();
            this.txtCanNang.ResetText();
            this.txtNhietDo.ResetText();
            this.txtNhipTho.ResetText();
            this.txtMach.ResetText();
            this.txtHuyetAp.ResetText();
            this.txtTTHT.ResetText();
            this.txtCDSB.ResetText();
            this.txtCDSC.ResetText();
            this.txtHDT.ResetText();
        }

        private bool ISCheckInputExam()
        {
            if ((this.txtChieuCao.Text == "")   ||
                (this.txtCanNang.Text == "")    ||
                (this.txtNhietDo.Text == "")    ||
                (this.txtNhipTho.Text == "")    ||
                (this.txtMach.Text == "")       || 
                (this.txtHuyetAp.Text == "")    ||
                (this.txtTTHT.Text == "")       ||
                (this.txtCDSB.Text == "")       ||
                (this.txtCDSC.Text == "")       ||
                (this.txtHDT.Text == ""))
            {
                this.LoadData();
                return false;
            }
            return true;
        }

        private void btnCapThuoc_Click(object sender, EventArgs e)
        {
            bool ins = prescriptionBUS.InsertPrescriptionNull(this.txtMaBN.Text, this.txtMaBS.Text);
            if (ins == true)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrescription frm = new frmPrescription();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            this.txtChieuCao.Enabled = true;
            this.txtCanNang.Enabled = true;
            this.txtNhietDo.Enabled = true;
            this.txtNhipTho.Enabled = true;
            this.txtMach.Enabled = true;
            this.txtHuyetAp.Enabled = true;
            this.txtTTHT.Enabled = true;
            this.txtCDSB.Enabled = true;
            this.txtCDSC.Enabled = true;
            this.txtHDT.Enabled = true;

            this.txtChieuCao.Focus();
        }
    }
}
