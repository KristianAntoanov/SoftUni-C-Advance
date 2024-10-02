using System;
namespace _07.MilitaryElite.Models.Interfaces
{
	public interface IPrivate : ISoldier
	{
		decimal Salary { get; }
	}
}

