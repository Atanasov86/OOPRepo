namespace _03.CompanyHierarchy.Interfaces
{
    using _03.CompanyHierarchy.CompanyDataClasses;

    public interface IEmployee
    {
        decimal Salary { get; set; }

        Department Department { get; set; }

        string ToString();
    }
}
