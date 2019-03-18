namespace PetClinic
{
    using System;

    public class Pet
    {
        private string name;
        private int age;
        private string kind;

        public Pet(string name, int age, string kind)
        {
            this.name = name;
            this.age = age;
            this.kind = kind;
        }

        public string Name => this.name;

        public override string ToString()
        {
            return $"{this.name} {this.age} {this.kind}";
        }
    }
}
