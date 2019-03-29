namespace CarSalesman
{
    using System;

    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public override string ToString()
        {
            string output = $"{Model}:";
            output = string.Concat(output, Environment.NewLine);
            output = string.Concat(output, Engine.ToString());
            output = string.Concat(output, Environment.NewLine);
            output = string.Concat(output, Weight == 0 ? "  Weight: n/a" : $"  Weight: {Weight}");
            output = string.Concat(output, Environment.NewLine);
            output = string.Concat(output, string.IsNullOrEmpty(Color) ? "  Color: n/a" : $"  Color: {Color}");

            return output;
        }
    }
}
