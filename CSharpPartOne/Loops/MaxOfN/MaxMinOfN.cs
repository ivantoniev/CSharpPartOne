using System;
using System.Linq;
namespace MaxOfN
{
    class MaxMinOfN
    {
        static void Main()
        {
            Console.WriteLine("How much numbers do you want to enter?");
            int nums = int.Parse(Console.ReadLine());
            int[] myArr;
            myArr = new int[nums];
            int max, min;
            
            for (int i = 0; i < nums; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            min = myArr[0];
            max = myArr[0];
            for (int i = 0; i < nums; i++)
            {
                if (myArr[i] > max)
                {
                    max = myArr[i];
                }
                if (myArr[i] < min)
                {
                    min = myArr[i];
                }
            }
            Console.WriteLine("{0} {1}", max, min);
        }
    }
}
