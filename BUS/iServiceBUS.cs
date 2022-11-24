using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface iServiceBUS
    {
        void Create(Service obj);
        void Update(Service obj);
        void Delete(Service obj);

        List<Service> getAll();
        Service getById(string id);
        Service getByName(string name);
        List<Service> Search(string keyword);
    }
}
