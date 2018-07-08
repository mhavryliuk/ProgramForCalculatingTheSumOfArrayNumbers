using System;
using System.Linq;

namespace array1D
{
    internal static class OneDimensionalArray
    {
        /// <summary>
        /// The EnterArrayElements() method creates an array of user-entered numbers.
        /// </summary>
        /// <returns>The array created by the user.</returns>
        internal static int[] EnterArrayElements()
        {
            Console.Write("Size of array n = ");
            int.TryParse(Console.ReadLine() ?? throw new InvalidOperationException(), out int n);
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Element with index [{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            }

            return array;
        }

        /// <summary>
        /// The AddArrayNumbers() method calculates the sum of the numbers in the array.
        /// </summary>
        /// <param name="array">A one-dimensional array of n integers.</param>
        /// <returns>The sum of the numbers of the given array.</returns>
        internal static int AddArrayNumbers(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (array.Length == 0)
                throw new ArgumentException("Value cannot be an empty collection.", nameof(array));

            return array.Sum();
        }
    }
}