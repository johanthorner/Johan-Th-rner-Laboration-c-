using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace labb6upg4
{
    class MyDoubleType
    {
        
        private double doubleValue;

        public double DoubleValue
        {
            get { return doubleValue; }
            set { doubleValue = value; }
        }

        public MyDoubleType(double doubleValue)
        {
            DoubleValue = doubleValue;
        }

        public static MyDoubleType operator +(MyDoubleType myDoubleType, double tal)
        {
            myDoubleType.DoubleValue += tal;
            return myDoubleType;
        }

        public static MyDoubleType operator +(MyDoubleType myDoubleType1, MyDoubleType myDoubleType2)
        {
            myDoubleType1.DoubleValue = myDoubleType1.doubleValue + myDoubleType2.doubleValue;
            return myDoubleType1;
        }

        public static MyDoubleType operator -(MyDoubleType myDoubleType, double tal)
        {
           
            myDoubleType.DoubleValue -= tal;
            return myDoubleType;

        }

        public static MyDoubleType operator -(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            myDoubleType.doubleValue -= myDoubleType.doubleValue;
            return myDoubleType;
        }

        public static MyDoubleType operator /(MyDoubleType myDoubleType, double tal)
        {
            myDoubleType.DoubleValue /= tal;
            return myDoubleType;
        }

        public static MyDoubleType operator /(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            myDoubleType.DoubleValue /= myDoubleType2.doubleValue;
            return myDoubleType;
        }

        public static MyDoubleType operator *(MyDoubleType myDoubleType, double tal)
        {
            myDoubleType.doubleValue *= tal;
            return myDoubleType;
        }

        public static MyDoubleType operator *(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            myDoubleType.DoubleValue *= myDoubleType2.DoubleValue;
            return myDoubleType;
        }

      

        public static bool operator ==(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            
            return myDoubleType.DoubleValue == myDoubleType2.doubleValue;
           
        } 
        public static bool operator !=(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            return myDoubleType.doubleValue != myDoubleType2.doubleValue;
        }

        public static bool operator <(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            return myDoubleType.doubleValue < myDoubleType2.doubleValue;
        }
        public static bool operator >(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            return myDoubleType.doubleValue > myDoubleType2.doubleValue;
        }

        public static bool operator <=(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            return myDoubleType.doubleValue <= myDoubleType2.doubleValue;
        }
        public static bool operator >=(MyDoubleType myDoubleType, MyDoubleType myDoubleType2)
        {
            return myDoubleType.doubleValue >= myDoubleType2.doubleValue;
        }
        public override string ToString()
        {
            return $"{DoubleValue}";
        }
    }
}
