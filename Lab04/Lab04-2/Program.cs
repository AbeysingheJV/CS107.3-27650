﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            FindValues calculator = new FindValues();
            double area = calculator.FindArea(radius);
            double circumference = calculator.FindCircumference(radius);

            Console.WriteLine("The area of the circle is: " + area);
            Console.WriteLine("The circumference of the circle is:" + circumference);

            Console.ReadLine();
        }
    }
}
