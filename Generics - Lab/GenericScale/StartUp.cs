namespace BoxOfT
{
    using System;
    using GenericScale;

    internal class StartUp
    {
        public static void Main(string[] args)
        {
            EqualityScale<int> scale = new EqualityScale<int>(1, 1);

            Console.WriteLine(scale.AreEqual());
        }
    }
}