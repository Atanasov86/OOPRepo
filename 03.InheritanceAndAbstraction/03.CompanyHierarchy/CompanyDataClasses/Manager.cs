namespace _03.CompanyHierarchy.CompanyDataClasses
{
    using System.Collections.Generic;

    using _03.CompanyHierarchy.Interfaces;

    public class Manager : Employee, IManager
    {
        public Manager(string id, string firstName, string lastName, decimal salary, Department department, List<Employee> employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees; //new List<Employee>();
        }

        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            
        }
    }
}
