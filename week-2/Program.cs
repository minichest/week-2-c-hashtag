using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
            books[0].Author.Age = 72;

            books[1] = new Horror("The Shining");
            books[1].Author.Age = 79;

            books[2] = new Book(new Person("James Joyce"), "Ulysses");
            books[2].Author.Age = 58;

            foreach (Book book in books)
            {
                Console.WriteLine(book.getSummary());
            }

            Console.WriteLine("\n");

            IntStack test = new IntStack(); 

            test.Push(10);
            test.Push(20);
            test.Push(30);

            Console.WriteLine(test.Pop());
            Console.WriteLine(test.Peek());
            Console.ReadKey();

            Console.WriteLine("\n");

            BookStack reading = new BookStack();

            reading.Push(books[0]);
            reading.Push(books[1]);
            reading.Push(books[2]);

            Console.WriteLine("Count: " + reading.Count());
            Console.WriteLine("Removed: " + reading.Pop().Title);
            Console.WriteLine("Next: " + reading.Peek().Title);
            Console.WriteLine("Count: " + reading.Count());
            }

        }
    }
}
