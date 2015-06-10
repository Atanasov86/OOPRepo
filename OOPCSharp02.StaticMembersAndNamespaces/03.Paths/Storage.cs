namespace _03.Paths
{
    using System.IO;
    using System.Text.RegularExpressions;

    using _01.Point3D;

    public static class Storage
    {
        public const string pattern = @"(?<=[xyz]\s|=|:|-)([\d+\.|,]+)";

        public static void SavePathInFile(string pathFile, string path)
        {
            using (StreamWriter writer = new StreamWriter(pathFile))
            {
                writer.WriteLine(path);
            }
        }

        public static Path3D LoadPathFromFile(string pathFile)
        {
            Path3D myPath = new Path3D();
            using (StreamReader reader = new StreamReader(pathFile))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    MatchCollection matches = Regex.Matches(line, pattern);
                    if (matches.Count == 3)
                    {
                        double x = double.Parse(matches[0].ToString());
                        double y = double.Parse(matches[1].ToString());
                        double z = double.Parse(matches[2].ToString());
                        Point3D currentPoint3D = new Point3D(x, y, z);
                        myPath.AddPoint(currentPoint3D);
                    }
                    
                    line = reader.ReadLine();
                }

            }
            return myPath;
        }
    }
}
