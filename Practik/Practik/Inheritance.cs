using System;
using System.Collections.Generic;
using System.Text;

namespace Practik
{
    public class Inheritance
    {
        public void Hello()
        {
            Console.WriteLine("test hello");
        }


    }
    public class Money
    {

    }

    public class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
        private readonly int Ves;

        protected Money money = new Money();
        public void SayHelloBitch()
        {
            Console.WriteLine("Привет шелуха");
        }

    }

    public class Boozer : Human
    {
        private string pochki = "Pochki";
        public void PrositMoney()
        {
            Console.WriteLine("уважаемый дайте мелочи на опохмел. Трубы горят");
        }
    }

    public class Drager : Boozer
    {

    }
}
