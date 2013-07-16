using System;
namespace SortThree
{
    class SortThree
    {
        static void Main()
        {
            Console.WriteLine("Add the three numbers you with to sort.");
            double firstNum, secondNum, thirdNum;
            firstNum = double.Parse(Console.ReadLine());
            secondNum = double.Parse(Console.ReadLine());
            thirdNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Now we will sort them in descending order.");
            if (firstNum >= secondNum && firstNum >= thirdNum)
            {
                if (secondNum >= thirdNum)
                {
                    Console.WriteLine("{0} {1} {2}",firstNum, secondNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}",firstNum,thirdNum,secondNum);
                }
            }
            else if (secondNum >= firstNum && secondNum >= thirdNum)
            {
                if (firstNum >= thirdNum)
                {
                    Console.WriteLine("{0} {1} {2}", secondNum, firstNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", secondNum, thirdNum, firstNum);
                }
            }
            else if(thirdNum >= firstNum && thirdNum >= secondNum)
            {
                if (firstNum >= secondNum)
                {
                    Console.WriteLine("{0} {1} {2}", thirdNum, firstNum, secondNum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", thirdNum, secondNum, firstNum);
                }
            }
        }
    }
}
