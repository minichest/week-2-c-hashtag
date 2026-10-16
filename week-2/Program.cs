using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person author = new Person("Edi");
            Console.WriteLine($"Name: {author.Name}, age: {author.Age}");

            Person author2 = new Person("Natasha");
            author2.Age = 22;

            Console.WriteLine($"Name: {author2.Name}, age: {author2.Age}");
        }
    }
}
