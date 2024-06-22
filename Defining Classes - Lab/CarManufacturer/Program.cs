namespace CarManufacturer
{
    using System;
    using System.Runtime.ConstrainedExecution;

    public class StartUp
    {
        static void Main(string[] args)
        {
            //Tire[] tires = new Tire[4]
            //{
            //    new Tire(1, 2.5),
            //    new Tire(1, 2.1),
            //    new Tire(2, 0.5),
            //    new Tire(2, 2.3),
            //};
            //Engine engine = new Engine(560, 6300);

            //Car car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            List<double[]> tires = new List<double[]>();
            List<double[]> engines = new List<double[]>();
            List<Car> cars = new List<Car>();

            string inputTires = string.Empty;
            string inputEngine = string.Empty;
            while ((inputTires = Console.ReadLine()) != "No more tires")
            {
                double[] cmdArgs = inputTires
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                tires.Add(cmdArgs);
            }
            while ((inputEngine = Console.ReadLine()) != "Engines done")
            {
                double[] cmdArgs = inputEngine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                engines.Add(cmdArgs);   
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                int fuelQuantity = int.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]) / 100;
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);
                Tire[] currTires = new Tire[4]
                {
                    new Tire((int)tires[tiresIndex][0], tires[tiresIndex][1]),
                    new Tire((int)tires[tiresIndex][2], tires[tiresIndex][3]),
                    new Tire((int)tires[tiresIndex][4], tires[tiresIndex][5]),
                    new Tire((int)tires[tiresIndex][6], tires[tiresIndex][7]),
                };
                Engine currEngine = new Engine((int)engines[engineIndex][0], engines[engineIndex][1]);


                Car currCar = new Car(make, model, year, fuelQuantity, fuelConsumption, currEngine, currTires);
                cars.Add(currCar);

            }
            foreach (var currCar in cars)
            {
                if (currCar.Year >= 2017 && currCar.Engine.HorsePower > 330 && currCar.Tires.Sum(x => x.Pressure) >= 9 && currCar.Tires.Sum(x => x.Pressure) <= 10)
                {
                    currCar.Drive(20);
                    Console.WriteLine(currCar.WhoAmI());
                }
            }
        }
    }
}
