using System;
namespace Cards
{
    class Cards
    {
        static void Main()
        {
            Console.WriteLine("Now you will see all the cards in a standard deck.Enter the ");
            string[] cards = new string[13] { "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10 ", "Jack ", "Queen", "King", "Ace" };
            string[] biggerOnes = new string[4] { "Spades", "Clubs", "Hearts", "Diamonds" };
            for (int j = 0; j < biggerOnes.Length; j++) //po cvetove vurtim
            {
                Console.WriteLine();
                for (int k = 0; k < cards.Length; k++) //vseki vid
                {
                    Console.WriteLine(cards[k] + " of " + biggerOnes[j]);
                }
            }
        }
    }
}
