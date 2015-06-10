namespace _03.CompanyHierarchy.CompanyDataClasses
{
    using System;
    using _03.CompanyHierarchy.Interfaces;

    public abstract class Person : IPerson
    {
        private string id;

        private string firstName;

        private string lastName;
        
        
        //protected Person(string id, string firstName, string lastName)
        //{
        //    this.Id = id;
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //}

        public Person(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        
        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ID cannot be empty or null.");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty or null.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty or null.");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("ID: {0}\nFull name: {1} {2}", this.Id, this.FirstName, this.LastName);
        }
    }
}
