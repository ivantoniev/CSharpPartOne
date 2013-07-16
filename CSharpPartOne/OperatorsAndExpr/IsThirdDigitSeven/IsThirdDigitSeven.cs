using System;


namespace IsThirdDigitSeven
{
    class IsThirdDigitSeven
    {
        static void Main()
        {
            int givenNumber = 1625;
            bool statement = (givenNumber / 100) % 10 == 7;
            Console.WriteLine(statement);
        }
    }
}
