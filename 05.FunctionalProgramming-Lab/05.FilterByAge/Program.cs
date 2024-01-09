using System.Threading.Channels;

namespace _05.FilterByAge
{
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(", ");
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person person = new Person(name, age);
                people.Add(person);
            }

            string condition = Console.ReadLine();
            int ageCondition = int.Parse(Console.ReadLine());
            Func<Person, int, bool> filter = CreateFilter(condition, ageCondition);
            people = people.Where(person => filter(person,ageCondition)).ToList();
            string printer = Console.ReadLine();
            Action<Person> format = FormatCreator(printer);
            people.ForEach(format);
        }

        static Func<Person,int, bool> CreateFilter(string condition, int ageCondition)
        {
            Func<Person, int, bool> filter = null;
            if (condition == "older")
            {
                filter = (person, ageCondition) => person.Age>= ageCondition;
            }
            if (condition == "younger")
            {
                filter = (person, ageCondition) => person.Age < ageCondition;
            }
            return filter;
        }
        static Action<Person> FormatCreator(string printer)
        {
            if (printer == "name")
            {
                return p => Console.WriteLine($"{p.Name}");
            }
            if (printer == "age")
            {
                return p => Console.WriteLine($"{p.Age}");
            }
            if (printer == "name age")
            {
                return p => Console.WriteLine($"{p.Name} - {p.Age}");
            }
            return null;
        }
    }
}