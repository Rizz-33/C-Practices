using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"The number {num} is even.");
            }
            else
            {
                Console.WriteLine($"The number {num} is odd.");
            }

            Console.ReadKey();
        }
    }
}
