using System;
using System.Collections.Generic;
using System.Text;

namespace Practik
{
    public class TaskArrays
    {
        public int hourglassSum(int[][] arr)
        {
            //int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i >= 1 && i <= 4 && j >= 1 && j <= 4)
                    {
                        Console.WriteLine("+");
                    }
                }


            }
            return 0;
        }
    }
}
