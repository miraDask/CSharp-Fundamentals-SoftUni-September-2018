
namespace _04.RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Speed { get; set; }

        public int Power { get; set; }
    }

    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public int Weight { get; set; }

        public string Type { get; set; }
    }

    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;

        }
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

    }

    public class Program
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < limit; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car currentCar = new Car(model, engine, cargo);
                cars.Add(currentCar);
            }

            string searchedCargoType = Console.ReadLine();

            if (searchedCargoType == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.Weight < 1000))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else if(searchedCargoType == "flamable" )
            {
                foreach (var car in cars.Where(c => c.Engine.Power > 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}
