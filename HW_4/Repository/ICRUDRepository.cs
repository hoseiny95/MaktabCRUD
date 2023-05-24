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
        void Update(Person obj);

        void Delete(Person obj);
        void Read (Person obj);
    }
}
