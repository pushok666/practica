using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practik
{
    class TestTask
    {
        public bool TriangleVar(int val)
        {
            return Math.Sqrt(1 + 8 * val) % 1 == 0;
        }
        public int SuperPuperDeepCounter(int[][] arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
                for (int i = 0; i < item.Length; i++)
                {
                    count++;
                }
                count++;
            }
            Console.WriteLine(count);
            return count;
        }
        public string DeCrypt(string key, string message)
        {
            char[] arrKey = key.ToCharArray();
            char[] arrMessage = message.ToCharArray();
            for (int i = 0; i < message.Length; i++)
            {
                if (i == arrKey.Length)
                {
                    i = 0;
                }
                if ((int)Char.GetNumericValue(arrKey[i]) != i)
                {
                    int t = (int)Char.GetNumericValue(arrKey[i]);
                    arrMessage[i] = arrMessage[t];
                }
               
            }
            Console.WriteLine(new string(arrMessage));
            return message;
        }
    }
}
