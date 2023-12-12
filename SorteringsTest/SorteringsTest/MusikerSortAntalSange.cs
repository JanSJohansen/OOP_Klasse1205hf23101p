using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteringsTest
{
    internal class MusikerSortAntalSange : IComparer<Musiker>
    {
        public int Compare(Musiker m1, Musiker m2)  
        {
            return m1.AntalSange - m2.AntalSange; // positiv int, negativ int eller 0
        }
    }
}
