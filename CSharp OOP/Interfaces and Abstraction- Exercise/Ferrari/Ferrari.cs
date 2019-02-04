namespace Ferrari
{
    using System;

    public class Ferrari : IFerrari
    {
        private string model;
        private string driver;

        public Ferrari(string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }

        public string Model
        {
            get => this.model;

            private set => this.model = value;
        }

        public string Driver
        {
            get => this.driver;

            private set => this.driver = value;
        }

        public string UseBreaks()
        {
            return "Brakes!";
        }

        public string PushGas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.UseBreaks()}/{this.PushGas()}/{this.Driver}";
        }
    }
}
