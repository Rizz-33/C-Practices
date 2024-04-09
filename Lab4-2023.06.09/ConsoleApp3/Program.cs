using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
                Console.WriteLine("not eligible.");
            else
                Console.WriteLine("eligible.");

            Console.ReadKey();
        }
    }
}
