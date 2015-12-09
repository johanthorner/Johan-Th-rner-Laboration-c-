using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upg_2;
using upg_3;

namespace upg_4
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Point myPoint = new Point();
            myPoint.SetX(5);
            myPoint.SetY(5);

            Circle newCircle = new Circle();
            newCircle.SetDiameter(23);

            newCircle.SetCenter(myPoint);

                    
            Console.WriteLine($"{newCircle.GetCenter()}");
            Console.WriteLine($"{newCircle.PrintCenterPoint()}");

            Console.WriteLine(newCircle.GetCenter().GetX());
         }
    }
}
