using System;

namespace MyMath
{
    /// <summary>
    /// Class for matrix operation
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Method that returns an array with each element divide by param num
        /// </summary>
        /// <param name="matrix">input array</param>
        /// <param name="num">input number to divide elements in array</param>
        /// <returns>new array with the result of the division of each element</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null) return null;

            try
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = matrix[i, j] / num;
                    }
                }
                return matrix;
            }
            catch (Exception)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
        }
    }
}
