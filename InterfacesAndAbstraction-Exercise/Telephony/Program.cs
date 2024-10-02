namespace Telephony
{
    using System;
    using Telephony.Core;
    using Telephony.Core.Interfaces;
    using Telephony.IO;
    using Telephony.IO.Interfaces;
    using Telephony.Models.Interfaces;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IReader reader = new FileReader();
            IWriter writer = new FileWriter();

            IEngine engine = new Engine(reader, writer);

            engine.Run();
        }
    }
}