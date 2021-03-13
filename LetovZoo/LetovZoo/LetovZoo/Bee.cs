using System;
using System.Collections.Generic;
using System.Text;

namespace LetovZoo
{
    class Bee:Animal
    {
        public Bee(string name, string valer)
        {
            Vid = "Пчелы";
            Name = name;
            Valer = valer;
        }

        public override void EatPie()
        {
            Console.WriteLine("бззз дайте нам лучше грудь чей-нибудь жены!!!!");
        }
    }
}
