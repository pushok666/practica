using System;
using System.Linq;

namespace TestConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            using(helloappdbContext db = new helloappdbContext())
            {
                var users = db.Users.ToList();
                foreach (var item in users)
                {
                    Console.WriteLine($"{item.Id}.{item.Name} - {item.Age}");
                }
            }

           
        }
    }
}
