using System;
namespace DefiningClasses
{
	public class Car
	{
		private string model;
		private Engine engine;
		private Cargo cargo;
		private Tire[] tires;

		public Car(string model, int speed,
			int power, int weight,
			string type,
			double tire1Pessure, int tire1age,
			double tire2Pessure, int tire2age,
            double tire3Pessure, int tire3age,
            double tire4Pessure, int tire4age)
		{
			Model = model;
			Engine = new Engine(speed, power);
			Cargo = new Cargo(weight, type);
			Tires = new Tire[4];
			Tires[0] = new Tire(tire1Pessure, tire1age);
			Tires[1] = new Tire(tire2Pessure, tire2age);
			Tires[2] = new Tire(tire3Pessure, tire3age);
			Tires[3] = new Tire(tire4Pessure, tire4age);
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
		public Cargo Cargo
		{
			get { return cargo; }
			set { cargo = value; }
		}
		public Tire[] Tires
		{
			get { return tires; }
			set { tires = value; }
		}

	}
}

