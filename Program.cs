using System;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {                        
            Random rd = new Random();
            int n = rd.Next(1, 10);
            int[] a = new int[n];
            a[0] = 0;
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                a[i] = rd.Next(0, n);
                Console.Write("{0} ", a[i]);                                
            }
            int j = 0;
            for (int k = 0; k < n && j != n; k++)
            {
                j = 0;
                while(j < n && a[j] != k)
                {            
                    j++;
                }
                if (j == n)
                {
                    Console.WriteLine("MEX: {0}", k);                    
                }
            }
            if (j != n)
            {
                Console.WriteLine("MEX: {0}", n);
            }
            Console.ReadKey();
        }
    }
}