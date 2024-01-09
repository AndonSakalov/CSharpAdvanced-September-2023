namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tiresList = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] inputTokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int counter = 0;
                var tires = new Tire[4];
                for (int i = 0; i < inputTokens.Length - 1; i += 2)
                {
                    int year = int.Parse(inputTokens[i]);
                    double pressure = double.Parse(inputTokens[i + 1]);
                    Tire tire = new Tire(year, pressure);
                    tires[counter++] = tire;
                }
                tiresList.Add(tires);
            }
            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] inputTokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(inputTokens[0]);
                double cubicCapacity = double.Parse(inputTokens[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
            }

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] inputTokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = inputTokens[0];
                string model = inputTokens[1];
                int year = int.Parse(inputTokens[2]);
                double fuelQuantity = double.Parse(inputTokens[3]);
                double fuelConsumption = double.Parse(inputTokens[4]);
                int engineIndex = int.Parse(inputTokens[5]);
                int tiresIndex = int.Parse(inputTokens[6]);
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tiresList[tiresIndex]);
                cars.Add(car);
            }

            List<Car> specialCars = cars.FindAll(car => car.Year >= 2017 && car.Engine.HorsePower > 330 && car.Tires.Sum(t => t.Pressure) > 9 && car.Tires.Sum(t => t.Pressure) < 10);

            foreach (var specialCar in specialCars)
            {
                specialCar.Drive(0.2);
            }
            foreach (var specialCar in specialCars)
            {
                Console.WriteLine(specialCar.WhoAmI());
            }
        }
    }
}