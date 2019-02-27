using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFifoExample
{
    class Example
    {
        static int Fifo(int[] v, int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                int s;
                Console.WriteLine(" index = " + n);
                s = Fifo(v, n - 1);
                Console.WriteLine(" index = " + (n - 1));

                if (v[n - 1] > 0)
                {
                    Console.WriteLine(" Enter in the condition index [" + (n - 1) + "]");
                    Console.WriteLine(" v = " + v[n - 1]);
                    Console.WriteLine(" s = index [" + (n - 1) + "]");
                    Console.WriteLine(" s = s + v ");
                    Console.WriteLine(" s = " + s + " + " + v[n - 1]);
                    s = s + v[n - 1];
                    Console.WriteLine(" s  = " + s);
                }
                return s;
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 2, -4, 7, 0, -1, 4 };
            int number = 6;
            var result = Fifo(array, number);
            Console.WriteLine("Result of s = " + result);
            Console.ReadKey();
        }
    }
}
