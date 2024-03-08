namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Diagnostics;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> storeInfo = new Dictionary<string, Dictionary<string, double>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] cmdArgs = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string storeName = cmdArgs[0];
                string productName = cmdArgs[1];
                double price = double.Parse(cmdArgs[2]);

                if (!storeInfo.ContainsKey(storeName))
                {
                    storeInfo[storeName] = new Dictionary<string, double>();
                    
                }
                storeInfo[storeName][productName] = price;

            }

            foreach (var store in storeInfo.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{store.Key}->");
                foreach (var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
