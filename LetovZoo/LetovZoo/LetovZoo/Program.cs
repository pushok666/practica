using System;

namespace LetovZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BespontovyyPie pie = new BespontovyyPie();
            Console.WriteLine("Добро пожаловать в зоопарк Летова");
            Visitor visitor = new Visitor(5);
           
            WhiteBear whiteBear = new WhiteBear("Майор", "Лубянка");
            Bee bee = new Bee("Кулаки", "Колхоз");
            Lion lion = new Lion("Ленин", "Мавзолей");
            Animal[] animals = new Animal[]
            {
                whiteBear,
                bee,
                lion
            };
            foreach (var item in animals)
            {
                item.GetInfo();
                Console.WriteLine("/--------------------------------------------");
            }
            Console.WriteLine("1 - Майор, 2 - Кулаки, 3 - Ленин");
            Console.WriteLine("Кого желаете покормить?(Введите цифру от 1 до 3)");
            int str = Convert.ToInt32(Console.ReadLine());
            
            while (true)
            {
                if (str == 1)
                {
                    visitor.Feed(pie, whiteBear.Name);
                    whiteBear.EatPie();

                }
                if (str == 2)
                {
                    visitor.Feed(pie, bee.Name);
                    bee.EatPie();
                }
                if (str == 3)
                {
                    visitor.Feed(pie, lion.Name);
                    lion.EatPie();
                }
                if(str>3)
                {
                    Console.WriteLine("Вам насрали на лицо");
                }
                Console.WriteLine("Кого желаете покормить?(Введите цифру от 1 до 3)");
                str = Convert.ToInt32(Console.ReadLine());
            }
           
        }
    }
}
