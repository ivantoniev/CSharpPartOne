using System;
namespace ChangeBit
{
    class ChangeBit
    {
        static void Main()
        {
            int givenNum = 5;
            int bitPosition = 3, bitVal;
            int v = 1;
            int mask = 1;
            mask = mask << bitPosition;
            if ((givenNum & mask) != 0)
            {
                bitVal = 1;
            }
            else
            {
                bitVal = 0;
            }
            if (bitVal==v)
            {
                Console.WriteLine("the bit doesn`t need to be changed.");
            }
            else
            {
                givenNum ^= mask;
                Console.WriteLine(givenNum);
            }
        }
    }
}
