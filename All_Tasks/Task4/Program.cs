using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 3, 6, 9, 1};
            MyReverse(array);
            //SubArray
        }
        static void MyReverse(int[] array)
        {
            for (int i = array.Length-1; i >= 0 ; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
