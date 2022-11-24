using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface iPatientBUS
    {
        void Create(Person person, Patient patient);
        void Update(Patient obj);
        void Delete(Patient obj);

        List<Patient> getAll();
        Patient getById(string id);
        Patient getByName(string name);
        List<Patient> Search(Patient patient);
    }
}
