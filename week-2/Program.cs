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

            int result = author.CompareTo(author2);
            Console.WriteLine(result);

            Console.WriteLine("\n");

            Book[] books = new Book[3];

            books[0] = new Book(new Person("Herman Melville"), "Moby Dick");
            books[1] = new Horror("The Shining");
            books[2] = new Book(new Person("James Joyce"), "Ulysses");

            foreach (Book book in books)
            {
                Console.WriteLine("{0} wrote {1}", book.Author.Name, book.Title);
            }

        }
    }
}
