using HW_4;
using HW_4.Repository;
using Newtonsoft.Json;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

Person person = new Person()
{ID=1,FirstName = "hasan", Mobile = 9121154379, BirthDate = new DateTime(2003, 1, 1), CreateUser = DateTime.Now 
 };

//string path = @"E:\c project\MaktabCRUD\HW_4\person.json";
//string path2 = @"E:\c project\MaktabCRUD\HW_4\pers.csv";



CRUDRepository crudrepository = new CRUDRepository();
crudrepository.Create(person);
 

Console.ReadKey();
