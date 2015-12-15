using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace labb6upg3
{
    class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x, int y)
        {
            X = x;
            Y = y;
            Z = 0;
        }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public static explicit operator Point(Point3D point)
        {
            return new Point(point.X, point.Y);
        }
        public override string ToString()
        {
            return $"X:{X}Y:{Y}Z:{Z}";
        }
    }
}
