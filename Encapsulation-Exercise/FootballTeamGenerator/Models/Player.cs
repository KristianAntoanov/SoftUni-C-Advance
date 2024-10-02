using System;
namespace FootballTeamGenerator.Models
{
	public class Player
	{
		private const string NameEmptyExeptionsMessage = "A name should not be empty.";

        private const int statMinValue = 0;
		private const int statMaxValue = 100;
		private string name;
		private int endurance;
		private int sprint;
		private int dribble;
		private int passing;
		private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name
		{
			get => name;
			private set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException(NameEmptyExeptionsMessage);
				}
				name = value;
			}
		}
        public int Endurance
        {
            get => endurance;
            private set
            {
				ThrowExeptionsIfInvalid(value, nameof(Endurance));
                endurance = value;
            }
        }
        public int Sprint
        {
            get => sprint;
            private set
            {
                ThrowExeptionsIfInvalid(value, nameof(Sprint));
                sprint = value;
            }
        }
        public int Dribble
        {
            get => dribble;
            private set
            {
                ThrowExeptionsIfInvalid(value, nameof(Dribble));
                dribble = value;
            }
        }
        public int Passing
        {
            get => passing;
            private set
            {
                ThrowExeptionsIfInvalid(value, nameof(Passing));
                passing = value;
            }
        }
        public int Shooting
        {
            get => shooting;
            private set
            {
                ThrowExeptionsIfInvalid(value, nameof(Shooting));
                shooting = value;
            }
        }

        public double Stats => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;

        private void ThrowExeptionsIfInvalid(int value, string name)
		{
			if (value < statMinValue || value > statMaxValue)
			{
                throw new ArgumentException($"{name} should be between 0 and 100.");
            }
		}
    }
}

