namespace _04.ProductShop
{
    public class Product
    {
        public Product(double price, string productName)
        {
            ProductName = productName;
            Price = price;
        }
        public double Price { get; set; }
        public string ProductName { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<Product>> shopsProductInfo = new SortedDictionary<string, List<Product>>();
            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] inputArr = input.Split(", ");
                string shopName = inputArr[0];
                string productName = inputArr[1];
                double price = double.Parse(inputArr[2]);
                if (!shopsProductInfo.ContainsKey(shopName))
                {
                    Product product = new Product(price, productName);
                    shopsProductInfo[shopName] = new List<Product>();
                    shopsProductInfo[shopName].Add(product);
                }
                else
                {
                    Product product = new Product(price, productName);
                    shopsProductInfo[shopName].Add(product);
                }
            }
            foreach (var kvp in shopsProductInfo)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var product in kvp.Value)
                {
                    Console.WriteLine($"Product: {product.ProductName}, Price: {product.Price}");
                }
            }
        }
    }
}