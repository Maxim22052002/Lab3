using System;

namespace Number8_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[,] matrix = new int[N, N];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(1, 9);
                }
            }
            Print(matrix);
            Console.WriteLine();


            int determinant = DeterminantRecursive(matrix);
            Console.WriteLine(determinant);
        }

         static int DeterminantRecursive(int[,] matrix)
        {
            
            if (matrix.Length == 4)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            int sign = 1;
            int result = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int[,] minor = GettingMinor(matrix, i);
                result += sign * matrix[0, i] * DeterminantRecursive(minor);
                sign = -sign;
            }
            return result;
        }

         static int[,] GettingMinor(int[,] matrix, int n)
        {
            int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0, column = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == n)
                        continue;
                    result[i - 1, column] = matrix[i, j];
                    column++;
                }
            }
            return result;
        }
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

