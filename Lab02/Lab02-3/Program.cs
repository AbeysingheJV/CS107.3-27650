using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius :");
            double radius = double.Parse(Console.ReadLine());

            double circumference;
            double area;

            circumference = 2 * Math.PI * radius;
            area = Math.PI * radius * radius;

            Console.WriteLine("The Area :" + area);
            Console.WriteLine("The circumference : " + circumference);

            Console.ReadLine();
        }
    }
}
