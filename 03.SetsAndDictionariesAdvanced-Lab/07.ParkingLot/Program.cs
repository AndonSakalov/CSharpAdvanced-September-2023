namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            HashSet<string> cars = new HashSet<string>();
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(", ");
                string direction = command[0];
                string carNumber = command[1];
                if (direction == "IN")
                {
                    cars.Add(carNumber);
                }
                else
                {
                    cars.Remove(carNumber);
                }
            }

            if (cars.Count > 0)
            {
                foreach (string car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}