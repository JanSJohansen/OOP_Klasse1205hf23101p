using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteringsTest
{
    internal class Musiker : IComparable
    {
        String firstName;
        String lastName;
        int antalSange;
        int birthYear;

        public Musiker() { }
        public Musiker(string firstName, string lastName, int antalSange, int birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            AntalSange = antalSange;
            BirthYear = birthYear;
        }

        public string FirstName{ get { return firstName; } set { firstName = value;} }
        public string LastName { get => lastName; set => lastName = value; }
        public int AntalSange { get => antalSange; set => antalSange = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }

        public String getFirstName() { return firstName; }
        public void setFirstName(String fn) { firstName = fn; }

        public override string ToString()
        {
            return String.Format("{0} {1}  Sange: {2}   Fødselsår: {3}", FirstName, LastName, AntalSange, BirthYear);
        }

        public int CompareTo(object obj)
        {
            int tal = this.lastName.CompareTo(((Musiker)obj).LastName);
            return tal;
        }

    }
}
