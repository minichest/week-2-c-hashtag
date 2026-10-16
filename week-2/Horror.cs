using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    class Horror : Book
    {
        public Horror(string title) : base(null, title)
        {
            Author = new Person("Stephen King");
        }
    } 
}
