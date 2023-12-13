using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<INoget> skolefolk = new List<INoget>();

            skolefolk.Add(new Elev(34, "Nikolaj"));
            skolefolk.Add(new Elev(59, "Carsten"));
            skolefolk.Add(new Elev(3, "Kim"));
            skolefolk.Add(new Teacher("Jan", 120));
            skolefolk.Add(new Teacher("Palle", 147));

            foreach (INoget noget in skolefolk)
                Console.WriteLine(noget.GetSomething());

            Console.ReadLine();
        }
    }
}
