using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface iReceiptBUS
    {
        void Create(Receipt obj);
        void Update(Receipt obj);
        void Delete(Receipt obj);

        List<Receipt> getAll();
        Receipt getById(string id);
        Receipt getByName(string name);
        List<Receipt> Search(string keyword);
    }
}
