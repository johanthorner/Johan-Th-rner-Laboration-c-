using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upg_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point myPoint = new Point();
            myPoint.SetX(2);
            myPoint.SetY(6);
            
         
            Console.WriteLine($"X:{myPoint.GetX()},Y:{myPoint.GetY()}");
        }
    }
}
