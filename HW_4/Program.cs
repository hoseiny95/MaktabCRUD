using HW_4;
using HW_4.Repository;
using Newtonsoft.Json;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

CRUDRepository crudrepository = new CRUDRepository();
Person person = new Person()
{ID= crudrepository.numberofusers() + 1,
    FirstName = "masi", Mobile = 9121154379, BirthDate = new DateTime(2003, 1, 1), CreateUser = DateTime.Now 
 };


crudrepository.Create(person);

bool check = true;
//string dateString = "7/10/1974";
//DateTime dateFromString =
//    DateTime.Parse(dateString);
//Console.WriteLine(dateFromString.ToString());
try
{
    do
    {
        Console.WriteLine("enter your mode \n 1 for crate user \n 2 for delete user \n 3 for show users \n 4 for update user  \n 5 for exite");
        int num = int.Parse(Console.ReadLine());
        if (num == 1)
        {
            Console.WriteLine("insert name,mobile,birthdate(day/month/year)");
            string[] people = Console.ReadLine().Split(',');
            DateTime dateFromString = DateTime.Parse(people[2]);

            while (people[1].Length != 10)
            {
                Console.WriteLine("enter a correct phone number");
                people[1] = Console.ReadLine();


            }
            while (DateTime.Now.Subtract(dateFromString).Days < 1)
            {
                Console.WriteLine("enter a correct birthdate");
                people[2] = Console.ReadLine();
                dateFromString = DateTime.Parse(people[2]);



            }
            Person user = new Person()
            {
                ID = crudrepository.numberofusers() + 1,
                FirstName = people[0],
                Mobile = long.Parse(people[1]),
                BirthDate = dateFromString,
                CreateUser = DateTime.Now
            };
            crudrepository.Create(user);



        }
        else if (num == 2)
        {
            crudrepository.Read();
            Console.WriteLine("enter userid for delete");
            int id = int.Parse(Console.ReadLine());

            crudrepository.Delete(x => x.ID == id);
        }
        else if (num == 3)
        {
            crudrepository.Read();

        }
        else if (num == 4)
        {
            crudrepository.Read();
            Console.WriteLine("enter user id for update");
            int id = int.Parse(Console.ReadLine());
            Person user = crudrepository.Search(id);
            Console.WriteLine("insert name,mobile,birthdate(day/month/year)");
            string[] people = Console.ReadLine().Split(',');
            DateTime dateFromString = DateTime.Parse(people[2]);
            Person usernew = new Person()
            {
                ID = id,
                FirstName = people[0],
                Mobile = long.Parse(people[1]),
                BirthDate = dateFromString,
                CreateUser = DateTime.Now
            };
            crudrepository.Update(usernew, x => x.ID == id);
        }

        else if (num == 5)
        {
            check = false;
        }
    } while (check);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




Console.ReadKey();
