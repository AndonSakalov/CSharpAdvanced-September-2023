namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";
            GetFolderSize(folderPath, outputPath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            string[] files = Directory.GetFiles(folderPath);
            double size = 0;
            foreach (string file in files)
            {
                FileInfo currentFile = new FileInfo(file);
                size+= currentFile.Length;
            }
            using StreamWriter writer = new StreamWriter(outputFilePath);
            writer.WriteLine(size / 1000.0);
        }
    }
}
