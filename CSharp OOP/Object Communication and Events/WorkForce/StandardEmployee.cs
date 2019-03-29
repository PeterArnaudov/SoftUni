namespace WorkForce
{
    using System;

    public class StandardEmployee : Employee
    {
        private const int StandardEmployeeWorkHours = 40;

        public StandardEmployee(string name) 
            : base(name, StandardEmployeeWorkHours)
        {
        }
    }
}
