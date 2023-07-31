using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter a Number:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i += 2)
            {
                sum += i;
            }
            Console.Write("Sum of Odd numbers from 1 is :" + sum);
            Console.ReadLine
        }
    }
}
