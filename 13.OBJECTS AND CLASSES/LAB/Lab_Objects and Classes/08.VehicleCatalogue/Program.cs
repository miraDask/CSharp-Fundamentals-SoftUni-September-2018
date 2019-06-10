
namespace _08.VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string HorsePower { get; set; }

    }

    public class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string Weight { get; set; }
    }

    public class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            Catalogue vehicleRegister = new Catalogue();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] vehicleData = input.Split('/').ToArray();

                string vehicleType = vehicleData[0];
                string brand = vehicleData[1];
                string model = vehicleData[2];

                if (vehicleType == "Car")
                {
                    string horsePower = vehicleData[3];

                    Car currentCar = new Car();
                    currentCar.Brand = brand;
                    currentCar.Model = model;
                    currentCar.HorsePower = horsePower;

                    vehicleRegister.Cars.Add(currentCar);

                }
                else
                {
                    string weight = vehicleData[3];

                    Truck currentTruck = new Truck();
                    currentTruck.Brand = brand;
                    currentTruck.Model = model;
                    currentTruck.Weight = weight;

                    vehicleRegister.Trucks.Add(currentTruck);
                }
            }

            if (vehicleRegister.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in vehicleRegister.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (vehicleRegister.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in vehicleRegister.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }


        }
    }
}
