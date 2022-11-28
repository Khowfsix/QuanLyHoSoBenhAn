using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExaminationDAL 
    {
        QLHSBAEntities db;
        public ExaminationDAL()
        {
            db = new QLHSBAEntities();
        }

        public string GetExaminateIDNext()
        {
            var examIDNext = db.spExaminateIDNext();
            return examIDNext.First();
        }

        public void InsertExamination(string patientID, string employeeID, double height, double weight, double temperature, int breathing, string symptom, int veins, int bloodPressure, string preliminaryDiagnosis, string finalDiagnosis, string treatmentDirection)
        {
            db.spInsertExamination(patientID, employeeID, height, weight, temperature, breathing, symptom, veins, bloodPressure, preliminaryDiagnosis, finalDiagnosis, treatmentDirection);
            db.SaveChanges();
        }
    }
}
