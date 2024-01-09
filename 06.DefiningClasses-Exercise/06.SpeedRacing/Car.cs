using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilomter = fuelConsumptionPerKilometer;
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }
        public double FuelConsumptionPerKilomter
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }
        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }
        public void Drive(double kms)
        {
            if (FuelAmount >= kms * FuelConsumptionPerKilomter)
            {
                FuelAmount -= kms * fuelConsumptionPerKilometer;
                TravelledDistance += kms;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public void PrintCar()
        {
            Console.WriteLine($"{Model} {FuelAmount:F2} {TravelledDistance}");
        }
    }
}
