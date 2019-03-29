namespace DetailPrinter
{
    using System;
    using System.Collections.Generic;

    public class Manager : Employee
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}{string.Join(Environment.NewLine, this.Documents)}";
        }
    }
}
