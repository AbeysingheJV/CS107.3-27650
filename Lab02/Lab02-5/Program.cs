using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The given number is even number");
            }
            else
            {
                Console.WriteLine("The given number is odd number");
            }
        

             Console.ReadLine();
        }
    }
}
