using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface iPeopleBUS
    {
        void Create(Person obj);
        void Update(Person obj);
        void Delete(Person obj);

        List<Person> getAll();
        Person getById(string id);
        Person getByName(string name);
        List<Person> Search(Person person);
    }
}
