namespace WorkForce
{
    using System;

    public delegate void JobCompletedHandler(Job job);

    public class Job
    {
        public event JobCompletedHandler JobCompleted;

        private Employee employee;
        private string name;
        private int hoursOfWorkRequired;

        public Job(Employee employee, int hoursRequired, string name)
        {
            this.employee = employee;
            this.name = name;
            this.hoursOfWorkRequired = hoursRequired;
        }

        public void Update()
        {
            this.hoursOfWorkRequired -= this.employee.WorkHoursPerWeek;

            if (this.hoursOfWorkRequired <= 0)
            {
                Console.WriteLine($"Job {this.name} done!");
                this.JobCompleted.Invoke(this);
            }
        }

        public override string ToString()
        {
            return $"Job: {this.name} Hours Remaining: {this.hoursOfWorkRequired}";
        }
    }
}
