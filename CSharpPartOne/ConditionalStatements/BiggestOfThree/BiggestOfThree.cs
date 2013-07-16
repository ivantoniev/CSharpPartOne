using System;
namespace BiggestOfThree
{
    class BiggestOfThree
    {
        static void Main()
        {
            Console.WriteLine("Enter the three numbers you wish to compare.");
            int firstNum, secondNum, thirdNum;
            firstNum = int.Parse(Console.ReadLine());
            secondNum = int.Parse(Console.ReadLine());
            thirdNum = int.Parse(Console.ReadLine());
            if (firstNum > secondNum)
            {
                if (firstNum > thirdNum)
                {
                    Console.WriteLine(firstNum);
                }
                else
                {
                    Console.WriteLine(thirdNum);
                }
            }
            else
            {
                if (secondNum > thirdNum)
                {
                    Console.WriteLine(secondNum);
                }
                else
                {
                    Console.WriteLine(thirdNum);
                }
            }
        }
    }
}
