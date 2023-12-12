using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumProjekt
{
    enum BilEnum
    {
        Audi = 5, Bugatti, Citroén, Dodge, Elva, Ferrari, GMC, Honda, Isuzu
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BilEnum bil = BilEnum.Audi;
            int audiNo = (int)bil;
            BilEnum bil2 = (BilEnum)8;

            Console.WriteLine(BilEnum.Audi + " har nummer " + (int)BilEnum.Audi);
            Console.WriteLine("Nummeret " + 7 + " er " + (BilEnum)7);

            Console.WriteLine();

            BilEnum[] enums = (BilEnum[])Enum.GetValues(typeof(BilEnum));
            foreach (BilEnum b in enums)
                Console.WriteLine(b + " har nummer " + (int)b);
            



            String k = getSomeThing(BilEnum.Honda);

            Console.ReadLine();
        }

        static String getSomeThing(BilEnum bil)
        {
            String kvali = "";
            switch(bil)
            {
                case BilEnum.Audi:
                    kvali = "Et ret godt køretøj";
                    break;
                case BilEnum.Ferrari:
                    kvali = "Et ret hurtigt køretøj";
                    break;
                case BilEnum.Honda:
                    kvali = "Et ret stabilt køretøj";
                    break;
            }
            return kvali;
        }
    }
}
