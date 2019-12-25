using System;

namespace Number5_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elements of the first matrix: ");
           
            int[,] A = new int[5, 5];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}]=", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Elements of the second matrix: ");
            
            int[,] B = new int[5, 5];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write("B[{0},{1}]=", i, j);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix A: ");
            Print(A);
            Console.WriteLine("Matrix B: ");
            Print(B);
            int[,] C = MultiplicationMatrixs(A, B);
            Console.WriteLine("Matrix C: ");
            Print(C);
            Console.WriteLine();




        }
        static int[,] MultiplicationMatrixs(int[,] a, int[,] b)
        {
            
            int[,] multipl = new int[a.GetLength(1), b.GetLength(0)];
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < b.GetLength(0); j++)
                {
                    for (int k = 0; k < b.GetLength(1); k++)
                    {
                        multipl[j, i] += a[k, i] * b[j, k];
                    }
                }
            }
            return multipl;


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
