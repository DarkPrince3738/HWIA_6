using System;

namespace Task5
{
    class Program
    {//зробив два в одному
        static void Main(string[] args)
        {
            int[] array = { 1, 9, 3, 2, 5 };
            var newElement = int.Parse(Console.ReadLine());
            PlusOneElement(array, newElement);
        }

        static void PlusOneElement(int[] array, int newElement)
        {
            int[] array2 = new int [array.Length+1];
            array2[0] = newElement;
            Console.Write($"{array2[0]} ");
            for(int i = 1; i <= array.Length; i++)
            {
                array2[i] = array[i - 1];
                Console.Write($"{array2[i]} ");

            }
        }
        
    }
}
