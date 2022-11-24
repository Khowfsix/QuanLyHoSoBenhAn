using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface iPayBUS
    {
        void Create(Pay obj);
        void Update(Pay obj);
        void Delete(Pay obj);

        List<Pay> getAll();
        Pay getById(string id);
        Pay getByName(string name);
        List<Pay> Search(string keyword);
    }
}
