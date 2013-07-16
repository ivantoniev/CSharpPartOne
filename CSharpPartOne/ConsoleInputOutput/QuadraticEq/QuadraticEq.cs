using System;


namespace QuadraticEq
{
    class QuadraticEq
    {
        static void Main()
       {    double xOne, xTwo, discr;
            Console.WriteLine("Enter the a, b and c coefficients of a quadratic equation.");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            
            discr = (b * b) - (4 * a * c);
            if (discr < 0) 
            { Console.WriteLine("There are no real answers to your equation!"); }
            else
            {
                xOne = ((-b) + Math.Sqrt(discr)) / (2 * a);
                xTwo = ((-b) - Math.Sqrt(discr)) / (2 * a);
                Console.WriteLine("Your answers are: {0} and {1}", xOne, xTwo);
            }
        }
    }
}
