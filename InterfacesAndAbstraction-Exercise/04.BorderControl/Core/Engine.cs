namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using _04.BorderControl.Models;
    using _04.BorderControl.Models.Iterfaces;

    public class Engine : IEngine
    {
        private Dictionary<string, IPrintable> everyone;

        public Engine()
        {
            everyone = new Dictionary<string, IPrintable>();
        }

        public void Run()
        {
            string input = string.Empty;
            IPrintable printable;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (cmdInfo.Length > 2)
                {
                    printable = new Citizen(cmdInfo[0], int.Parse(cmdInfo[1]), cmdInfo[2]);
                    everyone.Add(cmdInfo[2], printable);
                }
                else
                {
                    printable = new Robot(cmdInfo[0], cmdInfo[1]);
                    everyone.Add(cmdInfo[1], printable);
                }
            }
            string fakeId = Console.ReadLine();

            foreach (var item in everyone.Where(x => x.Key.TakeLast(fakeId.ToString().Length).SequenceEqual(fakeId.ToString())))
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}