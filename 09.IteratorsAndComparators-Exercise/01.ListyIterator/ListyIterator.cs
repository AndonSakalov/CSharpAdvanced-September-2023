using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int index = 0;
        private List<T> items;
        public ListyIterator(List<T> list)
        {
            this.items = list;
        }

        public bool Move()
        {
            if (index + 1 < items.Count)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            return index < items.Count - 1;
        }
        public void Print()
        {
            try
            {
                Console.WriteLine(items[index]);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid Operation!");
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
