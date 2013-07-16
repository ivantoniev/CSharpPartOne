using System;
using System.Linq;
namespace ByThirtyFive
{
    class DivideByThirtyFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number.");
            int myNum = int.Parse(Console.ReadLine());
            for (int i = 1; i < myNum + 1; i++)
            {
                if (i % 35 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
