namespace CustomList
{
    using System;

    public class CustomList
    {
        private const int InitialCapacity = 2;

        private int[] array;
        private int count;

        public CustomList()
        {
            this.array = new int[InitialCapacity];
        }
        
        public int Count
        {
            get => this.count;
        }

        public int this[int index]
        {
            get
            {
                if (index >= this.count && index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.array[index];
            }

            set
            {
                if (index >= this.count && index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                this.array[index] = value;
            }
        }
        
        private void Resize()
        {
            int[] newArray = new int[this.array.Length * 2];

            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
        }

        private void Shrink()
        {
            int[] newArray = new int[this.array.Length / 2];

            for (int i = 0; i < this.count; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.count; i++)
            {
                this.array[i] = this.array[i + 1];
            }

            this.array[index + 1] = 0;
        }

        private void ShiftToRight(int index)
        {
            for (int i = this.count; i > index; i--)
            {
                this.array[i] = this.array[i - 1];
            }
        }

        public void Add(int element)
        {
            if (this.count == this.array.Length)
            {
                this.Resize();
            }

            this.array[count] = element;
            this.count++;
        }

        public int RemoveAt(int index)
        {
            if (index >= this.count)
            {
                throw new IndexOutOfRangeException();
            }

            int value = this.array[index];
            this.array[index] = 0;
            this.count--;
                
            this.Shift(index);

            if (this.count <= this.array.Length / 4)
            {
                this.Shrink();
            }

            return value;
        }

        public void Insert(int index, int element)
        {
            if (index > this.count)
            {
                throw new IndexOutOfRangeException();
            }

            if (this.count == this.array.Length)
            {
                this.Resize();
            }

            this.ShiftToRight(index);
            this.array[index] = element;

            this.count++;
        }

        public bool Contains(int element)
        {
            bool contained = false;

            for (int i = 0; i < this.count; i++)
            {
                if (this.array[i] == element)
                {
                    contained = true;
                    break;
                }
            }

            return contained;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex > this.count || secondIndex > this.count)
            {
                throw new IndexOutOfRangeException();
            }

            int first = this.array[firstIndex];

            this.array[firstIndex] = this.array[secondIndex];
            this.array[secondIndex] = first;
        }
    }
}
