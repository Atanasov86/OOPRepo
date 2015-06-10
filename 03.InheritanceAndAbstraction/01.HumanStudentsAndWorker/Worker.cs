namespace _01.HumanStudentsAndWorker
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;

        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentException("Working hours must be in range [0-24]...");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Salary cannot be negative or zero.");
                }

                this.weekSalary = value;
            }
        }

        public decimal MoneyPerHours()
        {
            decimal moneyPerHour = this.WeekSalary / ((decimal)this.WorkHoursPerDay * 5);
            return moneyPerHour;
        }

        public override string ToString()
        {
            return base.ToString()
                   + string.Format("Week salary: {0}, Working hours: {1}", this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
