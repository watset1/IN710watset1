using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDealer
{
    public class Hand
    {
        Card[] cards;
        int hcpTotal;

        public Hand(int hcpTotal)
        {
            cards = new Card[13];
            this.hcpTotal = hcpTotal;
        }
    }
}
