using System;


namespace FiboSequence
{
    class Fibonacci
    {
        static void Main()
        {
            Console.WriteLine("The first 100 numbers of the fibonacci sequence are: ");


            decimal firstNum = 0, secondNum = 1;
            decimal sum;
            Console.WriteLine(firstNum + "\n");
            Console.WriteLine(secondNum + "\n");
            for (int i = 0; i < 99; i++)
            {
                sum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = sum;
                Console.WriteLine(sum + "\n");
            }
        }
    }
}
