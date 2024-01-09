using System.IO;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";
            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }
        public static void SplitBinaryFile(string sourceFilePath, string
       partOneFilePath, string partTwoFilePath)
        {
            using FileStream reader = new FileStream(sourceFilePath, FileMode.Open);
            using FileStream writer1 = new FileStream(partOneFilePath, FileMode.OpenOrCreate);
            using FileStream writer2 = new FileStream(partTwoFilePath, FileMode.OpenOrCreate);
            byte[] bytes = new byte[reader.Length];
            while (reader.Read(bytes, 0, bytes.Length) != 0)
            {

            }

            if (bytes.Length % 2 != 0)
            {
                for (int i = 0; i <= bytes.Length / 2; i++)
                {
                    writer1.WriteByte(bytes[i]);
                }
                for (int j = bytes.Length / 2 + 1; j < bytes.Length; j++)
                {
                    writer2.WriteByte(bytes[j]);
                }
            }
            else
            {
                for (int i = 0; i < bytes.Length / 2; i++)
                {
                    writer1.WriteByte(bytes[i]);
                }
                for (int i = bytes.Length / 2; i < bytes.Length; i++)
                {
                    writer2.WriteByte(bytes[i]);
                }
            }
        }
        public static void MergeBinaryFiles(string partOneFilePath, string
       partTwoFilePath, string joinedFilePath)
        {
            using FileStream reader1 = new FileStream(partOneFilePath,FileMode.Open);
            using FileStream reader2 = new FileStream(partTwoFilePath,FileMode.Open);
            using FileStream writer = new FileStream(joinedFilePath, FileMode.OpenOrCreate);

            byte[] bytes1 = new byte[reader1.Length];
            byte[] bytes2 = new byte[reader2.Length];
            while (reader1.Read(bytes1, 0, bytes1.Length) != 0)
            {
                writer.Write(bytes1, 0, bytes1.Length);
            }
            while (reader2.Read(bytes2, 0, bytes2.Length) != 0)
            {
                writer.Write(bytes2, 0, bytes2.Length);
            }

        }
    }
}
