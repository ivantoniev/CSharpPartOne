using System;
namespace PrintNumbers
{
    class PrintNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter your number.");
            int myNum = int.Parse(Console.ReadLine());
            for (int i = 1; i < myNum+1; i++)
            {             
                Console.WriteLine(i);               
            }
        }
    }
}
