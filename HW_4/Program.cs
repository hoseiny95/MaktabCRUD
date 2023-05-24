using HW_4;
using HW_4.Repository;
using Newtonsoft.Json;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

Person person = new Person()
{FirstName = "hasan", Mobile = 9121154379, BirthDate = new DateTime(2003, 1, 1), CreateUser = DateTime.Now 
 };

string path = @"E:\c project\MaktabCRUD\HW_4\person.json";
string path2 = @"E:\c project\MaktabCRUD\HW_4\pers.csv";
FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
BinaryFormatter bf = new BinaryFormatter();
List<Person> jasontoobject = (List<Person>)bf.Deserialize(stream);
foreach (Person p in jasontoobject)
{
    Console.WriteLine(p.ToString());
    Console.WriteLine(p.ID);
}


//CRUDRepository crudrepository = new CRUDRepository();
//crudrepository.Create(person);


//Console.ReadKey();
