using System;
using System.Linq;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            using(AplicationContext db = new AplicationContext())
            {
                // add data
                User user1 = new User { Name = "Petr", Age = 18 };
                User user2 = new User { Name = "Masha", Age = 30 };

                db.Users.Add(user1);
                db.Users.Add(user2);

                db.SaveChanges();
            }

            using(AplicationContext db = new AplicationContext())
            {
                //Outputing data
                var user = db.Users.ToList();
                Console.WriteLine("after add data");
                foreach (User u in user)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }

            using(AplicationContext db = new AplicationContext())
            {
                User user = db.Users.FirstOrDefault();
                if (null!=user)
                {
                    user.Name = "bob";
                    user.Age = 15;

                    db.SaveChanges();
                }
                Console.WriteLine("updated data");
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }

            using (AplicationContext db = new AplicationContext())
            {
                User user = db.Users.FirstOrDefault();
                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }

                Console.WriteLine("deleted data");
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
        }
    }
}
