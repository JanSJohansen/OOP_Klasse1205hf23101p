using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSortProject
{
    enum PersonCompareEnum
    {
        CompWeight, CompHeight, CompBMI, CompFName, CompLame
    }
    internal class PersonComparer : IComparer<Person>
    {
        private PersonCompareEnum Comp;

        public PersonComparer(PersonCompareEnum comp)
        {
            this.Comp = comp;
        }
        public int Compare(Person x, Person y)
        {
            switch (Comp)
            {
                case PersonCompareEnum.CompHeight:
                    return (int)(x.Height * 100 - y.Height * 100);
                case PersonCompareEnum.CompWeight:
                    return (int)(x.Weight * 100 - y.Weight * 100);
                case PersonCompareEnum.CompBMI:
                    return (int)(x.GetBMI() * 100 - y.GetBMI() * 100);
            }
            return 0;
        }
    }
}
