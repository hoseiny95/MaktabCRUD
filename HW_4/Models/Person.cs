using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    public class Person
    {
        [key]
        public int ID { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Mobile { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateUser { get; set; }

    }
}
