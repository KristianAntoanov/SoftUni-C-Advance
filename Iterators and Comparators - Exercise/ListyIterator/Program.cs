namespace ListyIteratorType
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();
            ListyIterator<string> listyIterator = new(items);

            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "END")
            {
                if (commands == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (commands == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if (commands == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (commands == "PrintAll")
                {
                    try
                    {
                        listyIterator.PrintAll();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}