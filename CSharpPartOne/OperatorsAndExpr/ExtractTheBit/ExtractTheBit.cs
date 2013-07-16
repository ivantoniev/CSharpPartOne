using System;
namespace ExtractTheBit
{
    class ExtractTheBit
    {
        static void Main()
        {
            int givenNum = 5;
            int bitPosition = 2;
            int mask = 1;
            mask = mask << bitPosition;
            bool check = (givenNum & mask) > 0;
            if (check == true)
            {
                Console.WriteLine(1);
            }
            else 
            {
                Console.WriteLine(0);
            }

        }
    }
}
