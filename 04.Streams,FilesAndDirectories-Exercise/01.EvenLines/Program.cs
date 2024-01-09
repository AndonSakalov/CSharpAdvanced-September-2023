namespace EvenLines
{
    using System;
    using System.Security.Authentication;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath).ToString());
        }
        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    if (count % 2 == 0)
                    {
                        string exchangedSymbols = ExchangeSymbols(currentLine);
                        string reversedString = ReversedString(exchangedSymbols);
                        sb.AppendLine(reversedString);
                    }
                    count++;
                    currentLine = reader.ReadLine();
                }
            }

            return sb.ToString();
        }
        private static string ExchangeSymbols(string currentLine)
        {
            char[] charsToReplace = new char[] { '-', ',', '.', '!', '?' };
            StringBuilder sb = new StringBuilder(currentLine);
            foreach (char ch in charsToReplace)
            {
                sb.Replace(ch, '@');
            }
            return sb.ToString();
        }
        private static string ReversedString(string exchangedSymbols)
        {
            string[] words = exchangedSymbols.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            return string.Join(" ", words);
        }
    }
}
//-I was quick to judge him, but it
//wasn't his fault.
//-Is this some kind of joke?! Is it?
//-Quick, hide here. It is safer.