using System;
using _07.MilitaryElite.Enums;

namespace _07.MilitaryElite.Models.Interfaces
{
	public interface ISpecialisedSoldier : IPrivate
	{
		Corps Corps { get; }
	}
}

