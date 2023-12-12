using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSortProject
{
    internal class Person : IComparable
    {
        String firstName;
        String lastName;
        int height;
        int weight;

        public Person()
        {
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(string firstName, string lastName, int height, int weight) // Ctrl + .
        {
            FirstName = firstName;
            LastName = lastName;
            Height = height;
            Weight = weight;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value;}
        }
        public string LastName { get => lastName; set => lastName = value; }
        public int Height { get => height; set => height = value; }
        public int Weight { get => weight; set => weight = value; }

        public override string ToString()
        {
            return String.Format("{0} {1 } Height: {2}  Weight: {3}  BMI: {4:F2}", FirstName, LastName, Height, Weight, GetBMI());
        }

        public float GetBMI()
        {
            return weight / ((height / 100.0f) * (height / 100.0f));
        }

        public int CompareTo(object obj)
        {
            return this.FirstName.CompareTo(((Person)obj).FirstName);
        }

        public void SetFullName(String fullname)
        {
            if(!fullname.Contains(' '))
            {
                lastName = fullname;
            }
            else
            {
                String[] names = fullname.Split();
                LastName = names[names.Length - 1];

                for(int i = 0; i < names.Length - 1; i++)
                {
                    if (i == 0)
                        FirstName = names[i];
                    else
                        FirstName += " " + names[i];
                }
            }
        }
    }
}
