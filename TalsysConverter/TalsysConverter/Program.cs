using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalsysConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String decStr = TalsysConv.IntToDec(123);
            Console.WriteLine("Tallet 123 skulle gerne være: " + decStr);

            String binStr = TalsysConv.IntToBin(123);
            Console.WriteLine("Tallet 123 skulle gerne være: " + binStr);

            String hexStr = TalsysConv.IntToHex(123);
            Console.WriteLine("Tallet 123 skulle gerne være: " + hexStr);


            Console.ReadLine();
            
        }
    }
}
