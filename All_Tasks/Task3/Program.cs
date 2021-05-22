using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 1, 5, 8, 5, 2, 9, 10, 12, 34, 21};
            var maxi = a[0];
            var mini = a[0];
            var sum = 0;
            /*for (int i = 0; i < N; i++)
            {
                int a[i] = int.Parse(Console.ReadLine());
            }*/
            for (int i = 0; i < a.Length; i++)
            {
                if (maxi < a[i])
                {
                    maxi = a[i];
                }
                if (mini > a[i])
                {
                    mini = a[i];
                }
                sum += a[i];
            }

            Console.WriteLine($"Max = {maxi}");
            Console.WriteLine($"Min = {mini}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Avg = {(sum/a.Length)}");
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    Console.WriteLine($"Pos {i+1} - {a[i]} ");
                }
            }
        }
    }
}
