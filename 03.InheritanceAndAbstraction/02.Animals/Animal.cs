namespace _02.Animals
{
    using System;

    using _02.Animals.Interfaces;

    public abstract class Animal : ISoundProducible
    {
        private string name;

        private double age;

        protected Animal(string name, double age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty or null");
                }

                this.name = value;
            }
        }

        public double Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be negative or zero.");
                }

                this.age = value;
            }
        }

        public abstract void ProduceSound();
    }
}
