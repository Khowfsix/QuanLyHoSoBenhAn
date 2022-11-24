using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface iUsingServiceBUS
    {
        void Create(string patientID, string serviceID, byte quantity);
        void Update(string usingService, string patientID, string serviceID, byte quantity);
        void Delete(UsingService obj);

        List<UsingService> getAll();
        UsingService getById(string id);
        UsingService getByName(string name);
        List<UsingService> Search(string keyword);
    }
}
