using System;

/**<remark>
 * Given a two-dimensional array of n*m integers.
 * Write a program to calculate the sum of these numbers.
 </remark> */

namespace array2D
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                int[,] array = TwoDimensionalArray.EnterArrayElements();
                TwoDimensionalArray.PrintArray(array);
                Console.WriteLine("\nSum of elements in a two-dimensional array = {0}", TwoDimensionalArray.AddArrayNumbers(array));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Write("\nPress any key to exit...");
            }

            Console.ReadKey();
        }
    }
}
