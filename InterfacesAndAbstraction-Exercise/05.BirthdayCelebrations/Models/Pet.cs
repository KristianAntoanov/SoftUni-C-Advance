using System;
using _05.BirthdayCelebrations.Models.Iterfaces;

namespace _05.BirthdayCelebrations.Models
{
	public class Pet : INameable, IBirthable
	{
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; private set; }
		public string Birthdate { get; private set; }
	}
}

