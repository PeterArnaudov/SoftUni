namespace CarSalesman
{
    using System;

    public class Engine
    {
        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public override string ToString()
        {
            string output = $"  {Model}:";

            output = string.Concat(output, Environment.NewLine);
            output = string.Concat(output, $"    Power: {Power}");
            output = string.Concat(output, Environment.NewLine);
            output = string.Concat(output, Displacement == 0 ? "Displacement: n/a" : $"    Displacement: {Displacement}");
            output = string.Concat(output, Environment.NewLine);
            output = string.Concat(output, string.IsNullOrEmpty(Efficiency) ? "Efficiency: n/a" : $"    Efficiency: {Efficiency}");

            return output;
        }
    }
}
