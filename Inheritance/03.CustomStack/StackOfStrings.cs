using System;
namespace _03.CustomStack
{
	public class StackOfStrings : Stack<string>
	{
		public bool IsEmpty()
		{
			if (this.Any())
			{
				return true;
			}
			return false;
		}
		public Stack<string> AddRange(string[] range)
		{
			foreach (var item in range)
			{
				this.Push(item);
			}
			return this;
		}

    }
}

