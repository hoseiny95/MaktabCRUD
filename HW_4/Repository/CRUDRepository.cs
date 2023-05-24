using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using HW_4.Models;
using Newtonsoft.Json;

namespace HW_4.Repository
{
    [Serializable]
    public class CRUDRepository : ICRUDRepository
    {
       
       
        public string mainpath = @"E:\c project\MaktabCRUD\HW_4\person.json";

        
        

        public void Create(Person obj)
        {
            List<Person> mainlist = new List<Person>();


            if (!File.Exists(mainpath))
            {
                mainlist.Add(obj);
                FileStream stream = new FileStream(mainpath, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, mainlist);
                stream.Close();

                //string objectinjason= JsonConvert.SerializeObject(obj,Formatting.Indented);
                //File.WriteAllText(mainpath, objectinjason);

            }
            else
            {
                try
                {
                    FileStream stream = new FileStream(mainpath, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Person> jasontoobject = (List<Person>)bf.Deserialize(stream);

                    stream.Close();
                    mainlist.Add(obj);
                    jasontoobject.AddRange(mainlist);
                    FileStream stream2 = new FileStream(mainpath, FileMode.Open, FileAccess.Write);
                    BinaryFormatter bf2 = new BinaryFormatter();
                    bf2.Serialize(stream2, jasontoobject);
                    stream2.Close();
                }
                catch 
                { 

                }


                // string filejason=File.ReadAllText(mainpath);

                //var list = JsonConvert.DeserializeObject<List<T>>(file).Options.Select(x => new Options() { OptionId = int.Parse(x.Key), OptionName = x.Value }).ToList();
                //var file = JsonConvert.DeserializeObject(mainpath);
                //var jasontolist = JsonConvert.DeserializeObject(filejason);
                //foreach (var item in jasontolist)
                //{

                //}
                //mainlist.AddRange(jasontolist);
                //mainlist.Add(obj);
                //string objectinjason = JsonConvert.SerializeObject(mainlist);
                //File.WriteAllText(mainpath, objectinjason);

            }

        }

        public void Delete(Person obj)
        {
            throw new NotImplementedException();
        }

        public void Read(Person obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Person obj)
        {
            throw new NotImplementedException();
        }
    }
}
