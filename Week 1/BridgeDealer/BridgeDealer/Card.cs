using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDealer
{
    class Card
    {
        int number;
        char suit;
        int hcpValue;
        int deckValue;

        public Card(int number, char suit, int hcpValue, int deckValue)
        {
            this.number = number;
            this.suit = suit;
            this.hcpValue = hcpValue;
            this.deckValue = deckValue;
        }
    }
}
