using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Point3d
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public Point3d(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public double GetDistanceFromOrigin()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
    }
    public class Program
    {
        public void Main(string[] args)
        {
            Point3d point = new Point3d(1.5, 5.75, -7.0);
            double distance = point.GetDistanceFromOrigin();
            Console.WriteLine(distance);
        }

    }
}