using HW_4;
using HW_4.Repository;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

Person person = new Person()
{ID = 2, FirstName = "hasan", LastName = "moti", Age = 25, Mobile = 9121154379, BirthDate = new DateTime(2003, 1, 1), CreateUser = DateTime.Now 
 };

string path = @"E:\c project\MaktabCRUD\HW_4\person.json";


CRUDRepository crudrepository = new CRUDRepository();
crudrepository.Create(person);
//FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
//BinaryFormatter bf = new BinaryFormatter();
//List<Person> jasontoobject = (List<Person>)bf.Deserialize(stream);
//foreach (Person person2 in jasontoobject)
//{
//    Console.WriteLine($"{person2.ID}");

//}
Console.ReadKey();

