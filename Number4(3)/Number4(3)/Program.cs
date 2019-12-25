using System;

namespace Number4_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Elements of the first matrix: ");
            int[,] A = new int[3, 3];
            for(int i = 0; i < A.GetLength(0); i++)
            {
                for(int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}]=",i,j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("Elements of the second matrix: ");
            int[,] B = new int[3, 3];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}]=", i, j);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            double mean = 0.0d;
            int[,] C = sumMatrix(A, B, out mean);
            Console.WriteLine("Matrix A: ");
            Print(A);
            Console.WriteLine("Matrix B: ");
            Print(B);
            Console.WriteLine("Matrix C = A + B: ");
            Print(C);
            int[,] D = diffMatrix(A, B);
            Console.WriteLine("Matrix D = A - B: ");
            Print(D);
            Console.WriteLine("Average: " + mean);


        }
        static int[,] sumMatrix(int [,] a , int [,] b, out double result)
        {
            
            double sum1 = 0;
            double sum2 = 0;
            int[,] summat = new int[a.GetLength(0), b.GetLength(1)];
            for(int i = 0; i < b.GetLength(0); i++)
            {
                for(int j = 0; j < b.GetLength(1); j++)
                {
                    summat[i, j] = a[i, j] + b[i, j];
                    sum1 += a[i, j];
                    sum2 += b[i, j];
                }

            }
            result = (sum1 + sum2) / (2 * a.Length);

            return summat;
        }
        static int[,] diffMatrix(int[,] a, int[,] b)
        {
            int[,] diffmat = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    diffmat[i, j] = a[i, j] - b[i, j];
                }
            }
            return diffmat;
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
    }   }
}
