using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Salary : ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the tax rate :");
            double tax = double.Parse(Console.ReadLine());

            double newsalary;

            newsalary = salary - (salary * tax / 100);

            Console.WriteLine("New salary :" + newsalary);
            Console.ReadLine();
        }
    }
}
