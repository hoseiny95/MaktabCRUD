using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

                //string objectinjason = JsonConvert.SerializeObject(obj, Formatting.Indented);
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
                    string csvHeaderRow = String.Join(",", typeof(Person).GetProperties(BindingFlags.Public | BindingFlags.Instance).Select(x => x.Name).ToArray<string>()) + Environment.NewLine;
                    string csv = csvHeaderRow + String.Join(Environment.NewLine, jasontoobject.Select(x => x.ToString()).ToArray());
                    string csvpath = @"E:\c project\MaktabCRUD\HW_4\person.csv";
                    File.WriteAllText(csvpath, csv.ToString());
                   
                }
                catch
                {

                }


                //string filejason = File.ReadAllText(mainpath);

                //List<Person> jasontolist = JsonConvert.DeserializeObject<List<Person>>(filejason);

                //mainlist.AddRange(jasontolist);
                //mainlist.Add(obj);
                //string objectinjason = JsonConvert.SerializeObject(mainlist);
                //File.WriteAllText(mainpath, objectinjason);

            }

        }

        public void Delete(Predicate<Person> pre)
        {
            FileStream stream = new FileStream(mainpath, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Person> jasontoobject = (List<Person>)bf.Deserialize(stream);
            stream.Close();
            jasontoobject.RemoveAll(pre);
            FileStream stream2 = new FileStream(mainpath, FileMode.Open, FileAccess.Write);
            BinaryFormatter bf2 = new BinaryFormatter();
            bf2.Serialize(stream2, jasontoobject);
            stream2.Close();


        }

        public List<Person> Read()
        {
            FileStream stream = new FileStream(mainpath, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Person> jasontoobject = (List<Person>)bf.Deserialize(stream);
            stream.Close();
            foreach (Person obj in jasontoobject)
            {
                Console.WriteLine(obj.ToString());
            }
            return jasontoobject;
        }

        public void Update(Person obj, Predicate<Person> pre)
        {
            FileStream stream = new FileStream(mainpath, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Person> jasontoobject = (List<Person>)bf.Deserialize(stream);
            stream.Close();
            jasontoobject.RemoveAll(pre);
            jasontoobject.Add(obj);
            FileStream stream2 = new FileStream(mainpath, FileMode.Open, FileAccess.Write);
            BinaryFormatter bf2 = new BinaryFormatter();
            bf2.Serialize(stream2, jasontoobject);
            stream2.Close();



        }
        public int numberofusers()
        {
            FileStream stream = new FileStream(mainpath, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Person> jasontoobject = (List<Person>)bf.Deserialize(stream);
            stream.Close();
            return (int)jasontoobject.Count;

        }
        public Person Search(int id)
        {
            FileStream stream = new FileStream(mainpath, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Person> jasontoobject = (List<Person>)bf.Deserialize(stream);
            stream.Close();
            foreach (Person person in jasontoobject)
            {
                if (person.ID == id)
                {
                    return person;
                }
                
            }
            return null;

        }
    }
}
