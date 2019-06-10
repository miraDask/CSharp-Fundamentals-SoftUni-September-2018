
namespace _03.SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Car
    {
        public Car(string model, double fuelAmount, double consumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionFor1km = consumption;
            TraveledDistance = 0;
        }
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionFor1km { get; set; }

        public double TraveledDistance { get; set; }

        public void AddTraveledDistance(double km)
        {
            TraveledDistance += km;
        }

        public void ReviseFuelAmount(double usedFuel )
        {
            FuelAmount -= usedFuel;
        }
    }

    public class Program
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();


            for (int i = 0; i < limit; i++)
            {
                string[] carData = Console.ReadLine().Split().ToArray();

                string model = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double fuelConsumptionFor1km = double.Parse(carData[2]);

                Car currentCar = new Car(model,fuelAmount,fuelConsumptionFor1km);
                cars.Add(currentCar);

            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] carData = input.Split().ToArray();

                string command = carData[0];
                string model = carData[1];
                double amountOfKm = double.Parse(carData[2]);

                if (cars.Any(c => c.Model == model))
                {
                    int carIndex = cars.FindIndex(c => c.Model == model);

                    double fuelNeeded = cars[carIndex].FuelConsumptionFor1km * amountOfKm;
                    double currentCarFuelAmount = cars[carIndex].FuelAmount;
                  

                    if (currentCarFuelAmount < fuelNeeded)
                    {
                        Console.WriteLine($"Insufficient fuel for the drive");
                    }
                    else
                    {
                        cars[carIndex].ReviseFuelAmount(fuelNeeded);
                        cars[carIndex].AddTraveledDistance(amountOfKm);
                    }
                }

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
