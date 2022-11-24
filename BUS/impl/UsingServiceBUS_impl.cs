using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.impl
{
    public class UsingServiceBUS_impl : iUsingServiceBUS
    {
        QLHSBAEntities db = new QLHSBAEntities();

        public void Create(string patientID, string serviceID, byte quantity)
        {
            db.proc_InsertUsingService(patientID, serviceID, quantity);
            db.SaveChanges();
        }

        public void Delete(UsingService obj)
        {
            throw new NotImplementedException();
        }

        public List<UsingService> getAll()
        {
            throw new NotImplementedException();
        }

        public UsingService getById(string id)
        {
            throw new NotImplementedException();
        }

        public UsingService getByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<UsingService> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public void Update(string usingService, string patientID, string serviceID, byte quantity)
        {
            db.proc_UpdateUsingService(usingService, patientID, serviceID, quantity);
            db.SaveChanges();
        }
    }
}
