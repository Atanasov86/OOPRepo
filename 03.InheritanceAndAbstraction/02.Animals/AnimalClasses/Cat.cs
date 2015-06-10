namespace _02.Animals
{
    using System;

    public abstract class Cat : Animal
    {
        private string gender;

        public Cat(string name, double age, string gender)
            : base(name, age)
        {
            this.Gender = gender;
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Gender cannot be empty or null.");
                }

                this.gender = value;
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miayyy");
        }
    }
}
