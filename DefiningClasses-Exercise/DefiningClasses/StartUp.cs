namespace DefiningClasses
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            //Family family = new();

            //int count = int.Parse(Console.ReadLine());

            //for (int i = 0; i < count; i++)
            //{
            //    string[] personProp = Console.ReadLine()
            //        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    Person person = new Person(personProp[0], int.Parse(personProp[1]));

            //    family.AddMember(person);
            //}
            //List<Person> oldestPeople = new List<Person>();

            //oldestPeople = family.GetOldestMembers();

            //foreach (var item in oldestPeople)
            //{
            //    Console.WriteLine($"{item.Name} - {item.Age}");
            //}

            //----------------------------------------------------------
            //string startDate = Console.ReadLine();
            //string endDate = Console.ReadLine();

            //int differanceInDays = DateModifier.GetDifferenceInDays(startDate, endDate);

            //Console.WriteLine(differanceInDays);

            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carProps = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(carProps[0],
                    int.Parse(carProps[1]),
                    int.Parse(carProps[2]),
                    int.Parse(carProps[3]),
                    carProps[4],
                    double.Parse(carProps[5]), int.Parse(carProps[6]),
                    double.Parse(carProps[7]), int.Parse(carProps[8]),
                    double.Parse(carProps[9]), int.Parse(carProps[10]),
                    double.Parse(carProps[11]), int.Parse(carProps[12]));

                cars.Add(car);
            }
            string commands = Console.ReadLine();

            if (commands == "fragile")
            {
                cars = cars.Where(x => x.Cargo.Type == "fragile" &&
                x.Tires.Any(x => x.Pressure < 1)).ToList();
            }
            else
            {
                cars = cars.Where(x => x.Cargo.Type == "flammable" &&
                x.Engine.Power > 250).ToList();
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}