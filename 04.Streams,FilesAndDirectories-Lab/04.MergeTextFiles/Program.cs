namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath,
           outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            int counter1 = 0;
            int counter2 = 0;
            using (StreamReader reader1 = new StreamReader(firstInputFilePath))
            {

                while (reader1.EndOfStream == false)
                {
                    //string currentLine = 
                    reader1.ReadLine();
                    counter1++;
                }
            }

            using (StreamReader reader2 = new StreamReader(secondInputFilePath))
            {

                while (reader2.EndOfStream == false)
                {
                    //string currentLine = 
                    reader2.ReadLine();
                    counter2++;
                }
            }

            if (counter1 > counter2)
            {

                using (StreamReader reader1 = new StreamReader(firstInputFilePath))
                {
                    using (StreamReader reader2 = new StreamReader(secondInputFilePath))
                    {
                        using (StreamWriter writer = new StreamWriter(outputFilePath))
                        {
                            for (int i = 1; i < counter1 + 1; i++)
                            {
                                string currentLine1 = reader1.ReadLine();
                                string currentLine2 = reader2.ReadLine();
                                if (i <= counter2)
                                {
                                    writer.WriteLine(currentLine1);
                                    writer.WriteLine(currentLine2);
                                }
                                else
                                {
                                    writer.WriteLine(currentLine1);
                                }
                            }
                        }
                    }
                }

            }

            else //if (counter2 > counter1)
            {
                using (StreamReader reader1 = new StreamReader(firstInputFilePath))
                {
                    using (StreamReader reader2 = new StreamReader(secondInputFilePath))
                    {
                        using (StreamWriter writer = new StreamWriter(outputFilePath))
                        {
                            for (int i = 1; i < counter2 + 1; i++)
                            {
                                string currentLine1 = reader1.ReadLine();
                                string currentLine2 = reader2.ReadLine();
                                if (i <= counter1)
                                {
                                    writer.WriteLine(currentLine1);
                                    writer.WriteLine(currentLine2);
                                }
                                else
                                {
                                    writer.WriteLine(currentLine2);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
