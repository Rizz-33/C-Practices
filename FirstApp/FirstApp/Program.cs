using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {
        /* static void Main(string[] args)
         {
             /*create a console application project to store your name, age and batch using relevent variables. And also display the variable value using necessary function.

             string name = "Risini";
             //int age = 21;
             //double batch = 22.2;

             //Console.WriteLine(age);
             //Console.WriteLine("" + age);
             //Console.WriteLine("My name is " + name);
             //Console.WriteLine("My age is " + age);
             //Console.WriteLine("My batch is " + batch);

             //string name;

             // Console.WriteLine("Enter your name: ");
             // name = Console.ReadLine();

             //Console.WriteLine("Welcome " + name);

             int age;

             Console.WriteLine("Enter your age : ");
             age = int.Parse(Console.ReadLine());

             Console.WriteLine("Your age is " + age);

             string name;
             int age;

             Console.WriteLine("Enter your name: ");
             name = Console.ReadLine();
             Console.WriteLine("Enter your age: ");
             age = int.Parse(Console.ReadLine());

             if (age >= 20)
                 Console.WriteLine("You, " + name + " can vote.");
             else

             //create c# application project to get km value from the user and convert it into cm and display the answer.

             double km;
             double cm;

             Console.WriteLine("Enter in kilo meters : ");
             km = double.Parse(Console.ReadLine());

             cm = km * 1000;

                 Console.WriteLine("You, " + name + " cannot vote.");
             Console.WriteLine("in centi meters : " + cm);*/

        //write a c# application project to get an integer input and display next immediate 20 counting numbers by using any preferable loop.

        /*int num, i;

        Console.WriteLine("Enter a number : ");
        num = int.Parse(Console.ReadLine());

        for (i = num; i <= num + 20; i++)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();

        static int DiagonalDifference(int[][] matrix)
        {
            int n = matrix.Length;
            int leftDiagonalSum = 0;
            int rightDiagonalSum = 0;

            // Calculate the sum of the left-to-right diagonal
            for (int i = 0; i < n; i++)
            {
                leftDiagonalSum += matrix[i][i];
            }

            // Calculate the sum of the right-to-left diagonal
            for (int i = 0; i < n; i++)
            {
                rightDiagonalSum += matrix[i][n - 1 - i];
            }

            // Calculate the absolute difference between the diagonal sums
            int absoluteDifference = Math.Abs(leftDiagonalSum - rightDiagonalSum);

            return absoluteDifference;

        static void Main()
        {
            // Example matrix
            int[][] matrix = new int[][]
            {
        new int[] { 1, 2, 3 },
        new int[] { 4, 5, 6 },
        new int[] { 9, 8, 9 }
            };

            int result = DiagonalDifference(matrix);
            Console.WriteLine("The absolute difference between the diagonal sums is: " + result);
            */



            Console.WriteLine("Enter an integer value : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"The number {num} is even.");
            }
            else
            {
                Console.WriteLine($"The number {num} is odd.")
            }

            Console.ReadKey();
            }
        }
    }
}
