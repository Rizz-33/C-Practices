using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1
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

            Console.ReadKey();*/


            /*
            int num=0;
            string vowels = "aeiouAEIOU";
            Console.WriteLine("Enter your string : ");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++) 
            {
                if (vowels.Contains(str[i]))
                {
                    num++;
                }
            }
            
            Console.WriteLine($"Number of vowels in the given string is : {num}");

            Console.ReadKey();*/
            /*
            int i, sum=0;
            Console.Write("Enter the number of integers you going to add: ");
            int num= int.Parse(Console.ReadLine());

            for (i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter the number {i+1}: ");
                int value = int.Parse(Console.ReadLine());

                sum =+ value;
            }

            Console.WriteLine($"The sum of given numbers is {sum}");

            Console.ReadKey();*/



            /*
                  Console.WriteLine("Enter the lenght of the inger values : ");
                  int Loop = Convert.ToInt32(Console.ReadLine());

                  int sum = 0;
                  for (int i = 0; i < Loop; i++)
                  {
                      Console.WriteLine("Enter an positive integer value : ");
                      int num = Convert.ToInt32(Console.ReadLine());

                      if (num % 2 == 0)
                      {
                          Console.WriteLine("Invalid input");
                      }
                      else
                      {
                          sum += num;
                      }
                  }

                  Console.WriteLine($"Sum is: {sum}");


                  Console.ReadKey();*/

            int num;
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            int sum = 0;
            num = Math.Abs(num);

            while (num > 0)
            {
                int digit=num % 10;
                sum += digit;
                num /= 10;
            }
            console.writeline("SUM :" + sum);
        }
    }
}
