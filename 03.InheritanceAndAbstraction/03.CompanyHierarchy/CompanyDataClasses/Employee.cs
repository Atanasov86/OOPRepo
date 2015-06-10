namespace _03.CompanyHierarchy.CompanyDataClasses
{
    using System;

    using Interfaces;

    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;

        private Department department;

        protected Employee(string id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 0m)
                {
                    throw new Exception("Salary cannot be negative");
                }

                this.salary = value;
            }
        }

        public Department Department
        {
            get
            {
                return this.department;
            }

            set { }
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "Deparment: {0}\nSalary:{1}", this.Department, this.Salary);
        }

        
    }
}
