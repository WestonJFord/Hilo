using System;
using System.Collections.Generic;

namespace Hilo.Game
{
    public class Director
    {
        Dealer dealer = new Dealer();
        bool _isPlaying = true;

        public Director()
        {
            dealer.NewDeck();
            dealer.DrawCard(1, dealer.deck);
        }
        public void StartGame()
        {
            while (_isPlaying)
            {  
                GetInputs();  
                DoUpdates();
                DoOutputs();
            }
        }
        
        public void GetInputs()
        {}

        public void DoUpdates()
        {}

        public void DoOutputs()
        {}
    }
}