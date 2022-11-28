using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PrescriptionBUS
    {
        PrescriptionDAL prescriptionDAL;
        MedicineDAL medicineDAL;

        public PrescriptionBUS()
        {
            prescriptionDAL = new PrescriptionDAL();
            medicineDAL = new MedicineDAL();
        }

        public bool InsertPrescriptionNull(string patientID, string employeeID)
        {
            try
            {
                prescriptionDAL.InsertPrescriptionNull(patientID, employeeID);
                return true;
            }
            catch (Exception e)
            {   
               return false;   
            }
        }

        public void GetPrescriptionID_New(TextBox txt)
        {
            try
            {
                txt.Text = prescriptionDAL.GetPrescriptionID_New();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            } 
        }

        public void GetDataMedicine_ComboBox(ComboBox combo)
        {
            try
            {
                combo.DataSource = medicineDAL.FindAllMedicine1();
                combo.DisplayMember = "medicineName";
                combo.ValueMember = "medicineName";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void GetMedicineByMedicineName(string medicineName, TextBox txtMaThuoc, TextBox txtNhomThuoc,
                                                 TextBox txtHinhDang, TextBox txtDonVi,
                                                TextBox txtGia, TextBox txtHSD, TextBox txtSoTon)

        {
            try
            {
                dynamic ds = medicineDAL.FindAllMedicine1ByMedicineName(medicineName);
                txtMaThuoc.DataBindings.Clear();
                txtMaThuoc.DataBindings.Add("Text", ds, "medicineID");

                txtNhomThuoc.DataBindings.Clear();
                txtNhomThuoc.DataBindings.Add("Text", ds, "medicineGroupName");

                txtHinhDang.DataBindings.Clear();
                txtHinhDang.DataBindings.Add("Text", ds, "shape");

                txtDonVi.DataBindings.Clear();
                txtDonVi.DataBindings.Add("Text", ds, "unit");

                txtGia.DataBindings.Clear();
                txtGia.DataBindings.Add("Text", ds, "medicinePrice");

                txtHSD.DataBindings.Clear();
                txtHSD.DataBindings.Add("Text", ds, "expiry");

                txtSoTon.DataBindings.Clear();
                txtSoTon.DataBindings.Add("Text", ds, "count");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool InsertPrescription_Medicine(string prescriptionID, string medicineName, int quanlity)
        {
            try
            {
                prescriptionDAL.InsertPrescription_Medicine(prescriptionID, medicineName, quanlity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void FindAllPrescription_Medicine(DataGridView dgv, string prescriptionID)
        {
            dgv.DataSource = prescriptionDAL.FindAllPrescription_Medicine(prescriptionID);
        }

        public bool UpdatePrescription_Medicine(string prescriptionID, string medicineName, int quanlity)
        {
            try
            {
                prescriptionDAL.UpdatePrescription_Medicine(prescriptionID, medicineName, quanlity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeletePrescription_Medicine(string prescriptionID, string medicineName)
        {
            try
            {
                prescriptionDAL.DeletePrescription_Medicine(prescriptionID, medicineName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdatePrescription(string prescriptionID, string descriptionPrescription)
        {
            try
            {
                prescriptionDAL.UpdatePrescription(prescriptionID, descriptionPrescription);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
