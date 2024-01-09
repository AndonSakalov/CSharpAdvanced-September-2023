namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();
            int enginesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < enginesCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input.Length == 2)
                {
                    Engine engine = new Engine(input[0], int.Parse(input[1]));
                    engines.Add(input[0], engine);
                }
                else if (input.Length == 3)
                {
                    string thirdEmelent = input[2];
                    if (char.IsDigit(thirdEmelent[0]))
                    {
                        Engine engine = new Engine(input[0], int.Parse(input[1]), int.Parse(input[2]));
                        engines.Add(input[0], engine);
                    }
                    else
                    {
                        Engine engine = new Engine(input[0], int.Parse(input[1]), input[2]);
                        engines.Add(input[0], engine);
                    }
                }
                else
                {
                    Engine engine = new Engine(input[0], int.Parse(input[1]), int.Parse(input[2]), input[3]);
                    engines.Add(input[0], engine);
                }
            }

            int carsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input.Length == 2)
                {
                    Car car = new Car(input[0], engines[input[1]]);
                    cars.Add(car);
                }
                else if (input.Length == 3)
                {
                    string thirdElement = input[2];
                    if (char.IsDigit(thirdElement[0]))
                    {
                        Car car = new Car(input[0], engines[input[1]], int.Parse(input[2]));
                        cars.Add(car);
                    }
                    else
                    {
                        Car car = new Car(input[0], engines[input[1]], input[2]);
                        cars.Add(car);
                    }
                }
                else
                {
                    Car car = new Car(input[0], engines[input[1]], int.Parse(input[2]), input[3]);
                    cars.Add(car);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString(car)); 
            }
        }
    }
}