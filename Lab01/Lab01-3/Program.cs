using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number :");
            int num2 = int.Parse(Console.ReadLine());

            int result;

            result = num1 + num2;

            Console.WriteLine("Sum :" + result);

            Console.ReadLine();
        }
    }
}
