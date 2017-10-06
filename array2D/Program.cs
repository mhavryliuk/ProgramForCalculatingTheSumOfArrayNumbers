using System;

// A task:
// Given a two-dimensional array of n*m integers.
// Write a program to calculate the sum of these numbers.

// Задача:
// Дан двумерный массив из n*m целых чисел.
// Написать программу для подсчета суммы этих чисел.

namespace array2D
{
    class Program
    {
        static int[,] Input()
        {
            Console.Write("Number of lines in the array n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Number of column in the array m = ");
            int m = int.Parse(Console.ReadLine());

            int[,] a = new int[n, m];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("a[{0},{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        static int Sum(int[,] a)
        {
            int sum = 0;
            foreach (int elem in a)
            { sum += elem; }
            return sum;
        }

        static void Print(int[,] a)
        {
            Console.WriteLine("\nAvailable array:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int[,] a = Input();
            Print(a);
            Console.WriteLine("\nSum of elements in a two-dimensional array = {0}", Sum(a));

            Console.ReadKey();
        }
    }
}
