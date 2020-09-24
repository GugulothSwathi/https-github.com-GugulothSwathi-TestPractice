using System;
using System.Collections.Generic;
using System.Text;

namespace practice1
{
    class primeseries
    {
        public static void primelist()
        {
            int i, n ,c,j;
            Console.WriteLine("enter a number for prime series");
            n = int.Parse(Console.ReadLine());
            for (i = 2; i <=n; i++)
            {
                c = 0;
                for ( j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        c++;break;

                    }
                }
                if (c == 0 && i!=1)
                {
                    Console.Write("{0} ", i);
                }
            }
          
        }
    }
}
