namespace StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class PersonNameComparer : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            int result = first.Name.Length.CompareTo(second.Name.Length);

            if (result == 0)
            {
                result = first.Name.ToLower().CompareTo(second.Name.ToLower());
            }

            return result;
        }
    }
}
