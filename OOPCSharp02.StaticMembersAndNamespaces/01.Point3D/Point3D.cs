namespace _01.Point3D
{
    using System;
    using System.Runtime.CompilerServices;

    public class Point3D
    {
        private static readonly Point3D StartingPoint = new Point3D(0, 0, 0);

        private double x;

        private double y;

        private double z;

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Point3D()
        {
            
        }

        public static Point3D StartingPoint3D
        {
            get { return StartingPoint; }
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override string ToString()
        {
            return string.Format("Point(X: {0}, Y: {1}, Z: {2})", this.X, this.Y, this.Z);
        }
    }
}
