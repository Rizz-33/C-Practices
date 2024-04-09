using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length;  i++)
            {
                Console.WriteLine("Enter the element $(i+1): ");
                arr[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
