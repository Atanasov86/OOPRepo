namespace _03.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;

    using _03.CompanyHierarchy.CompanyDataClasses;

    public interface IManager
    {
        List<Employee> Employees { get; set; }

        string ToString();
    }
}
