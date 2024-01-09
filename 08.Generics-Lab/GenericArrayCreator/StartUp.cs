namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(3,"kotka");
            int[] ints = ArrayCreator.Create(100, 3);
        }
    }
}