using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
	internal class Program
	{
		static void Main(string[] args)
		{


			/*int age;

			Console.WriteLine("Enter your age : ");
			age = int.Parse(Console.ReadLine());
			age = Convert.Parce.Toint32(Console.ReadLine());
			Console.WriteLine("Your age is " + age);*/

			string name;
			int age;

			Console.WriteLine("Enter your name: ");
			name = Console.ReadLine();
			Console.WriteLine("Enter your age: ");
			age = int.Parse(Console.ReadLine());

			if (age >= 20)
				Console.WriteLine("You, " + name + " can vote.");
			else
				Console.WriteLine("You, " + name + " cannot vote.");


			Console.ReadLine();
		}
	}
}
