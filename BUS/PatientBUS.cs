using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PatientBUS 
    {
        PatientDAL patientDAL;
        
        public PatientBUS()
        {
            patientDAL = new PatientDAL();
        }

        public void FindAllPatientWait(DataGridView dgv)
        {
            dgv.DataSource = patientDAL.FindAllPatientWait();
            dgv.Columns[0].HeaderText = "Mã BN";
            dgv.Columns[1].HeaderText = "Tên";
            dgv.Columns[2].HeaderText = "Họ";
            dgv.Columns[3].HeaderText = "Giới tính";
            dgv.Columns[4].HeaderText = "Ngày sinh";
            dgv.Columns[5].HeaderText = "Địa chỉ";
            dgv.Columns[6].HeaderText = "SĐT";
            dgv.Columns[7].HeaderText = "CCCN/CMND";
            dgv.Columns[8].HeaderText = "Nghề nghiệp";
            dgv.Columns[9].HeaderText = "BHYT";
            dgv.Columns[10].HeaderText = "Lý do khám";
            dgv.Columns[11].HeaderText = "Ngày tạo";
            dgv.Columns[12].HeaderText = "Ngày cập nhật";

            dgv.Columns[0].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[1].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[2].Width = (int)(dgv.Width * 0.2);
            dgv.Columns[3].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[4].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[5].Width = (int)(dgv.Width * 0.3);
            dgv.Columns[6].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[7].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[8].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[9].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[10].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[11].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[12].Width = (int)(dgv.Width * 0.15);
        }

        /*public void CountPatientsWait(TextBox txt)
        {
            txt.Text = patientDAL.CountPatientsWait().ToString();
        }*/
    }
}
