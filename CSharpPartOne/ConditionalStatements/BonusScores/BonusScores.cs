using System;
namespace BonusScores
{
    class BonusScores
    {
        static void Main()
        {
            Console.WriteLine("Enter a digit.");
            int caseVar = int.Parse(Console.ReadLine());
            switch (caseVar)
            {
                case (1): 
                case (2):
                case (3): caseVar *= 10; break;
                case (4):
                case (5):
                case (6): caseVar *= 100; break;
                case (7): 
                case (8): 
                case (9): caseVar *= 1000; break;
            }
            Console.WriteLine("The new value of the digit is: {0}", caseVar);
        }
    }
}
