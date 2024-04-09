using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            scalarVector objsv = new scalarVector();

            objsv.scalarSum(size);
            objsv.vectorSum(size);
            objsv.vectorProduct(size);
            objsv.scalarProduct(size);
        }
    }
}
