using System;
using System.Collections.Generic;

namespace Hilo.Game
{
    public class Director
    {
        Dealer deck = new Dealer();
        bool _isPlaying = true;
        public void StartGame()
        {
            while (_isPlaying)
            {  
                GetInputs();asdjaosd    
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