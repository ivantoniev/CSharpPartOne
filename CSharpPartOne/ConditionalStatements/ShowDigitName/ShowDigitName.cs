﻿using System;
namespace ShowDigitName
{
    class ShowDigitName
    {
        static void Main()
        {
            Console.WriteLine("Enter the number you wish to be written");
            int ourNum = int.Parse(Console.ReadLine());
            switch (ourNum)
            {
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                default: Console.WriteLine("Enter a number between 1 and 9"); break;
            }
        }
    }
}
