using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDealer
{
    class Player
    {
        string name;
        Hand hand;

        public Player(string name,Hand hand)
        {
            this.name = name;
            this.hand = hand;
        }

        public Hand sortHand(Hand hand) 
        {
            return hand;   
        }

        public Hand calculateHcp(Hand hand)
        {
            return hand;
        }
    }
}
