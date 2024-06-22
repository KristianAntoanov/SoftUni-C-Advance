using System;
namespace DefiningClasses
{
	public class Cargo
	{
		private string type;

		private int weight;


		public Cargo(int weight, string type)
		{
			Type = type;
			Weight = weight;
		}


		public int Weight
        {
			get { return weight; }
			set { weight = value; }
		}
		public string Type
		{
			get { return type; }
			set { type = value; }
		}
	}
}

