using System;
using System.Collections.Generic;
using System.Text;

namespace Practik
{
    class BK
    {
        public int fVar { get; set; }//число у которого вычисляется факториал
        private int result = 1; // доп переменная для поиска факториала
        private int t = 0;// доп переменная для сортировки пузырьком
        private int maxNumber = 0;// доп переменная для поиска макс числа

        public void FactorialI()//вычисление факториала итерационно
        {
            for (int i = 1; i <= this.fVar; i++)
            {
                
                result *= i;
            }
            Console.WriteLine(result);
        }

        public int FactorialR(int x)//вычисление факториала через рекурсию
        {
            
            if (x <= 0)
            {
                return 1;
            }
            else
            {
                return x * FactorialR(x - 1);
            }

        }

        public void Bubble(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        public void SearchMaxNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1<=arr.Length-1)
                {
                    if (arr[i] >= arr[i + 1])
                    {
                        maxNumber = arr[i];
                    }
                    else
                    {
                        maxNumber = arr[i + 1];
                    }
                }
            }
            Console.WriteLine(maxNumber);
        }

        public void reverseArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        
    }
}
