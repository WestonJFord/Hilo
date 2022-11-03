using System;
using System.Collections.Generic;

namespace Hilo.Game
{
    public class Dealer
    {
        public List<int> deck;
        public int card;
        public Dealer()
        {}
        public void NewDeck()
        {
            List<int> deck = new List<int>();

            for (int g = 0; g <= 3; g++)
            {
                for (int i = 1; i <= 13; i++)
                {
                    deck.Add(i);

                        //Testing to verify the new deck is good:
                        //Console.WriteLine(deck);
                }
            }
        }

        public void DrawCard(int i, List<int> deck)
        {
            int card = deck[i];
        }
    }
}