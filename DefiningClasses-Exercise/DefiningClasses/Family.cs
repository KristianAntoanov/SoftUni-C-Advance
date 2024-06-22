using System;
namespace DefiningClasses
{
	public class Family
	{
		List<Person> people;

		public Family()
		{
			people = new List<Person>();
		}

		public List<Person> People
		{
			get
			{
				return this.people;
			}
			set
			{
				this.people = value;
			}
		}

		public void AddMember(Person member)
		{
			this.People.Add(member);
		}
		public Person GetOldestMember()
		{
			return this.People.MaxBy(x => x.Age);
		}
        public List<Person> GetOldestMembers()
        {
			return this.People.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
        }

    }
}

