using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            Weight = weight;
        }
        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            Color = color;
        }
        public Car(string model, Engine engine, int weight, string color) : this(model, engine, weight)
        {
            Color = color;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string ToString(Car car)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{car.Model}:");
            sb.AppendLine($"  {car.Engine.Model}:");
            sb.AppendLine($"    Power: {car.Engine.Power}");
            if (car.Engine.Displacement != default)
            {
                sb.AppendLine($"    Displacement: {car.Engine.Displacement}");
            }
            else
            {
                sb.AppendLine($"    Displacement: n/a");
            }
            if (car.Engine.Efficiency != default)
            {
                sb.AppendLine($"    Efficiency: {car.Engine.Efficiency}");
            }
            else
            {
                sb.AppendLine($"    Efficiency: n/a");
            }
            if (car.Weight != default)
            {
                sb.AppendLine($"  Weight: {car.Weight}");
            }
            else
            {
                sb.AppendLine($"  Weight: n/a");
            }
            if (car.Color != default)
            {
                sb.AppendLine($"  Color: {car.Color}");
            }
            else
            {
                sb.AppendLine($"  Color: n/a");
            }
            return sb.ToString().TrimEnd();
        }
    }
}


