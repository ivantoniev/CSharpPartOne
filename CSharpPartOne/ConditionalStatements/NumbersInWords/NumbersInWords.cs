using System;
namespace NumbersInWords
{
    class NumbersInWords
    {
        static void Main()
        {
            Console.WriteLine("Enter the number you wish.");
            int myNum = int.Parse(Console.ReadLine());
            int numFirst = 0, numSecond = 0, numThird = 0;
            string[] digits = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            if (myNum >= 0 && myNum < 10)
            {
                Console.WriteLine(digits[myNum]);
            }
            string[] underTwenty = new string[9] {"eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eightteen", "nineteen" };
            if (myNum > 10 && myNum < 20)
            {
                Console.WriteLine(underTwenty[myNum - 11]);
            }
            string[] decimals = new string[9] { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (myNum > 19 && myNum < 100 || myNum==10)
            {
                numFirst = myNum / 10;
                numSecond = myNum % 10;
                if (myNum % 10 == 0)
                {
                    Console.WriteLine(decimals[myNum / 10 - 1]);
                }
                else
                {
                    Console.WriteLine(decimals[myNum / 10 - 1] + ' ' + digits[myNum % 10]);
                }
            }         
            if(myNum>99 && myNum<1000)
            {
                numFirst = myNum / 100;
                numSecond = (myNum / 10) % 10;
                numThird = myNum % 10;
                if (numSecond != 0 && numThird!=0 && numSecond>1)
                {
                    Console.WriteLine(digits[numFirst] + " hundred and " + decimals[numSecond-1] + digits[numThird]);
                }
                else if(numSecond==1 && numThird!=0)
                {
                    Console.WriteLine(digits[numFirst] + " hundred and " + underTwenty[myNum%10-1]);
                }
                else if (numSecond!=0 && numThird==0)
                {
                    Console.WriteLine(digits[numFirst] + " hundred and " + decimals[numSecond-1]);
                }
                else if(myNum%100==0)
                {
                    Console.WriteLine(digits[myNum/100] + " hundred");
                }
                else if (numSecond == 0 && numThird != 0)
                {
                    Console.WriteLine(digits[myNum / 100] + " hundred and " + digits[myNum % 10]);
                }       
            }
        }
    }
}
