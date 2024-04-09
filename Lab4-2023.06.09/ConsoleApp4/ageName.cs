using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class ageName
    {

        public int hello()
        {
            Console.Write("Enter name : ");
            string name = Console.ReadLine();

            Console.Write("Enter age : ");
            int age = int.Parse(Console.ReadLine());

            return age;
        }
    }
}
