namespace _02.Animals
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, double age)
            : base(name, age)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bay-bay");
        }
    }
}
