using System;
using _04.BorderControl.Models.Iterfaces;

namespace _04.BorderControl.Models
{
    public class Robot : IPrintable
    {
        public Robot(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; private set; }

        public string Id { get; private set; }
    }
}

