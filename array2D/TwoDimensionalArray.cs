using System;
using System.Linq;

namespace array2D
{
    internal static class TwoDimensionalArray
    {
        /// <summary>
        /// The EnterArrayElements() method creates an array of user-entered numbers.
        /// </summary>
        /// <returns>The array created by the user.</returns>
        internal static int[,] EnterArrayElements()
        {
            Console.Write("Number of lines in the array n = ");
            int.TryParse(Console.ReadLine(), out int lines);

            Console.Write("Number of columns in the array m = ");
            int.TryParse(Console.ReadLine(), out int columns);
            Console.WriteLine();

            int[,] array = new int[lines, columns];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    do
                    {
                        Console.Write($"Element with index [{i},{j}] = ");
                    } while (!int.TryParse(Console.ReadLine(), out array[i, j]));
                }
            }

            return array;
        }

        /// <summary>
        /// The AddArrayNumbers() method calculates the sum of the numbers in the array.
        /// </summary>
        /// <param name="array">A two-dimensional array of n*m integers.</param>
        /// <returns>The sum of the numbers of the given array.</returns>
        internal static int AddArrayNumbers(int[,] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (array.Length == 0)
                throw new ArgumentException("Value cannot be an empty collection.", nameof(array));

            return array.Cast<int>().Sum();
        }

        /// <summary>
        /// The PrintArray() method outputs the elements of the array to the console.
        /// </summary>
        /// <param name="array">A two-dimensional array of n*m integers.</param>
        internal static void PrintArray(int[,] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (array.Length == 0)
                throw new ArgumentException("Value cannot be an empty collection.", nameof(array));

            Console.WriteLine("\nAvailable array:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
