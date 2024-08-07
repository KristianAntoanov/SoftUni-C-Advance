using System;
namespace ImplementingQueue
{
	public class CustomQueue<T>
	{
        private const int InitialCapacity = 4;
        private const int FirstElementIndex = 0;

        private T[] items;

        public CustomQueue()
		{
            items = new T[InitialCapacity];
        }

        public int Count { get; private set; }

        public void Enqueue(T item)
        {
            if (items.Length == Count)
            {
                Resize();
            }
            items[Count] = item;

            Count++;
        }
        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T removeTitle = items[FirstElementIndex];
            items[FirstElementIndex] = default;
            ShiftLeft();
            Count--;
            items[Count] = default;
            //if needed Shrink
            return removeTitle;
        }
        private void ShiftLeft()
        {
            for (int i = FirstElementIndex; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }

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
        public void Clear()
        {
            items = new T[InitialCapacity];
            Count = 0;
        }
        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < Count; i++)
            {
                T currItem = items[i];

                action(currItem);
            }
        }

    }
}


