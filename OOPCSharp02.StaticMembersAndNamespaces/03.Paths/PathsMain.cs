namespace _03.Paths
{
    using System;
    using System.Collections.Generic;

    using _01.Point3D;

    public class PathsMain
    {
        public static void Main()
        {
            List<Point3D> pointList = new List<Point3D>() 
            {
                new Point3D(1, 3, 2),
                new Point3D(2.2, 4.5, 5.5),
                new Point3D(6, 3.4, 2.2)
            };
            Path3D paths = new Path3D(pointList);
            Storage.SavePathInFile("../../path.txt", paths.ToString());
            //Storage.LoadPathFromFile("../../path.txt");
        }
    }
}
