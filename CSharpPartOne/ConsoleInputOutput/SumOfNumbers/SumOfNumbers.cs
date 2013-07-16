using System;


namespace SumOfNumbers
{
    class SumOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter how much numers you want to sum.");
            int nums = int.Parse(Console.ReadLine());
            int someNum, sum=0;
            Console.WriteLine("Enter your numbers ");
            for (int i = 0; i < nums; i++)
            {
                someNum = int.Parse(Console.ReadLine());
                sum += someNum;
            }
            Console.WriteLine("The sum of your numbers is: {0}",sum);
        }
    }
}
