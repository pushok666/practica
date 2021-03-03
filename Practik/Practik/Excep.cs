using System;
using System.Collections.Generic;
using System.Text;

namespace Practik
{
    class Excep
    {
        public int a { get; set; }
        public int b { get; set; }

        public void Delenie(int a, int b)
        {
            try
            {
                b = a / 1;
                Console.WriteLine("result: {0}", b);
            }
            catch
            {
                Console.WriteLine("возникло исключение");
            }
            finally
            {
                Console.WriteLine("block finaly");
            }
        }
    }
}
