using System;
namespace _07.MilitaryElite.Models.Interfaces
{
	public interface ICommando : ISpecialisedSoldier
	{
		IReadOnlyCollection<IMission> Missions { get; }
	}
}

