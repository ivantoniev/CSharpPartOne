using System;
namespace BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            int givenNum = 13;
            int firstVal, secondVal;
            int firstValMask = 7 << 3, secondValMask = 7 << 24;
            firstVal = givenNum & firstValMask; //ekstraktvame si nujnite bitove
            firstVal = firstVal << 21; //mestim gi, kudeto ni trqbvat
            secondVal = givenNum & secondValMask;//ekstraktvame si nujnite bitove
            secondVal = secondVal >> 21; //mestim gi, kudeto ni trqbvat
            int maskOne, maskTwo, maskThree; //2ri maski
            maskOne = 7 << 24;
            maskTwo = 7 << 3;
            maskThree = maskOne | maskTwo;
            givenNum = givenNum & ~(maskThree); //zanulqvame si nujnite dupki
            givenNum = givenNum | firstVal;
            givenNum = givenNum | secondVal;
            Console.WriteLine(givenNum);

        }

    }
}

