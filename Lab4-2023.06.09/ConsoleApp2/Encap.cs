using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Encap
    {
        private int sum;
        public void setSum(int num1, int num2)
        {
            sum = num1+num2;
        }
        public int getSum()
        {
            return sum;
        }
    }
}
