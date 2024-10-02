namespace CustomStack
{
    using System;
    using _03.CustomStack;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            StackOfStrings strings = new StackOfStrings();

            string[] strings1 = { "1", "2", "3", "4", "5" };

            strings.AddRange(strings1);
        }
    }
}