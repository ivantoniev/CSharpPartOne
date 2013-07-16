using System;

namespace WhatIsGreater
{
    class WhichIsGreater
    {
        static void Main()
        {
            double numOne, numTwo;
            Console.WriteLine("Enter two numbers: ");
            numOne = double.Parse(Console.ReadLine());
            numTwo = double.Parse(Console.ReadLine());
            bool statement = (numOne - numTwo >0);
            Console.WriteLine( statement==true ? "The first number is greater. " : "The second number is greater.");
        }
    }
}
