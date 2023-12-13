using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesProjekt
{
    internal class Teacher : INoget
    {
        String Name;
        int Intelligens;

        public Teacher(string name, int intelligens)
        {
            Name = name;
            Intelligens = intelligens;
        }

        public string GetSomething()
        {
            return Name + " har en intelligenskvotient på " + Intelligens;          
        }
    }
}
