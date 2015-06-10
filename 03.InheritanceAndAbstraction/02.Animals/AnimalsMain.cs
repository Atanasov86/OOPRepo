namespace _02.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnimalsMain
    {
        public static void Main()
        {
            List<Animal> myAnimals = new List<Animal>()
                                         {
                                             new Tomcat("cat1", 2),
                                             new Kitten("cat2", 2.1),
                                             new Kitten("cat3", 3),
                                             new Frog("frog1", 2),
                                             new Dog("dog1", 4.1),
                                             new Dog("dog2", 3.3),
                                             new Frog("frog2", 3.4)
                                         };
            foreach (var group in myAnimals.GroupBy(animal => animal.GetType().Name))
            {
                double averageAge = group.Average(x => x.Age);
                Console.WriteLine("Group[{0}] Average age: {1}", group.Key, averageAge);
            }

            myAnimals[1].ProduceSound();
            myAnimals[3].ProduceSound();
            myAnimals[5].ProduceSound();
        }
    }
}
