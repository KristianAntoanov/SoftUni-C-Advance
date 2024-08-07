namespace ImplementingList
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            list[0] = "135";
            list.RemoveAt(2);
            list.Remove("2");
            Console.WriteLine(list.Contains("1"));
            Console.WriteLine(String.Join(" ", list));

        }
    }
}