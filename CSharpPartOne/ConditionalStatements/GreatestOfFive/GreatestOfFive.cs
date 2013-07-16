using System;
namespace GreatestOfFive
{
    class GreatestOfFive
    {
        static void Main()
        {
            Console.WriteLine("Enter five numbers.");
            double firstNum, secondNum, thirdNum, fourthNum, fifthNum;
            firstNum = double.Parse(Console.ReadLine());
            secondNum = double.Parse(Console.ReadLine());
            thirdNum = double.Parse(Console.ReadLine());
            fourthNum = double.Parse(Console.ReadLine());
            fifthNum = double.Parse(Console.ReadLine());
            if (firstNum >= secondNum && firstNum >= thirdNum && firstNum >= fourthNum && firstNum >= fifthNum)
            {
                Console.WriteLine("The max element is: {0}", firstNum);
            }
            else if (secondNum >= firstNum && secondNum >= thirdNum && secondNum >= fourthNum && secondNum >= fifthNum)
            {
                Console.WriteLine("The max element is: {0}", secondNum);
            }
            else if (thirdNum >= firstNum && thirdNum >= secondNum && thirdNum >= fourthNum && thirdNum >= fifthNum)
            {
                Console.WriteLine("The max element is: {0}", thirdNum);
            }
            else if (fourthNum >= firstNum && fourthNum >= thirdNum && fourthNum >= fourthNum && fourthNum >= fifthNum)
            {
                Console.WriteLine("The max element is: {0}", fourthNum);
            }
            else if(fifthNum >= firstNum && fifthNum >= secondNum && fifthNum >= thirdNum && fifthNum >= fourthNum)
            {
                Console.WriteLine("The max element is: {0}",fifthNum);
            }
        }
    }
}
