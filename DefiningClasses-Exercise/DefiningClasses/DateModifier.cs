using System;
namespace DefiningClasses
{
	public static class DateModifier
	{
		public static int GetDifferenceInDays(string start, string end)
		{
			DateTime startDate = DateTime.Parse(start);
			DateTime endDate = DateTime.Parse(end);

			TimeSpan differance = endDate - startDate;

			int differanceInDays = differance.Days;

			return Math.Abs(differanceInDays);
		}


	}
}

