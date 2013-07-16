using System;
namespace Factorials
{
    class Factorials
    {
        static void Main()
        {
            Console.WriteLine("Enter your N and your K. They must be bigger than 1!");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int nFact = 1, kFact = 1;
            int fact = 1;
            int helper = k - n;
            if (k > 1 && n > 1)
            {
                if (k <= n)
                {
                    Console.WriteLine("N must be smaller than K!");
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        nFact *= i;
                    }
                    for (int i = 1; i <= k; i++)
                    {
                        kFact *= i;
                    }
                    for (int i = 1; i <= helper; i++)
                    {
                        fact *= i;
                    }
                    Console.WriteLine((nFact * kFact) / fact);
                }
            }
            else 
            {
                Console.WriteLine("K and N must be bigger than 1!");            
            }
        }
    }
}
