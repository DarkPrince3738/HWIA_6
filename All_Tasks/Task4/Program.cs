using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyReverse();
        }
        static void MyReverse()
        {
            int[] array = new int[5] { 1, 9, 12, 7, 6 };
            for (int i = array.Length; i > 0 ; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
