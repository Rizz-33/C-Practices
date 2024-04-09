using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EncapClass ec = new EncapClass();
            ec.setAge(21);
            ec.setName("Risini");
            Console.WriteLine("Your name is " + ec.getName());
            Console.WriteLine("Your age is " + ec.getAge());
            Console.ReadLine();
        }
    }
}
