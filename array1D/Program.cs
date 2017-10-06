using System;

// A task:
// Given a one-dimensional array of n integers.
// Write a program to calculate the sum of these numbers.

// Задача:
// Дан одномерный массив из n целых чисел.
// Написать программу для подсчета суммы этих чисел.

namespace array1D
{
    class Program
    {
        static int[] Input()
        {
            Console.Write("Size of array n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        static int Sum(int[] a)
        {
            int sum = 0;
            foreach (int elem in a)
            {
                sum += elem;
            }
            return sum;
        }

        static void Main()
        {
            int[] a = Input();
            Console.WriteLine("\nSum of array elements = {0}", Sum(a));

            Console.ReadKey();
        }
    }
}
