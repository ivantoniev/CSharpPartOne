﻿using System;
namespace TrailingZeros
{
    class TrailingZeros
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            int zerosCount = 0;
            if (N % 5 == 0)
            {
                zerosCount = N / 5;
            }
            Console.WriteLine("The count of zeros at the end is {0}", zerosCount);
        }
    }
}