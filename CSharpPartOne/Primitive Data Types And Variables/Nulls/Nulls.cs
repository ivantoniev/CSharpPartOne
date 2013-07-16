using System;


namespace ProblemEleven
{
    class Nulls
    {
        static void Main()
        {
            int? nullInt = null;
            double? nullDouble = null;
            nullInt += 2;
            nullDouble += 2;
            Console.WriteLine(nullInt);
            Console.WriteLine(nullDouble);
            Console.Write("{0} {1}", nullInt, nullDouble);
        }
    }
}
