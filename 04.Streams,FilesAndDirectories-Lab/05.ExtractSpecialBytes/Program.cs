namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";
            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            List<string> byteList = new List<string>();
            using (StreamReader reader = new StreamReader(bytesFilePath))
            {
                byteList.Add(reader.ReadLine());
            }
            using (FileStream stream = new FileStream(binaryFilePath, FileMode.OpenOrCreate))
            {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                using (FileStream stream1 = new FileStream(outputPath,FileMode.OpenOrCreate))
                {
                    foreach (byte byte1 in bytes)
                    {
                        if (byteList.Contains(byte1.ToString()))
                        {
                            stream1.WriteByte(byte1);
                        }
                    }
                }
            }
            
        }
    }
}