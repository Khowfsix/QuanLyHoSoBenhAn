using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using DAL.Model;

namespace BUS
{
    public class MedicineBUS
    {
        MedicineDAL medicineDAL;
        MedicineGroupDAL medicineGroupDAL;

        QLHSBAEntities db = new QLHSBAEntities();

        public MedicineBUS()
        {
            medicineDAL = new MedicineDAL();
            medicineGroupDAL = new MedicineGroupDAL();
        }

        public void GetDataMedicineGroup_ComboBox(ComboBox combo)
        {
            try
            {
                combo.DataSource = medicineGroupDAL.FindAllMedicineGroup();
                combo.DisplayMember = "medicineGroupName";
                combo.ValueMember = "medicineGroupName";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
   
        }

        public void FindAllMedicine1(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = medicineDAL.FindAllMedicine1();
                dgv.Columns[0].HeaderText = "Mã thuốc";
                dgv.Columns[1].HeaderText = "Tên thuốc";
                dgv.Columns[2].HeaderText = "Đơn vị";
                dgv.Columns[3].HeaderText = "Giá";
                dgv.Columns[4].HeaderText = "Ngày sử dụng";
                dgv.Columns[5].HeaderText = "Số tồn";
                dgv.Columns[6].HeaderText = "Hình dạng";
                dgv.Columns[7].HeaderText = "Tên nhóm thuốc";
                dgv.Columns[8].HeaderText = "Ngày tạo";
                dgv.Columns[9].HeaderText = "Ngày cập nhật";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool InsertMedicine(string medicineName, string unit,
                                    int medicinePrice, int expiry,
                                    int count, string shape, string medicineGroupName)
        {
            try
            {
                medicineDAL.InsertMedicine(medicineName, unit, medicinePrice, expiry, count, shape, medicineGroupName); 
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool UpdateMedicine(string medicineName, string unit,
                                    int medicinePrice, int expiry,
                                    int count, string shape,
                                    string medicineGroupName, string medicineID)
        {
            try
            {
                medicineDAL.UpdateMedicine(medicineName, unit, medicinePrice, expiry, count, shape, medicineGroupName, medicineID);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool DeleteMedicine(string medicineID)
        {
            try
            {
                medicineDAL.DeleteMedicine(medicineID);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
