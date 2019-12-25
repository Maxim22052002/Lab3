using System;

namespace Number2I_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int leftsum = 0;
            int rightsum = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (N % 2 == 0)
            {
                for (int i = array.Length / 2; i < array.Length; i++)
                {
                    rightsum += array[i];
                }
                
                for (int i = 0; i < array.Length / 2; i++)
                {
                    leftsum += array[i];
                }
                Console.WriteLine(leftsum-rightsum);

            }
            else
            {
                for(int i = 0; i <= array.Length / 2; i++)
                {
                    leftsum += array[i];
                }
                for (int i = array.Length / 2; i < array.Length; i++)
                {
                    rightsum += array[i];
                }
                Console.WriteLine(leftsum-rightsum);
            }
        }
    }
}
