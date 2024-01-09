namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";
            ExtractOddLines(inputFilePath, outputFilePath);
        }
        public static void ExtractOddLines(string inputFilePath, string
       outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int counter = 0;
                    while (reader.EndOfStream == false)
                    {
                        string currentLine = reader.ReadLine();
                        if (counter++ % 2 != 0)
                        {
                            writer.WriteLine(currentLine);
                        }
                    }
                }
            }
        }
    }
}


