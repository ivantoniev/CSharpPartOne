using System;


namespace ProblemNine
{
    class ValuesChange
    {
        static void Main()
        {
            
            int firstNumber=5, secondNumber=10, someVar;
            Console.WriteLine("We have two given numbers {0} and {1}.",firstNumber,secondNumber);
            Console.WriteLine("Now we will change their values.");
            someVar =secondNumber;
            secondNumber = firstNumber;
            firstNumber = someVar;
            Console.WriteLine("Now the given numbers have changed values.{0} and {1}, ", firstNumber, secondNumber);
        }
    }
}
