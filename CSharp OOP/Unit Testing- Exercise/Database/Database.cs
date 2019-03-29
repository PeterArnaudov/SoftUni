namespace Database
{
    using System;
    using System.Linq;

    public class Database
    {
        private const int Capacity = 16;

        private int[] integers;
        private int count;

        public Database(params int[] initial)
        {
            this.integers = new int[Capacity];

            if (initial.Length > Capacity)
            {
                throw new InvalidOperationException("Cannot initialize a Database class with more than 16 elements.");
            }

            foreach (var element in initial)
            {
                this.Add(element);
            }
        }

        public void Add(int element)
        {
            if (this.count == Capacity)
            {
                throw new InvalidOperationException("Cannot add more elements.");
            }

            this.integers[count] = element;
            this.count++;
        }

        public void Remove()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Cannot remove elements from an empty Database.");
            }

            this.integers[count] = 0;
            this.count--;
        }

        public int[] Fetch()
        {
            return this.integers;
        }
    }
}
