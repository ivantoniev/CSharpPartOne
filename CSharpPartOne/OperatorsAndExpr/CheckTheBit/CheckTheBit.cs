using System;


namespace CheckTheBit
{
    class CheckTheBit
    {
        static void Main()
        {
            int givenNum = 2;
            int bitPosition = 3;
            int mask = 1;
            mask = mask << bitPosition;
            bool check=(givenNum & mask)>0;
            Console.WriteLine("Is the bit 1? {0}",check);
        }
    }
}
