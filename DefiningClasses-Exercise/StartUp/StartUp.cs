using System;
using System.Runtime.ConstrainedExecution;
using StartUp;

namespace SoftUniParking
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputCars = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //{model} {fuelAmount} {fuelConsumptionFor1km}
                string model = inputCars[0];
                double fuelAmount = double.Parse(inputCars[1]);
                double fuelConsumptionFor1km = double.Parse(inputCars[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);

                if (!cars.ContainsKey(car.Model))
                {
                    cars[car.Model] = car;
                }
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //Drive {carModel} {amountOfKm}

                string command = cmdArgs[0];
                string carModel = cmdArgs[1];
                int amountOfKm = int.Parse(cmdArgs[2]);

                if (command == "Drive")
                {
                    if (cars.ContainsKey(carModel))
                    {
                        cars[carModel].Drive(amountOfKm);
                    }
                }
            }
            foreach (var currCar in cars)
            {
                Console.WriteLine($"{currCar.Key} {currCar.Value.FuelAmount:f2} {currCar.Value.TravelledDistance}");
            }
        }

    }
}
