using Newtonsoft.Json;
using NPOI.HPSF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    [Serializable]
    public partial class Person
    {

        
        public int ID { get; set; }
        public string FirstName  { get; set; }
        
       
        public long Mobile { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateUser { get; set; }
        public override string ToString()
        {
            return this.ID + "," + "," + this.FirstName+"," +","
                + this.Mobile +"," +this.BirthDate +","+this.CreateUser;
        }

    }
}
