namespace Animals
{
    using System;

    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        private string Name
        {
            get => this.name;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }

        private int Age
        {
            get => this.age;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        private string Gender
        {
            get => this.gender;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        protected virtual string ProduceSound()
        {
            return null;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}{Environment.NewLine}{this.Name} {this.Age} {this.Gender}{Environment.NewLine}{this.ProduceSound()}";
        }
    }
}
