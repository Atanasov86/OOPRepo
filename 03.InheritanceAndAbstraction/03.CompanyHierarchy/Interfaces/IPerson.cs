﻿namespace _03.CompanyHierarchy.Interfaces
{
    public interface IPerson
    {
        string Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string ToString();
    }
}
