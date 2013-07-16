using System;
namespace FactSum
{
    class FactSum
    {
        static void Main()
        {
            Console.WriteLine("Enter you X and your N.");
            double x = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double fact = 1;
            double factSum = 0;
            if (x > 0)
            {
                for (int i = 1; i < n; i++)
                {
                    fact *= i;
                    factSum += fact / Math.Pow(x, i);
                }
                Console.WriteLine(factSum);
            }
        }
    }
}
