namespace BoxOfT
{
    using System;
    using System.Collections.Generic;

    public class Box<T>
    {
        private List<T> elements = new List<T>();

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove()
        {
            T element = this.elements[this.elements.Count - 1];
            this.elements.RemoveAt(this.elements.Count - 1);

            return element;
        }

        public int Count => this.elements.Count;
    }
}
