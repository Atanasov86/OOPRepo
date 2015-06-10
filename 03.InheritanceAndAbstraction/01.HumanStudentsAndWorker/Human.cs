namespace _01.HumanStudentsAndWorker
{
    using System;

    public abstract class Human
    {
        private string firstName;

        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
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
                    throw new FormatException("Name cannot be null or empty");
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
                    throw new FormatException("Last name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, ", this.FirstName, this.LastName);
        }
    }
}
