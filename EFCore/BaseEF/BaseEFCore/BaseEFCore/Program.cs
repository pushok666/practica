using System;
using System.Linq;

namespace BaseEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using(AplicationContext db = new AplicationContext())
            {
                //создание объектов
                User user1 = new User { Name = "Poul", Age = 20 };
                User user2 = new User { Name = "Stiv", Age = 23 };

                //добавление в бд
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("all save");

                var users = db.Users.ToList();
                Console.WriteLine("List obj");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
        }
    }
}
