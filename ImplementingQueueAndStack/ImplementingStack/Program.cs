namespace ImplementStack
{
    using System;
    using ImplementingStack;

    public class Program
    {
        public static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();

            //stack.Peek();
            stack.Pop();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine(stack.Pop());
        }
    }
}