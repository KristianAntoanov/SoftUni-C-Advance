namespace MilitaryElite
{
    using System;
    using _07.MilitaryElite.Models;
    using _07.MilitaryElite.Models.Interfaces;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run(); 
        }
    }
}