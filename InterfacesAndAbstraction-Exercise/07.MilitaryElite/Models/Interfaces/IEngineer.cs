using System;
namespace _07.MilitaryElite.Models.Interfaces
{
	public interface IEngineer : ISpecialisedSoldier
    {
		IReadOnlyCollection<IRepair> Repairs { get; }
	}
}

