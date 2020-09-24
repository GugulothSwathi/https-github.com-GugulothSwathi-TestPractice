using System;
using System.Collections.Generic;
using System.Text;

namespace practice1
{
    class Stringpalindrom
    {
        public static void stringPalindrom()
        {
            Console.WriteLine("Enter a string for test the palindrom or not!");
            var name = Console.ReadLine();
            //string name = "MOM";
            int len = (name.Length - 1);
            int i = 0, j = 0;
            while (i < len)
            {
                if (name[i++] != name[len--])
                {
                    Console.WriteLine("string is nor palindrom");
                }
                else
                {
                    j += 2;
                    if ((name.Length - 1) == j)
                    {
                        Console.WriteLine("string is palindrom");
                    }
                }



            }

        }
    }
}
