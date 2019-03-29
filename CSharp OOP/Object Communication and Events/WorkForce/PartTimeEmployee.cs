namespace WorkForce
{
    using System;

    public class PartTimeEmployee : Employee
    {
        private const int PartTimeEmployeeWorkHours = 20;

        public PartTimeEmployee(string name) 
            : base(name, PartTimeEmployeeWorkHours)
        {
        }
    }
}
