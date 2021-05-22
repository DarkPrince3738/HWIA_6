using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            for(int i = a.Length; i > 0; i--)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
