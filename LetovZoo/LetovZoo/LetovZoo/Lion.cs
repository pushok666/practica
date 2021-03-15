using System;
using System.Collections.Generic;
using System.Text;

namespace LetovZoo
{
    class Lion:Animal
    {
        public Lion(string name, string valer)
        {
            Vid = "Лев";
            Name = name;
            Valer = valer;
        }

        public override void EatPie()
        {
            RazlogitsaNaPlesenILipovuiMed();
        }
        private void RazlogitsaNaPlesenILipovuiMed()
        {

            Console.WriteLine("{0} разложисля на плесень и липовый мед",this.Name);
        }
    }
}
