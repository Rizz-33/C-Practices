using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ageName obj = new ageName();
            
            Class1 objj = new Class1();
            objj.vote(obj.hello());

            Console.ReadLine();
        }
    }
}
