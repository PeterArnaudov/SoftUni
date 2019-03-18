namespace DetailPrinter
{
    using System;
    using System.Collections.Generic;

    public class DetailsPrinter
    {
        private IList<Employee> employees;

        public DetailsPrinter(IList<Employee> employees)
        {
            this.employees = employees;
        }

        private void PrintEmployee()
        {
            foreach (Employee employee in this.employees)
            {
                Console.WriteLine(employee);
            }
        }

        private void PrintManager(Manager manager)
        {
            Console.WriteLine(manager.Name);
            Console.WriteLine(string.Join(Environment.NewLine, manager.Documents));
        }
    }
}
