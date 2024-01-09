using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private int count;
        private Stack<T> boxes;
        public Box()
        {
            boxes = new Stack<T>();
        }

        public Stack<T> Boxes
        {
            get { return boxes; }
            set { boxes = value; }
        }
        public int Count
        {
            get { return boxes.Count; }
        }
        public void Add(T item)
        {
            Boxes.Push(item);
        }
        public T Remove()
        {
            return boxes.Pop();
        }
    }
}
