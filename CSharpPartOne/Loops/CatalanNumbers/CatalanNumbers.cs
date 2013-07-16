using System;
namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter the index of the catalan number you want.");
            int index = int.Parse(Console.ReadLine());
            int firstFact = 1, cataNum, secondFact = 1,fact = 1, overall;
            if (index >= 0)
            {
                for (int i = 1; i <= 2 * index; i++)
                {
                    firstFact *= i;
                }
                for (int i = 1; i <= (index + 1); i++)
                {
                    secondFact *= i;
                }
                for (int i = 1; i <= index; i++)
                {
                    fact *= i;
                }
                overall = firstFact / (secondFact * fact);
                Console.WriteLine(overall);
            }
            else
            {
                Console.WriteLine("The index must not be negative!");
            }
        }
    }
}
