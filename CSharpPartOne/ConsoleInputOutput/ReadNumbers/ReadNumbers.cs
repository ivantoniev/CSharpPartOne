using System;


namespace ReadNumbers
{
    class ReadNumbers
    {
        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int sum = numOne + numTwo + numThree;
            Console.WriteLine("The sum of the three given numbers is: {0}",sum);
        }
    }
}
