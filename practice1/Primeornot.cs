using System;
using System.Collections.Generic;
using System.Text;

namespace practice1
{
    public class Primeornot
    {    public static void primeOrnot() { 
            Console.WriteLine("Enter a number for prime num");
         var num=int.Parse(Console.ReadLine());
            int i, j = 0;
           for ( i=1;i<=num;i++)
            { 
                if (num % i == 0)
                {
                    j++;
                }
            }
           if(j==2)
            {
                Console.WriteLine("num is prime");
            }
            else
            {
                Console.WriteLine("num is not prime");
            }
          


    }

            
        }
}
