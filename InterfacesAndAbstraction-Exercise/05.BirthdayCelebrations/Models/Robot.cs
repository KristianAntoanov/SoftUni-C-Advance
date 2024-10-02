using System;
using BirthdayCelebrations.Models.Iterfaces;

namespace BirthdayCelebrations.Models
{
    public class Robot : IIdentifiable
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

