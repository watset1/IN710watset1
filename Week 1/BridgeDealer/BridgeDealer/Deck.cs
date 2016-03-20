using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDealer
{
    class Deck
    {
        const int SUITS = 4;
        const int SUITLENGTH = 13;

        Card[] deckCards;
        
        public Deck(Card[] deckCards)
        {
            deckCards = new Card[52];
        }

        public void createDeck()
        {
            for (int i = 0; i < SUITS; i++)
            {
                for (int j = 0; j < SUITLENGTH; j++)
                {
                    switch(i)
                    {
                        case 0:

                            
                    }
                }
            }
        }
    }
}
