namespace _01.Point3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Point3DMain
    {
        public static void Main()
        {
            Point3D myPoint3D = new Point3D(2.5, 3.4, 5.5);
            Console.WriteLine(myPoint3D);
            Console.WriteLine(Point3D.StartingPoint3D);
        }
    }
}
