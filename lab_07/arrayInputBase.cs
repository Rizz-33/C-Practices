using System;

namespace lab_07
{
    internal class arrayInputBase
    {
        public void Inputarray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine("Enter the value" + i);
                i = int.Parse(Console.ReadLine());
                //return array[i];
                array[i] = 0;
               // return array[i];
                i++;
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
                //return array[i];
            }
        }
    }
}