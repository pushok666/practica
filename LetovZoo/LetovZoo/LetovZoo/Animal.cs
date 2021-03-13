using System;
using System.Collections.Generic;
using System.Text;

namespace LetovZoo
{
    class Animal
    {
        public string Vid { get; set; }
        public string Name { get; set; }
        public string Valer { get; set; }
       
        public virtual void GetInfo()
        {
            Console.WriteLine("Вид животного: {0}", this.Vid);
            Console.WriteLine("Его имя: {0}", this.Name);
            Console.WriteLine("Название вольера: {0}", this.Valer);
        }

        public virtual void EatPie()
        {
            Console.WriteLine("амнямамняам");
        }
       
    }
}
