using System;
using System.Reflection;

namespace ImplementingList
{
	public class CustomList<T> where T : IEquatable<T>
	{
		private const int initialCapacity = 2;
		private T[] items;

		public CustomList()
		{
			items = new T[initialCapacity];
		}

		public int Count { get; private set; }

		//set value by index and get value by index ------------------
		public T this[int index]
		{
			get
            {
                ThrowExeptionIfIndexOutOfRange(index);
                return items[index];
            }
            set
			{
				items[index] = value;
			}

		}
        //-----------------------------------------------------------
        public void Add(T item)
		{
			if (items.Length == Count)
			{
				Resize();
			}
			items[Count] = item;

			Count++;  
		}
		public void AddRange(T[] items)
		{
			foreach (var item in items)
			{
				Add(item);
			}
		}
		public T RemoveAt(int index)
		{
			ThrowExeptionIfIndexOutOfRange(index);
			T removeItem = items[index];
			ShiftLeft(index);

			Count--;

			if (Count <= items.Length / 4)
            {
                Shrink();
            }
			items[Count] = default;
            return default;
		}
        private void Resize()
		{
			T[] copy = new T[items.Length * 2];

			for (int i = 0; i < Count; i++)
			{
				copy[i] = items[i];
			}
			items = copy;
		}
        private void ThrowExeptionIfIndexOutOfRange(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Invalid index value");
            }
        }
		private void ShiftLeft(int index)
		{
			for (int i = index; i < Count - 1; i++)
			{
				items[i] = items[i + 1];
			}

		}
        private void ShiftRight(int index)
        {
			for (int i = Count - 1; i >= index; i--)
			{
				items[i - 1] = items[i];
			}
        }
        private void Shrink()
        {
            T[] copy = new T[items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
		public void InsertAt(int index, T item)
        {
            ThrowExeptionIfIndexOutOfRange(index);

            if (items.Length == Count)
            {
                Resize();
            }
            ShiftRight(index);

            items[index] = item;
            Count++;
        }
		public bool Contains(T item)
		{
			for (int i = 0; i < Count; i++)
			{
				if (items[i].Equals(item))
				{
					return true;
				}
			}
			return false;
		}
		public void Swap(int firstIndex, int secondIndex)
		{
			ThrowExeptionIfIndexOutOfRange(firstIndex);
			ThrowExeptionIfIndexOutOfRange(secondIndex);

			T temp = items[firstIndex];
			items[firstIndex] = items[secondIndex];
			items[secondIndex] = temp;
        }
		public T Remove(T item)
		{
			if (items.Contains(item))
			{
				for (int i = 0; i < Count; i++)
				{
                    if (items[i].Equals(item))
                    {
                        ShiftLeft(i);
                    }
                }
                items[Count - 1] = default;
                Count--;

                if (Count <= items.Length / 4)
                {
                    Shrink();
                }
            }
			else
			{
				throw new InvalidOperationException("The item is not found in the List.");
			}
			return default;
		}

    }
}

