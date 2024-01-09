using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }
            return result;
        }
        public override bool Equals(object obj)
        {
            Person other = obj as Person;
            if (other is null) // safe (obj)
            {
                return false;
            }
            return this.Name == other.Name && this.Age == other.Age;
        }
        public override int GetHashCode()
        {
            int hashCode = this.Name.GetHashCode() + this.Age.GetHashCode();
            return hashCode;
        }
    }
}
