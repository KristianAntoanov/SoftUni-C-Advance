using Animals;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string animalType = string.Empty;
            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    if (animalType == "Dog")
                    {
                        Dog dog = new Dog(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
                        Console.WriteLine(animalType);
                        Console.WriteLine(dog.ToString());
                    }
                    else if (animalType == "Frog")
                    {
                        Frog frog = new Frog(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
                        Console.WriteLine(animalType);
                        Console.WriteLine(frog.ToString());
                    }
                    else if (animalType == "Cat")
                    {
                        Cat cat = new Cat(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
                        Console.WriteLine(animalType);
                        Console.WriteLine(cat.ToString());
                    }
                    else if (animalType == "Tomcat")
                    {
                        Tomcat tomCat = new Tomcat(cmdArgs[0], int.Parse(cmdArgs[1]));
                        Console.WriteLine(animalType);
                        Console.WriteLine(tomCat.ToString());
                    }
                    else if (animalType == "Kitten")
                    {
                        Kitten kitten = new Kitten(cmdArgs[0], int.Parse(cmdArgs[1]));
                        Console.WriteLine(animalType);
                        Console.WriteLine(kitten.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
