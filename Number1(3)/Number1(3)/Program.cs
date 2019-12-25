using System;

namespace Number1_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            int a = 0;
            int b = N;
            int c = 10;
            
            
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)

            {
                array[i] = random.Next(-30, 45);
                
            }
            
            while (b > 0)
            {
                
                if (b - 10 >= 0)
                {
                    for(int i = a; i < c; i++)
                    {
                        Console.Write(array[i]+" ");
                    }
                    a += 10;
                    b -= 10;
                    c += 10;
                    Console.WriteLine();
                }
                else
                {
                    for(int i = a; i < array.Length; i++)
                    {
                        Console.Write(array[i] +" ");
                    }
                    break;
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("____________________________");
            for (int i = array.Length-1; i >= 0; i--)
            {
                
                if (array[i] >= 0)
                {
                   
                    Console.Write(array[i] + " ");
                }
            }
             
                
            
            
        }
    }
}
