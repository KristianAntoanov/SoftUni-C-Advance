using System;
namespace _04.NeedForSpeed
{
	public class SportCar : Car
	{
        private const double DefaultFuelConsumption = 10;

        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
        public override double FuelConsumption => DefaultFuelConsumption;
    }
}

