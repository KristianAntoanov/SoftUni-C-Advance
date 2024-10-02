using System;
using FoodShortage.Models.Iterfaces;

namespace _06.FoodShortage.Models.Iterfaces
{
	public interface IBuyer : INameable
	{
		int Food { get; }
		void BuyFood();
    }
}

