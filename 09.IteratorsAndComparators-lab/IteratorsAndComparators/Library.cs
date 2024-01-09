using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books.ToList());
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex = -1;
            public LibraryIterator(List<Book> books)
            {
                this.books = new List<Book>(books);
            }
            public Book Current => this.books[currentIndex];

            object IEnumerator.Current => this.Current;


            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex < this.books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
            public void Dispose()
            {
            }
        }
    }
}
