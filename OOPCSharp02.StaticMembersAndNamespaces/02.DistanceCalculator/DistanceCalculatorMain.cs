namespace _02.DistanceCalculator
{
    using System;

    using _01.Point3D;

    public class DistanceCalculatorMain
    {
        public static void Main()
        {
            Point3D firstPoint3D = new Point3D(3, 2.2, 4.5);
            Point3D secondPoint3D = new Point3D(1.1, 4.5, 3.4);
            Console.Write("Distance between these points is: ");
            double distance = DistanceCalculator.CalculateDistance(firstPoint3D, secondPoint3D);
            Console.WriteLine(distance);
        }
    }
}
