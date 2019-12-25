using System;

namespace Number2_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int[] a = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] b = new int[10];
            //int offset = 3;
            //for (int i = 0; i < a.Length; i++)
            // {
            //  b[i] = (i + offset) % a.Length;
            //Console.WriteLine(b[i]);
            //}
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
                 {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                 }
            int k = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < k; j++)
            {
                int num1 = a[0];
                for (int i = 0; i < n-1; i++)
                {

                    a[i] = a[i + 1];

                    
                    
                    
                }
                a[n-1] = num1;
                //Console.Write(a[i] + " ");

                //for( j = 0; j < n; j++)
                //{
                //    Console.Write(a[j] + " ");
                // }
            }


            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" "+a[i]);
            }



            //int N = Conve
            // {
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            // }
            //int k = Convert.ToInt32(Console.ReadLine());rt.ToInt32(Console.ReadLine());
            //int[] a = new int[N];





            // for (int i = 0; i < a.Length; i++)
            //int[] b = new int[N];
            // for(int i = 0; i < b.Length ; i++)
            // {
            //   b[i] = (i + k) % a.Length;
            // Console.WriteLine(b[i]+" ");
            //}








        }
    }
}
