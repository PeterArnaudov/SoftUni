namespace CustomRandomList
{
    using System;
    using System.Collections.Generic;

    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, this.Count);

            string removed = this[randomIndex];
            this.RemoveAt(randomIndex);

            return this[randomIndex];
        }
    }
}
