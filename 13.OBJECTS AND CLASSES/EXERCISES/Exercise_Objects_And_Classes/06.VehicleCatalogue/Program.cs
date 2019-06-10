
namespace _06.VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            var vehicleCatalogue = new List<Vehicle>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                var vehicleData = input.Split().ToArray();

                string type = vehicleData[0];
                string model = vehicleData[1];
                string color = vehicleData[2];
                int horsePower = int.Parse(vehicleData[3]);

                Vehicle currentVehicle = new Vehicle()
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    Horsepower = horsePower

                };

                vehicleCatalogue.Add(currentVehicle);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue")
                {
                    break;
                }

                string modelToSearch = input;

                if (vehicleCatalogue.Any(v => v.Model == modelToSearch))
                {
                    int indexOfVehicle = vehicleCatalogue.FindIndex(v => v.Model == modelToSearch);

                    Vehicle findedVehicle = vehicleCatalogue[indexOfVehicle];

                    string type = string.Empty;

                    if (findedVehicle.Type == "car")
                    {
                        type = "Car";
                    }
                    else
                    {
                        type = "Truck";    
                    }

                    Console.WriteLine($"Type: {type}");
                    Console.WriteLine($"Model: {findedVehicle.Model}");
                    Console.WriteLine($"Color: {findedVehicle.Color}");
                    Console.WriteLine($"Horsepower: {findedVehicle.Horsepower}");

                }            
            }

            var cars = vehicleCatalogue.Where(v => v.Type == "car").ToList();
            var trucks = vehicleCatalogue.Where(v => v.Type == "truck").ToList();

            double carsAverageHorsepower = GetAverageHorsePower(cars);
            double trucksAverageHorsePower = GetAverageHorsePower(trucks);

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePower:f2}.");
        }

        private static double GetAverageHorsePower(List<Vehicle> cars)
        {
            double averageValue = 0;

            if (cars.Count > 0)
            {
                int horsePowerSum = 0;

                for (int i = 0; i < cars.Count; i++)
                {
                    horsePowerSum += cars[i].Horsepower;
                }

                averageValue = horsePowerSum /(double) cars.Count;
            }

            return averageValue;
        }
    }
}
