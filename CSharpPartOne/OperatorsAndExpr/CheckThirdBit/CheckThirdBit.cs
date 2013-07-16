using System;


namespace CheckThirdBit
{
    class CheckThirdBit
    {
        static void Main()
        {
            int mask=1;
            mask=1<<3;
            int givenNumber=12113;
            bool statement = ((givenNumber & mask)>0);
            Console.WriteLine(statement);
        }
    }
}
