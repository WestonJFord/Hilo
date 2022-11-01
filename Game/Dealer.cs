using System;

namespace Hilo.Game
{
    public class Dealer
    {
        public void NewDeck()
        {
            Dictionary<int,string> deck = new Dictionary<int,string>();

            for (int i = 1; i <= 13; i = i + 2)
            {
                deck.Add(i,i.ToString());

                    //Testing to verify the new deck is good:
                    Console.WriteLine(deck);
            }
        }
    }
}