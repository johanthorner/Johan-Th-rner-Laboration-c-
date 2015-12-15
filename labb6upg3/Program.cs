using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb6upg3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Utgå från klasserna Point och Point3D från förra övningen.
            Skapa en egendefinierad typkonvertering i Point som omvandlar en
            Point till en Point3D, och gör denna implicit. 
            Testa genom att skapa en instans av Point (i Main, som vanligt)
            och typomvandla denna till en Point3D. Följ förloppet i debuggern.*/

           
            Point3D point3D = new Point3D(1,1,1);
            Point point = new Point(2, 2);

            point = (Point)point3D;
            Console.WriteLine(point);

            point3D = (Point3D)point;           //Omvandlar en Point3D till en point explicit


           
        }
    }
}
