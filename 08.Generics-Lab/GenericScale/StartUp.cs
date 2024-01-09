namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> scale = new EqualityScale<int>(35, 23);
            Console.WriteLine(scale.AreEqual()); 
        }
    }
}