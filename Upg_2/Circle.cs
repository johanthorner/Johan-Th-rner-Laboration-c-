using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upg_3;
namespace Upg_2
{
    public class Circle
    {
        private double diameter;
        Point point;
         
        public void SetCenter(Point pointer)
        {
            this.point = pointer;
        }
        public Point GetCenter()
        {
            return point;   
        }
        public String PrintCenterPoint()
        {
            return $"X: {point.GetX()} Y: {point.GetY()}";
        }
        public void SetDiameter(double diameter)
        {
            this.diameter = diameter;
        }
        public double GetDiamter()
        {
            return diameter;
        }
        public double GetCircumference()
        {
            return diameter * 3.1416;
        }

    }
}
