namespace WorkForce
{
    using System;

    public abstract class Employee
    {
        public Employee(string name, int workHours)
        {
            this.Name = name;
            this.WorkHoursPerWeek = workHours;
        }

        public string Name { get; private set; }

        public int WorkHoursPerWeek { get; private set; }
    }
}
