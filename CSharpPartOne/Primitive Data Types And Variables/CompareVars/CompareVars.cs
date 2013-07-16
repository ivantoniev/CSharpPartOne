using System;


namespace CompareVars
{
    class CompareVars
    {
        static void Main()
        {
            decimal varOne, varTwo;
            varOne = 7.00000001M;
            varTwo = 6.00000001M;
            bool comp = varOne > varTwo;
            Console.WriteLine("Is the first variable bigger than the second? {0}",comp);
        }
    }
}
