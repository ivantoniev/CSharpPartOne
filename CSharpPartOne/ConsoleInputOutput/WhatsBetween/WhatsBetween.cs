using System;


namespace WhatsBetween
{
    class WhatsBetween
    {
        static void Main()
        {
            int firstNum, secondNum;
            Console.WriteLine("Enter two numbers.");
            firstNum = int.Parse(Console.ReadLine());
            secondNum = int.Parse(Console.ReadLine());
            int sum=0;
            for (int i = (firstNum + 1); i < secondNum; i++)
            {
                if (i % 5 == 0) 
                {
                    sum++;
                }
            }
            Console.WriteLine("How many numbers are there between them that when divided by 5 their reminder is 0? {0}",sum);
        }
    }
}
