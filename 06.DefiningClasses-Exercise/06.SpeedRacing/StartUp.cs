namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, Car> modelCars = new Dictionary<string, Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));
                modelCars.Add(carInfo[0], car);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputTokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                modelCars[inputTokens[1]].Drive(double.Parse(inputTokens[2]));
            }

            foreach (var modelCar in modelCars)
            {
                modelCar.Value.PrintCar();
            }
        }
    }
}