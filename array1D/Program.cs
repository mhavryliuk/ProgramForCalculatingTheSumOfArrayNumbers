using System;

/**<remark>
 * Given a one-dimensional array of n integers.
 * Write a program to calculate the sum of these numbers.
 </remark> */

namespace array1D
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                int[] array = OneDimensionalArray.EnterArrayElements();
                Console.WriteLine("\nSum of array elements = {0}", OneDimensionalArray.AddArrayNumbers(array));
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
