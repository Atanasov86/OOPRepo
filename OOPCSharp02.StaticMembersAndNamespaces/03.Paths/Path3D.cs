namespace _03.Paths
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices.ComTypes;
    using System.Text;

    using _01.Point3D;

    public class Path3D
    {
        private List<Point3D> path = new List<Point3D>();

        public Path3D(params Point3D[] list)
        {
            this.AddPoint(list);
        }

        public Path3D(List<Point3D> path)
        {
            this.Path = path;
        }

        public List<Point3D> Path { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder("Path:\n");
            for (int i = 0; i < this.Path.Count; i++)
            {
                result.AppendFormat("point{0}: x={1} y={2} z={3}\n", i + 1, this.Path[i].X, this.Path[i].Y, this.Path[i].Z);
            }

            return result.ToString();
        }

        public void AddPoint(params Point3D[] list)
        {
            foreach (Point3D point3D in list)
            {
                this.Path.Add(point3D);
            }
        }
    }
}
