using System;
namespace IsItPrime
{
    class IsItPrime
    {
        static void Main()
        {
            int givenNumber = 31;
            bool isPrime = true;
            for (int i = 2; i < Math.Sqrt(givenNumber); i++)
            {
                if (givenNumber % i == 0)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine("Is the number prime? {0}",isPrime);
        }
    }
}
