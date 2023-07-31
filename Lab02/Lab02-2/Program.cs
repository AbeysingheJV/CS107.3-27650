using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number :");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum : " + (num1 + num2));
            Console.WriteLine("Subtraction : " + (num1 - num2));
            Console.WriteLine("Multiplication : " + (num1 * num2));
            Console.WriteLine("Division : " + (num1 / num2));

            Console.ReadLine();
        }
    }
}
