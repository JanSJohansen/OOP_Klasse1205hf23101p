using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteringsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object[] objekter = new Object[5];
            /*
            List<String> strings = new List<String>() {"Kim", "Carsten", "Nikolaj", "Marcus", "Malthe", "Theis"};
            strings.Add("Mads");
            strings.Add("Jan");
            foreach (String navn in strings)
                Console.WriteLine(navn);

            Console.WriteLine("\nSorteret:");
            strings.Sort();
            foreach (String navn in strings)
                Console.WriteLine(navn);

            String mus = "Mus";
            String elefant1 = "MylefantA";
            String elefant2 = "ElefantB";

            Console.WriteLine("Mus er størst:  " + mus.CompareTo(elefant1));  // 
            Console.WriteLine("Elefant er mindst:  " + elefant1.CompareTo(mus));  // 
            Console.WriteLine("Elefanter er lige store:  " + elefant2.CompareTo(elefant1));  // 
            */

            Musiker musiker1 = new Musiker();
            musiker1.FirstName = "Ben";
            musiker1.setFirstName("Ben");
            musiker1.LastName = "Webster";
            musiker1.BirthYear = 1909;
            musiker1.AntalSange = 27;

            Musiker musiker2 = new Musiker("Keith", "Richard", 1, 1897);

            List<Musiker> musikere = new List<Musiker>();
            musikere.Add(musiker1);
            musikere.Add(new Musiker("Jimi", "Hendrix", 42, 1942));
            musikere.Add(new Musiker("Bob", "Marley", 37, 1939));
            musikere.Add(new Musiker("Keld", "Heick", 942, 1923));

            foreach (Musiker mus in musikere)
                Console.WriteLine(mus);
            Console.WriteLine("Sorteret: ");
            musikere.Sort();
            foreach (Musiker mus in musikere)
                Console.WriteLine(mus);

            //musiker1.CompareTo(musiker2);
            Console.WriteLine("Sorteret på Antal Sange: ");
            musikere.Sort(new MusikerSortAntalSange());
            foreach (Musiker mus in musikere)
                Console.WriteLine(mus);

            Console.WriteLine("Sorteret på Fødselsår: ");
            musikere.Sort(new MusikerSortBirthYear(hvilken property));
            foreach (Musiker mus in musikere)
                Console.WriteLine(mus);


            Console.ReadLine();
        }
    }
}
