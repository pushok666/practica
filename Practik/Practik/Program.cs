using System;
using System.Collections.Generic;
using System.Threading;
using Practik;



namespace Practik
{

    class Program
    {

        static void Main(string[] args)
        {



            
            //Console.WriteLine(countingValleys(8, "DDUUDDUDUUUD"));
            //Console.WriteLine(repeatedString("aba", 10));
            Random rand = new Random();
            TaskArrays taskArrays = new TaskArrays();
            BK bk = new BK();
            bk.fVar = 10;
            Console.WriteLine("как вычислить вам факториал? 1 - итерационно 2 - рекурсией");
            string vubor = Console.ReadLine();
            if(vubor == "1")
            {
                bk.FactorialI();
            }
           if(vubor == "2")
            {
                Console.WriteLine(bk.FactorialR(10));
            }
            
            
            int[] arr = new int[5];
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }
            Console.WriteLine("до сортировки");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("\n ");
            //-----------------------Работа с массивом
            bk.reverseArr(arr);// обратный вывод массива
            Console.WriteLine("после");
            bk.Bubble(arr);//сортировка пузырьком 
            Console.WriteLine("максимальное число массива");
            bk.SearchMaxNumber(arr);//поиск максимального числа
            //-----------------------работа с исключениями
            Excep excep = new Excep();
            excep.a = 5;
            excep.b = 0;
            excep.Delenie(excep.a, excep.b);
            Human human = new Human();
            human.Name = "danay";
            human.SayHelloBitch();
            Boozer boozer = new Boozer();
            Console.WriteLine(boozer.Name = "толик еболик");
            boozer.PrositMoney();
            Human drager = new Drager();// upcast конкретное к общему
            Drager drager1 = (Drager)drager;// downcast  общее к конкретному
            Boozer crosman = new Drager();
            
            
            
            
            Console.ReadKey();
        }

        //---------------------- задачи с hackerrank
        public static int countingValleys(int steps, string path) 
        {
            int voley = 0;
            //int sLevel = 0;
            int uCheck = 0;
            int dCheck = 0;
            char[] oStep = path.ToCharArray();
            for (int i = 0; i < oStep.Length; i++)
            {

                if (oStep[i] == 'U')
                {
                    uCheck++;
                }
                if (oStep[i] == 'D')
                {
                    dCheck++;
                }
                if (uCheck == 0 && dCheck == 1)
                {
                    voley++;
                }
                if (uCheck == dCheck)
                {
                    uCheck = 0;
                    dCheck = 0;
                }
            }
            return voley;

        }
        static int jumpingOnClouds(int[] c)
        {
            int result = 0;
            for (int i = 0; i < c.Length; i++)
            {

            }
            return result;
        }

        static long repeatedString(string s, long n)
        {
            int counter = 0;
            int result = 0;
            int i = 0;
            while (counter != n)
            {
                if (s[i] == 'a')
                    result++;
                i++;
                if (i == s.Length)
                    i = 0;
                counter++;
            }
            return result;

        }


    }
}
