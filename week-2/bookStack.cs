using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    class BookStack
    {
        private const int maxsize = 10;
        private int top = 0;
        private Book[] array = new Book[maxsize];

        // TODO: Push(Book value)
        // TODO: Pop() returning Book
        // TODO: Peek() returning Book
        // TODO: IsEmpty(), IsFull() and Count()

        public void Push(Book value)
        {
            if (IsFull())
                throw new InvalidOperationException("Stack is full");

            array[top++] = value;
        }

        public Book Pop()
        {
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Stack is empty");

                return array[--top];
            }
        }

        public Book Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            return array[top - 1];
        }

        public bool IsEmpty() { return top == 0; }
        public bool IsFull() { return top == maxsize; }
        public int Count() { return top; }

    }

}
