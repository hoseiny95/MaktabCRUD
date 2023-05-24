using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4.Repository
{
    public  interface ICRUDRepository
    {
        void Create(Person obj);
        void Update(Person obj, Person old);

        void Delete(Person obj);
        List<Person> Read (Person obj);
    }
}
