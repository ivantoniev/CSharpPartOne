using System;

namespace ChangeIfGreater
{
    class ChangeIfGreater
    {
        static void Main()
        {
            Console.WriteLine("Enter the numbers you want.");
            int firstVar = int.Parse(Console.ReadLine());
            int secondVar = int.Parse(Console.ReadLine());
            if (firstVar > secondVar)
            {
                int helper;
                helper = firstVar;
                firstVar = secondVar;
                secondVar = helper;
                Console.WriteLine("the exchanged values are: {0} {1}", firstVar, secondVar);
            }
            else
            {
                Console.WriteLine("The second is bigger.");
            }
        }
    }
}