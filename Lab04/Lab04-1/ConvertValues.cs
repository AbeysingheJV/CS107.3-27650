using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_1
{
    class ConvertValues
    {
        public void KilometerToMeter()
        {
            Console.WriteLine("Enter the distance in kilometers:");
            double km = double.Parse(Console.ReadLine());

            double meters = km * 1000;
            Console.WriteLine($"The distance in meters is:" + meters);
        }
    }
}
