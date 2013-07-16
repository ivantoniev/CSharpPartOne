using System;
namespace TrapezoidArea
{
    class TrapArea
    {
        static void Main()
        {
            int trapBaseOne = 3, trapBaseTwo = 7, trapHeight = 10;
            double trapArea = ((trapBaseOne + trapBaseTwo) * trapHeight) / 2;
            Console.WriteLine(("The Area of the given trapezoid is: ") + (trapArea));
        }
    }
}
