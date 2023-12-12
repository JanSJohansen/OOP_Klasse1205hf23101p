using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteringsTest
{
    internal class MusikerSortBirthYear : IComparer<Musiker>
    {
        public int Compare(Musiker x, Musiker y)
        {
            return x.BirthYear - y.BirthYear;
        }
    }
}
