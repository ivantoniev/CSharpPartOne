using System;


namespace CircleData
{
    class CircleData
    {
        static void Main()
        {
            double rad, circleArea,circlePerimeter;
           
            Console.WriteLine("Enter the radius size you wish to use");
            rad = double.Parse(Console.ReadLine());
            circleArea = Math.PI * rad * rad;
            circlePerimeter = 2 * Math.PI * rad;
            Console.WriteLine("The circle area is: {0}",circleArea);
            Console.WriteLine("The circle perimeter is: {0}",circlePerimeter);
        }
    }
}
