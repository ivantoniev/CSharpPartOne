using System;

namespace PosOrNegSum
{
    class PosOrNegSum
    {
        static void Main()
        {
            Console.WriteLine("Enter the numbers you wish to multiply.");
            int firstNum, secondNum, thirdNum;
            firstNum = int.Parse(Console.ReadLine());
            secondNum = int.Parse(Console.ReadLine());
            thirdNum = int.Parse(Console.ReadLine());
            int product = firstNum * secondNum * thirdNum;
            if (product < 0)
            {
                Console.WriteLine(product);
            }
            else 
            {
                Console.Write('+'); Console.WriteLine(product);
            }
        }
    }
}
