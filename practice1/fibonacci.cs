using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace practice1
{
    class fibonacci
    {
        public static void Fibonacci()
        {
            int i = 0, j = 1,z;
            Console.WriteLine("enter a number");
            var num = int.Parse(Console.ReadLine());
            Console.Write("{0} {1} ", i, j);
            for (int x=2;x<=num;x++)
            {
                z = i + j;
                Console.Write("{0} ",z);
                i = j;
                j = z;
            }

        }
    }
}
