using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upg_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle newCircle1 = new Circle();
            newCircle1.SetDiameter(12);

            Circle newCircle2 = new Circle();
            newCircle2.SetDiameter(1);

            Circle newCircle3 = new Circle();
            newCircle3.SetDiameter(5);
            
            Console.WriteLine($"cirkel 1: {newCircle1.GetCircumference()} cirkel 2: {newCircle2.GetCircumference()} cirkel 3: {newCircle3.GetCircumference()}");
        }
    }
}
