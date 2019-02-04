namespace Mankind
{
    using System;

    public class Worker : Human
    {
        private double salary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double salary, double workHoursPerDay)
            :base (firstName, lastName)
        {
            this.Salary = salary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        private double Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.salary = value;
            }
        }

        private double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }

        private double GetHourlySalary()
        {
            return salary / (workHoursPerDay * 5);
        }

        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}Week Salary: {this.Salary:f2}{Environment.NewLine}Hours per day: {this.WorkHoursPerDay:f2}{Environment.NewLine}Salary per hour: {this.GetHourlySalary():f2}";
        }
    }
}
