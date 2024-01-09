using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;
        public Family()
        {
            people = new List<Person>();
        }

        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public void AddMember(Person member)
        {
            People.Add(member);
        }
        public Person GetOldestMember()
        {
            return People.MaxBy(p => p.Age);
        }

        public List<Person> GetOlderThan30()
        {
            List<Person> olderThan30 = new List<Person>();
            olderThan30 = People.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
            return olderThan30;
        }
    }
}
