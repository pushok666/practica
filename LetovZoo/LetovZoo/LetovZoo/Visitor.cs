using System;
using System.Collections.Generic;
using System.Text;

namespace LetovZoo
{
    class Visitor
    {
        public string Name { get; set; }
        public int Balance { get; set; }

        public Visitor( int balance)
        {
            Name = "Дурачок";
            Balance = balance;
        }

        
        public void Feed(BespontovyyPie bespontovyyPie, string name)
        {
            Console.WriteLine(bespontovyyPie.Name);
            Console.WriteLine("На, {0},кушай", name);

        }
    }
}
