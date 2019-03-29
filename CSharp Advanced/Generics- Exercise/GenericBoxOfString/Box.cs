namespace GenericBoxOfString
{
    using System;
    using System.Collections.Generic;

    public class Box<T>
    {
        private T element;

        public Box(T element)
        {
            this.element = element;
        }

        public T Element => this.element;

        public override string ToString()
        {
            return $"{typeof(T)}: {this.Element}";
        }
    }
}
