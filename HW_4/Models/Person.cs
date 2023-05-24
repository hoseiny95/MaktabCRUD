using Newtonsoft.Json;
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
        public Person()
        {

        }
        
        [JsonProperty("ID")]
        public long ID { get; set; }
        [JsonProperty("FirstName")]
        public string FirstName  { get; set; }
        [JsonProperty("LastName")]
        public string LastName { get; set; }
        [JsonProperty("Age")]
        public long Age { get; set; }
        [JsonProperty("Mobile")]
        public long Mobile { get; set; }
        [JsonProperty("BirthDate")]
        public DateTime BirthDate { get; set; }
        [JsonProperty("CreateUser")]
        public DateTime CreateUser { get; set; }

    }
}
