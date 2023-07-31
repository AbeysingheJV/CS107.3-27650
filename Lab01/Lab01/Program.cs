using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            float batch;
            string name;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your batch: ");
            batch = float.Parse(Console.ReadLine());

            Console.WriteLine(name + " " + batch);
            Console.ReadKey();
        }
    }
}
