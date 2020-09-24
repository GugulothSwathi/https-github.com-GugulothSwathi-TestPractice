using System;
using System.Collections.Generic;
using System.Text;

namespace practice1
{
    class NumPalindrom
    {
        public static void NumPal()
        {
            Console.WriteLine("Enter a number for palindrom");
            var num = int.Parse(Console.ReadLine());
            var temp = num;
            int s = 0,r;
            while(num>0)
            {
                r = num % 10;
                s = (s * 10) + r;
                num = num / 10;
                Console.WriteLine("s={1} , r={0} , num={2} ", r, s, num);
            }

            if(s==temp)
            {
                Console.WriteLine("num is Palindrom");
            }
            else
            {
                Console.WriteLine("num is not palindrom");
            }
        }
    }
}
