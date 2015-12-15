using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace labb6upg3
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }


        public Point(int x, int y)
        {
            X = x;
            Y = y;
            
        }

        public static implicit operator Point3D(Point point)
        {
            return new Point3D(point.X, point.Y);
        }
        public override string ToString()
        {
            return $"X:{X}, Y:{Y}";
        }
    }
}
