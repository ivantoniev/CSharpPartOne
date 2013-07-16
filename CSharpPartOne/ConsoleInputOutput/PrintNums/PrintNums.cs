using System;

namespace PrintNums
{
    class PrintNums
    {
        static void Main()
        {
            Console.WriteLine("Enter your number. ");
            int theirNum = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers between 0 and your numer are: ");
            for (int i = 0; i < theirNum; i++)
            {
                Console.WriteLine(i + "\n");
            }
        }
    }
}
