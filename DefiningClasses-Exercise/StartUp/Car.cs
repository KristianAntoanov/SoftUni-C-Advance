using System;
namespace StartUp
{
	public class Car
	{
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public string Model { get; set; }
		public double FuelAmount { get; set; }
		public double FuelConsumptionPerKilometer { get; set; }
		public double TravelledDistance { get; set; }


		public void Drive(int distanceForDrive)
		{
			if (distanceForDrive * FuelConsumptionPerKilometer <= FuelAmount)
			{
				FuelAmount -= distanceForDrive * FuelConsumptionPerKilometer;
				TravelledDistance += distanceForDrive;
            }
			else
			{
				Console.WriteLine("Insufficient fuel for the drive");
            }
		}
	}
}

