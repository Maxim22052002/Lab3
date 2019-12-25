using System;

namespace Number6_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            for(int i = 0; i < array.Length; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
                
            }
            int sumI = sumIterative(array);
            Console.WriteLine("SumIterative is: " + sumI);
            int minIter = minIterative(array);
            Console.WriteLine("MinIterative is: "+minIter);
            int sumRec = sumRecursive(array, 0, 0);
            Console.WriteLine("SumRecursive is: "+ sumRec);
            int minRec = minRecursive(array, array.Length-1,0); //return minRecursive(a, arraySize, a[arraySize - 1], 0);
            Console.WriteLine("MinRecursive is: "+ minRec);




        }
        static int sumIterative(int []mas)
        {
            int sum = 0;
            for(int i = 0; i < mas.Length; i++)

                
            {
                sum += mas[i];
            }
            return sum;
        }
        static int minIterative(int[] mas)
        {
            int min = mas[0];
            for(int i = 1; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                }

            }
            return min;
        }
        static int sumRecursive (int []a,int pos, int sum)
        {
            if (a.Length == pos)
            {
                return sum;
            }
            else
            {
                sum += a[pos];
                pos++;
                return sumRecursive(a, pos, sum);
            }
        }
        static int minRecursive(int[]a, int min,int pos)
        {
            if (pos < a.Length)
            {
                if (a[pos] < min)
                {
                    min = a[pos];
                }
                pos++;
                return minRecursive(a, min, pos);
            }
            else
            {
                return min;
            }
            
       
        }
        
        
    }
}
