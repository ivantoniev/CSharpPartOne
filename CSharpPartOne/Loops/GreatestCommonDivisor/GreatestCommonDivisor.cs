using System;
namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            Console.WriteLine("Enter the numbers you want to see the greatest common divisor of.");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            while (firstNum!=secondNum)
            {
                if (firstNum > secondNum)
                {
                    firstNum = firstNum - secondNum;
                }
                else
                {
                    secondNum = secondNum - firstNum;                
                }                
            }
            Console.WriteLine(firstNum);
        }
    }
}
