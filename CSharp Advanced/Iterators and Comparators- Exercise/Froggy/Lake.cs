namespace Froggy
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Lake : IEnumerable<int>
    {
        private int[] rocks;

        public Lake(params int[] rocks)
        {
            this.rocks = rocks;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < rocks.Length; i++)
            {
                if (i % 2 == 0)
                {
                    yield return rocks[i];
                }
            }

            for (int i = rocks.Length - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return rocks[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
