using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class1
    {
        private int age;
        public void vote(int age)
        {
            this.age = age;
            if (age > 17)
            {
                Console.WriteLine("Can");
            }
            else
            {
                Console.WriteLine("cannot");
            }

        }
    }
}
