namespace DetailPrinter
{
    public class Employee
    {
        private string name;

        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;

            private set => this.name = value;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}";
        }
    }
}
