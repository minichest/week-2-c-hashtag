using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    internal class Person : IComparable
    {
        private int age;
        private string name;

        public Person(string name) // constructor with one argument
        {
            Name = name;
            age = 18; // default age
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // TODO: add an Age property here
        public int Age
        {
            get { return age; }
            set { 
                if (age > 0) {
                    age = value; 
                } else
                {
                    throw new Exception("Age must be greater than 0");
                }
            }
        }

        public int CompareTo(object obj) //implementation of CompareTo for IComparable
        {
            Person other = (Person)obj;
            return Name.CompareTo(other.Name);
        }
    }
}