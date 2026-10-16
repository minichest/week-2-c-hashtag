using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    class Book : IComparable
    {
        private string title;
        private Person author;

        public Book(Person author, string title)
        {
            Title = title;
            Author = author; // default author is null
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Person Author 
        {
            get { return author; }
            set { author = value; }
        }
        // TODO: property for accessing Title
        // TODO: property for accessing Author

        // TODO: constructor receiving title

        // TODO: constructor receiving author and title

        public int CompareTo(object obj)
        {
            Book other = (Book)obj;
            return Title.CompareTo(other.Title);
        }

        public string getSummary()
        {
            return "" + Title + " was made by " + Author.Name + " and the author is " + Author.Age +  " years old. ";
        }

    }
}
