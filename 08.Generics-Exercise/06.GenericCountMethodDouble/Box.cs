using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.GenericCountMethodDouble
{
    public class Box<T> where T : IComparable<T>
    {
        private T value;
        private List<T> items;

        public Box(/*T value*/)
        {
            //Value = value;
            Items = new List<T>();
        }
        public List<T> Items
        {
            get { return items; }
            set { items = value; }
        }

        public T Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public void Add(T value)
        {
            Items.Add(value);
        }
        public int Comparer(T elementToCompare)
        {
            int biggerThan = 0;
            foreach (var item in Items)
            {
                if (item.CompareTo(elementToCompare) > 0)
                {
                    biggerThan++;
                }
            }
            return biggerThan;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
