namespace LinkedList
{
    using System;

    public class LinkedList
    {
        public class Node
        {
            private int value;
            private Node previous;
            private Node next;

            public Node(int value)
            {
                this.Value = value;
            }

            public int Value
            {
                get => this.value;

                private set => this.value = value;
            }

            public Node Previous
            {
                get => this.previous;

                set => this.previous = value;
            }

            public Node Next
            {
                get => this.next;

                set => this.next = value;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public Node Head
        {
            get => this.head;

            private set => this.head = value;
        }

        public Node Tail
        {
            get => this.tail;

            private set => this.tail = value;
        }

        public int Count
        {
            get => this.count;
        }

        public LinkedList()
        {
            this.count = 0;
        }

        public void AddFirst(int value)
        {
            Node node = new Node(value);

            if (this.count == 0)
            {
                this.head = node;
                this.tail = node;
            }
            else
            {
                node.Next = this.head;
                this.head.Previous = node;
                this.head = node;
            }

            this.count++;
        }

        public void AddLast(int value)
        {
            Node node = new Node(value);

            if (this.count == 0)
            {
                this.head = node;
                this.tail = node;
            }
            else
            {
                this.tail.Next = node;
                node.Previous = this.tail;
                this.tail = node;
            }

            count++;
        }

        public void RemoveFirst()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The LinkedList is exmpty.");
            }
            else if (this.count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                this.head = this.head.Next;
                this.head.Previous = null;
            }

            this.count--;
        }

        public void RemoveLast()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The LinkedList is exmpty.");
            }
            else if (this.count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                this.tail = this.tail.Previous;
                this.tail.Next = null;
            }

            this.count--;
        }

        public void ForEach(Action<int> action)
        {
            Node node = this.head;

            while (node != null)
            {
                action(node.Value);
                node = node.Next;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[this.count];
            Node node = this.head;

            for (int i = 0; i < this.count; i++)
            {
                array[i] = node.Value;

                node = node.Next;
            }

            return array;
        }
    }
}
