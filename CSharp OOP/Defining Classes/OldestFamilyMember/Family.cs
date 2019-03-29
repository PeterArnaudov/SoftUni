namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        public List<Person> Members { get; set; }

        public Family(List<Person> members)
        {
            Members = members;
        }

        public void AddMember(Person member)
        {
            Members.Add(member);
        }

        public Person GetOldestMember()
        {
            return Members.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}
