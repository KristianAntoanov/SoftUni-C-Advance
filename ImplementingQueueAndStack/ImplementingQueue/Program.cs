namespace ImplementingQueue
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            CustomQueue<double> doubleQueue = new CustomQueue<double>();

            doubleQueue.Enqueue(2);
            doubleQueue.Enqueue(3.5);
            doubleQueue.Enqueue(13);
            doubleQueue.Enqueue(5.7);
            doubleQueue.Enqueue(7.1);

            doubleQueue.Dequeue();

            doubleQueue.Clear();
        }
    }
}