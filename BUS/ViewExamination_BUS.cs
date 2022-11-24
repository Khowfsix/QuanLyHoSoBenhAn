using DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ViewExamination_BUS
    {
        private QLHSBAEntities db = new QLHSBAEntities();
        public List<View_Examination> getAll()
        {
            return db.View_Examination.ToList();
        }

        public func_getExamWithID_Result getWithID(string examinationID)
        {
            return db.func_getExamWithID(examinationID).Where(e => e.examinateID.Equals(examinationID)).FirstOrDefault();
        }
    }
}
