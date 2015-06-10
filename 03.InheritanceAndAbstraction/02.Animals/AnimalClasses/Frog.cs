namespace _02.Animals
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, double age)
            : base(name, age)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Quak-quak");
        }
    }
}
