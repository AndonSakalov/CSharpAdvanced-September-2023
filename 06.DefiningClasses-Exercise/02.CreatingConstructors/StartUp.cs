namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Person person1 = new();
            Person person2 = new(age);
            Person person3 = new(name, age);
            Console.WriteLine($"Name: {person1.Name} || Age: {person1.Age}");
            Console.WriteLine($"Name: {person2.Name} || Age: {person2.Age}");
            Console.WriteLine($"Name: {person3.Name} || Age: {person3.Age}");
        }
    }
}