using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upg_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person johan = new Person();
            Person franz = new Person();
            Person björn = new Person();
            johan.SetName("Johan Thörner");
            franz.SetName("Franz Kafka");
            björn.SetName("Björn Skifs");

            Console.WriteLine($"{ johan.GetName()}, { franz.GetName()}, { björn.GetName()}.");

             
        }
    }
}
