namespace CustomStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StackOfStrings
    {
        private List<string> list;

        public StackOfStrings()
        {
            this.list = new List<string>();
        }

        public void Push(string item)
        {
            this.list.Add(item);
        }

        public string Pop()
        {
            string removed = list.Last();
            list.Remove(removed);
            return removed;
        }

        public string Peek()
        {
            return list.Last();
        }

        public bool IsEmpty()
        {
            return list.Any();
        }
    }
}
