using System;
using System.Linq;
namespace FactDivision
{
    class FactDivision
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your N and your K.");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int fact = 1;
            if (k >= n)
            {
                Console.WriteLine("K must be smaller than N!");
            }
            else
            {
                for (int i = k + 1; i <= n; i++)
                {
                    fact *= i;
                }
                Console.WriteLine(fact);
            }
        }
    }
}
