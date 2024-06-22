namespace DefiningClasses
{
    using System;
    using System.Drawing;
    using System.Security.Cryptography;
    using CarSalesman;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] inputEngine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = inputEngine[0];
                int power = int.Parse(inputEngine[1]);
                int displacement = 0;
                string efficiency = "n/a";
                if (inputEngine.Length > 3)
                {
                    displacement = int.Parse(inputEngine[2]);
                    efficiency = inputEngine[3];
                    Engine engine = new Engine(model, power, displacement, efficiency);
                    if (!engines.ContainsKey(model))
                    {
                        engines[model] = engine;
                    }
                }
                else if (inputEngine.Length > 2)
                {
                    if (char.IsDigit(inputEngine[2].First()))
                    {
                        displacement = int.Parse(inputEngine[2]);
                    }
                    else
                    {
                        efficiency = inputEngine[2];
                    }
                    Engine engine = new Engine(model, power, displacement, efficiency);
                    if (!engines.ContainsKey(model))
                    {
                        engines[model] = engine;
                    }
                }
                else
                {
                    Engine engine = new Engine(model, power);
                    if (!engines.ContainsKey(model))
                    {
                        engines[model] = engine;
                    }
                }
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] inputCars = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = inputCars[0];
                string engine = inputCars[1];
                int weight = 0;
                string color = "n/a";
                //{model} {engine} {weight} {color}
                if (inputCars.Length > 3)
                {
                    weight = int.Parse(inputCars[2]);
                    color = inputCars[3];
                }
                else if (inputCars.Length > 2)
                {
                    if (char.IsDigit(inputCars[2].First()))
                    {
                        weight = int.Parse(inputCars[2]);
                    }
                    else
                    {
                        color = inputCars[2];
                    }
                }
                Engine currEngine = engines[engine];

                if (weight != 0 && color != string.Empty)
                {
                    Car car = new Car(model, currEngine, weight, color);
                    cars.Add(car);
                }
                else if (weight != 0)
                {
                    Car car = new Car(model, currEngine, weight);
                    cars.Add(car);
                }
                else if (color != string.Empty)
                {
                    Car car = new Car(model, currEngine, weight, color);
                    cars.Add(car);
                }
                else
                {
                    Car car = new Car(model, currEngine);
                    cars.Add(car);
                }
            }
            foreach (var currCar in cars)
            {
                Console.WriteLine(currCar.ToString());
            }
        }
    }
}