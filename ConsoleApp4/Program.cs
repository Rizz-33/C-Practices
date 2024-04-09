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
            Student ObjStudent = new Student();
            //ObjStudent.MyMethod();

            //Student ObjStudent1 = new Student();
            //ObjStudent.MyInfo();

            ObjStudent.namedegree();

            ObjStudent.vote();
            Console.ReadKey();
        }
    
    }
}
