using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIITest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 256; i++)
            {
                Console.Write("{0,3} {0,3:X} {1}  ", i, (char)i);

                if (i % 10 == 9)
                {
                    Console.WriteLine();
                }
            }

            String strCifre = "0123456789ABCDEFabcdef";

            foreach(char ch in strCifre)
            {
                Console.WriteLine("{0,3} {0,3:X} {1} ", (int)ch, ch);
            }



            Console.ReadLine();
        }
    }
}
