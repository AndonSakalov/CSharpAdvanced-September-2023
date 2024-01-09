using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person> 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }
        private List<Person> People { get; set; }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
                if (result == 0)
                {
                    result = this.Town.CompareTo(other.Town);
                }
            }

            return result;
        }
    }
}
