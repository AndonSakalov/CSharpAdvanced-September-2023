using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        private string title;
        private int year;
        private List<string> authors;

        public Book(string title, int year, params string[] authors)
        {
            this.title = title;
            this.year = year;
            this.authors = new List<string>();
        }

        public List<string> Authors
        {
            get { return authors; }
            private set { authors = value; }
        }

        public int Year
        {
            get { return year; }
            private set { year = value; }
        }


        public string Title
        {
            get { return title; }
            private set { title = value; }
        }

        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year);
            if (result == 0)
            {
                result = this.Title.CompareTo(other.Title);
            }
            return result;
        }
        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
