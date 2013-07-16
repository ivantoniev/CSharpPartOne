using System;


namespace WithAccuracy
{
    class WithAccuracy
    {
        static void Main()
        {
            Console.WriteLine("We will calculate the sum with accuracy to 0.001 for the sequence (1+1/2+1/3+...)");
            double firstNum = (-1), sum = 1, nextNum;
            
            for (int i = 2; i < 1001; i++)
            {
                nextNum=Math.Pow(firstNum,i)/i;
                sum += nextNum;
            }
            Console.WriteLine(Math.Round(sum,3));
        }
    }
}
