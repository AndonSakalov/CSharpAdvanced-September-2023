using System.ComponentModel;
using System.Text;

namespace _03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> isUpperCase = str => str[0].ToString() == str[0].ToString().ToUpper();
            List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(isUpperCase).ToList();
            Console.WriteLine(string.Join("\n", list));
        }
    }
}
