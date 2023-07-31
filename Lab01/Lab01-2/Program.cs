using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius: ");
            float radius = float.Parse(Console.ReadLine());

            float area = (22 / 7) * (radius * radius);

            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
