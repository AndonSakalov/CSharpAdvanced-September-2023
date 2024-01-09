namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            List<string> wordsToSearch = new List<string>();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                while (reader.EndOfStream == false)
                {
                    string[] currrentLine = reader.ReadLine().Split();
                    foreach (string word in currrentLine)
                    {
                        wordsToSearch.Add(word.ToLower());
                    }
                }
            }

            using (StreamReader reader = new StreamReader(textFilePath))
            {
                char currentChar;
                while (reader.EndOfStream == false)
                {
                    string word = "";
                    while ((currentChar = (char)reader.Read()) != '\uffff')
                    {
                        if (currentChar == ' ' || currentChar == '.' || currentChar == '-' || currentChar == ',')
                        {
                            break;
                        }
                        word += currentChar;
                    }

                    word = word.ToLower();
                    if (wordsToSearch.Contains(word))
                    {
                        if (!wordsCount.ContainsKey(word))
                        {
                            wordsCount.Add(word, 0);
                        }
                        wordsCount[word]++;
                    }
                }

                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    foreach (var kvp in wordsCount.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                    }
                }
            }

        }
    }
}
