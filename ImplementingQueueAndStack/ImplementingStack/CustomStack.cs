using System;
namespace ImplementingStack
{
	public class CustomStack<T>
	{
        private const int InitialCapacity = 4;
        private T[] items;

        public CustomStack()
        {
            items = new T[InitialCapacity];
        }

        public int Count { get; private set; }

        public void Push(T item)
        {
            if (items.Length == Count)
            {
                Resize();
            }
            items[Count] = item;

            Count++;
        }
        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T removeTitle = items[Count - 1];
            items[Count - 1] = default;
            Count--;
            //
            return removeTitle;
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return items[Count - 1];
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
        public void ForEach(Action<T> action)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                T currItem = items[i];

                action(currItem);
            }
        }
        
    }
}

