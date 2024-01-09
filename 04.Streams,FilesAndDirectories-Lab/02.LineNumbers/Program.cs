namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            RewriteFileWithLineNumbers(inputPath, outputPath);
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int counter = 1;
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while (reader.EndOfStream == false)
                    {
                        string currentLine = reader.ReadLine();
                        writer.WriteLine($"{counter}. {currentLine}");
                        counter++;
                    }
                }
            }
        }
    }
}
