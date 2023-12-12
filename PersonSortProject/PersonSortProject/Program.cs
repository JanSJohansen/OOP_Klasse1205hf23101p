using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSortProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Janne", "Johansen", 175, 79);
            p1.SetFullName("Hanne Lilja Solstråle CD%#¤%FTP Trump");

            List<Person> persons = new List<Person>();
            persons.Add(p1);
            persons.Add(new Person("Hanse", "Pedersen", 185, 65));
            persons.Add(new Person("Lasse", "Nielseno", 165, 90));
            persons.Add(new Person("Ahmad", "Mulimand", 170, 75));
            persons.Add(new Person("Signe", "Svendsen", 155, 62));

            foreach (Person p in persons)
                Console.WriteLine(p);

            Console.WriteLine("Sorted på Height:");
            persons.Sort(new PersonComparer(PersonCompareEnum.CompHeight));
            foreach (Person p in persons)
                Console.WriteLine(p);

            Console.WriteLine("Sorted på Weight:");
            persons.Sort(new PersonComparer(PersonCompareEnum.CompWeight));
            foreach (Person p in persons)
                Console.WriteLine(p);

            Console.WriteLine("Sorted på BMI:");
            persons.Sort(new PersonComparer(PersonCompareEnum.CompBMI));
            foreach (Person p in persons)
                Console.WriteLine(p);

            Console.ReadLine();
        }
    }
}
