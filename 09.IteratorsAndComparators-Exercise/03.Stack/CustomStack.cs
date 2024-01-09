using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> stack = new List<T>();
        public List<T> Stack
        {
            get { return stack; }
            private set { stack = value; }
        }
        public void Push(T[] items)
        {
            foreach (var item in items)
            {
                stack.Add(item);
            }
        }
        public void Pop()
        {
            try
            {
                stack.RemoveAt(stack.Count - 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No elements");
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in stack)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
