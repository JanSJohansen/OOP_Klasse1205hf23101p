using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesProjekt
{
    internal class Elev : INoget
    {
        int Sygedage = 70;
        String Name = "Ornlig Syg";

        public Elev(int sygedage, string name)
        {
            Sygedage = sygedage;
            Name = name;
        }

        public string GetSomething()
        {
            return Name + " har " + Sygedage + " sygedage";
        }
    }
}
