namespace ShoppingSpree
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            try
            {
                string[] inputPersons = Console.ReadLine()
                    .Split(';');
                foreach (var item in inputPersons)
                {
                    string[] nameAndMoney = item.Split("=").ToArray();

                    Person person = new Person(nameAndMoney[0], int.Parse(nameAndMoney[1]));
                    persons.Add(person);
                }
                List<Product> products = new List<Product>();

                string[] inputProducts = Console.ReadLine()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in inputProducts)
                {
                    string[] nameAndCost = item.Split("=").ToArray();

                    Product product = new Product(nameAndCost[0], int.Parse(nameAndCost[1]));
                    products.Add(product);
                }

                string commands = string.Empty;
                while ((commands = Console.ReadLine()) != "END")
                {
                    string[] cmdArgs = commands
                        .Split(" ");
                    string nameOfPerson = cmdArgs[0];
                    string nameOfProduct = cmdArgs[1];
                    foreach (var item in products)
                    {
                        if (item.Name == nameOfProduct)
                        {
                            foreach (var person in persons)
                            {
                                if (person.Name == nameOfPerson)
                                {
                                    person.AddProduct(item);
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            if (persons.Any())
            {
                foreach (var item in persons)
                {
                    if (item.Bag.Any())
                    {
                        Console.WriteLine($"{item.Name} - {String.Join(", ", item.Bag.Select(x => x.Name))}");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Name} - Nothing bought ");
                    }
                }
            }
        }
    }
}