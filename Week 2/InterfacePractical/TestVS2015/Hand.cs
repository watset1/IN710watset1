﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestVS2015
{
    public class Hand : IComparable<Hand>
    {
        public List<Card> CardsInHand { get; set; }
        public int TotalHCP
        {
            get; set;
        }

        public Hand()
        {
            CardsInHand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            CardsInHand.Add(card);
        }

        public int ComputeHCP()
        {
            TotalHCP = 0;
            foreach (Card c in CardsInHand)
                TotalHCP += c.HCP;

            return 0;
        }

        public void SortHand()
        {
            CardsInHand.Sort();
        }

        public int CompareTo(Hand other)
        {
            if (this.TotalHCP > other.TotalHCP)
                return -1;
            else if (this.TotalHCP < other.TotalHCP)
                return 1;
            else { return 0; }
        }
    }
}