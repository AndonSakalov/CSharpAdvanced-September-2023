namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, Car> modelCars = new Dictionary<string, Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), input[4], double.Parse(input[5]), int.Parse(input[6]), double.Parse(input[7]), int.Parse(input[8]), double.Parse(input[9]), int.Parse(input[10]), double.Parse(input[11]), int.Parse(input[12]));
                modelCars.Add(input[0], car);
            }
            string filter = Console.ReadLine();
            List<string> filteredCarsModel = new List<string>();
            foreach (var modelCar in modelCars)
            {
                if (filter == "fragile")
                {
                    if (modelCar.Value.Cargo.Type == "fragile" && modelCar.Value.Tires.Any(t => t.Pressure < 1))
                    {
                        filteredCarsModel.Add(modelCar.Key);
                    }
                }
                else
                {
                    if (modelCar.Value.Cargo.Type == "flammable" && modelCar.Value.Engine.Power > 250)
                    {
                        filteredCarsModel.Add(modelCar.Key);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, filteredCarsModel));
        }
    }
}