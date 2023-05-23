using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4.Repository
{
    public  interface ICRUDRepository<T>
    {
        void Create(T obj);
        void Update(T obj);

        void Delete(T obj);
        void Read (T obj);
    }
}
