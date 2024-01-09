namespace _11.TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> validStringValueChecker = (str, charValue) =>
            {
                int currentStrValue = 0;
                foreach (var ch in str)
                {
                    currentStrValue += ch;
                }
                return currentStrValue >= charValue;
            };

            Func<List<string>, Func<string, int, bool>, int, string> getFirstName = (strs, validChecker, charsValue) =>
                strs.FirstOrDefault(str => validChecker(str, charsValue));

            int charValue = int.Parse(Console.ReadLine());
            List<string> strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string foundName = getFirstName(strings, validStringValueChecker, charValue);
            Console.WriteLine(foundName);
        }
    }
}