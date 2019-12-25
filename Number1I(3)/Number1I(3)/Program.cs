using System;

namespace Number1I_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array =new int [N, N];
            Console.WriteLine("Matrix: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    array[i, j] = rand.Next(10, 99);
                    array[j, i] = array[i, j];
                    
                    
                }
                
                
            }
            Console.WriteLine();
            Print(array);
            
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
