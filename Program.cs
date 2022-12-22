using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_PROJECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, i, j;
            Console.WriteLine("enter the N1 and N2 ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            for (i = n1; i <= n2; i++)
            {
                int sum = 0;
                for (j = 1; j < i; j++)
                {



                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == 0)
                    continue;
                if (sum == i)
                    Console.WriteLine("The perefect number :" + i);

            }
            Console.ReadKey();
        }
    }
}
