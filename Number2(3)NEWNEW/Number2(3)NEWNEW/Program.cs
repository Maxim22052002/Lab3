using System;

namespace Number2_3_NEWNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10, 99);

                }
            }
            Print(array);
            Console.WriteLine();
            ArrRot90deg(array);
            Print(array);
        }
        static void ArrRot90deg(int[,] ar)   //array rotation 90 degrees
        {
            for (int i = 0; i < ar.GetLength(0) / 2; i++)
            {
               
               for (int j = i; j < ar.GetLength(1) - i - 1; j++)
                {
                    
                    
                   int temp = ar[i, j];
                   ar[i, j] = ar[ar.GetLength(0) - 1 - j, i];
                   ar[ar.GetLength(0) - 1 - j, i] = ar[ar.GetLength(0) - 1 - i, ar.GetLength(0) - 1 - j];
                   ar[ar.GetLength(0) - 1 - i, ar.GetLength(0) - 1 - j] = ar[j, ar.GetLength(0) - 1 - i];
                   ar[j, ar.GetLength(0) - 1 - i] = temp;

                }


            }
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
