namespace CustomDoublyLinkedList
{
    using System;
    using System.Diagnostics;
    using System.Threading.Channels;

    public class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> myLinkedList = new DoublyLinkedList<int>();

            myLinkedList.AddLast(1);
            myLinkedList.RemoveFirst();
            myLinkedList.AddLast(2);
            myLinkedList.AddLast(3);
            myLinkedList.AddLast(4);
            myLinkedList.AddLast(5);

            myLinkedList.RemoveLast();

            //myLinkedList.Reversed();
            int listSum = 0;
            myLinkedList.ForEach(x =>
            {
                listSum += x;
                Console.Write($"{x} ");
            });
            Console.WriteLine();
            Console.WriteLine(listSum);

            int[] array = myLinkedList.ToArray();
            Console.WriteLine(String.Join(" ", array));


            //---------------Performance---------------

            //Stopwatch newStopwatch = new Stopwatch();
            //newStopwatch.Start();
            //LinkedList<int> List = new LinkedList<int>();
            //int n = 50000000;
            //for (int i = 0; i < n; i++)
            //{
            //    List.AddFirst(i);
            //}
            //newStopwatch.Stop();
            //Console.WriteLine(newStopwatch.ElapsedMilliseconds);

            //---------------Performance---------------


            DoublyLinkedList<string> stringLinkedList = new DoublyLinkedList<string>();

            stringLinkedList.AddLast("1");
            stringLinkedList.AddLast("2");
            stringLinkedList.AddLast("3");

            //stringLinkedList.Reversed();
            stringLinkedList.RemoveFirst();

            stringLinkedList.ForEach(x =>
            {
                Console.Write($"{x} ");
            });
        }
    }
}