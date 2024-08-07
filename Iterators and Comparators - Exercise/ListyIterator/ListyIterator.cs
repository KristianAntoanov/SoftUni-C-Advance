using System;
using System.Collections;

namespace ListyIteratorType
{
	public class ListyIterator<T> : IEnumerable<T>
	{
		private List<T> items;
        private int index; 

        public ListyIterator(List<T> items)
        {
            this.items = items;
        }

        public bool Move()
        {
            if (index < items.Count - 1)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext() => index < items.Count - 1;
        public void Print()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(items[index]);
        }
        public void PrintAll()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            foreach (var item in items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                yield return items[i];
            }  
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

