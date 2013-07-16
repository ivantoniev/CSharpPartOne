using System;
namespace FiboSum
{
    class FiboSum
    {
        static void Main()
        {
            Console.WriteLine("How much numbers of fibonacci do you want to sum?");
            decimal n = decimal.Parse(Console.ReadLine());
            decimal firstNum = 0, secondNum = 1;
            decimal sum, mainSum = 0;
            if(n>2)
            {
                Console.WriteLine(firstNum);
                Console.WriteLine(secondNum);

                for (int i = 0; i < n-2; i++)
                {
                    sum = firstNum + secondNum;
                    firstNum = secondNum;
                    secondNum = sum;
                    mainSum += sum;  
                    Console.WriteLine("{0} {1}",sum,mainSum+1);          
                }  
            }
            else if(n==2)
            {
                Console.WriteLine(firstNum);
                Console.WriteLine(secondNum);
            }
            else if (n==1)
            {
                Console.WriteLine(firstNum);
            }
        }
    }
}
