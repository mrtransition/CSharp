using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11CardLib
{
    public class Deck : ICloneable
    {
        //private Card[] cards;
        private Cards cards = new Cards(); 

        public object Clone()
        {
            Deck newDeck = new Deck(cards.Clone() as Cards );
            return newDeck;
        }
         
        public Deck()
        {
            //cards = new Card[52];
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    //cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal,
                    //                                             (Rank)rankVal);
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }

        public Deck(Cards newCards)
        {
            cards = newCards;
        }

        /// <summary>
        /// Nondefault constructor. Allows aces to be set high.
        /// </summary>
        /// <param name="isAceHigh"></param>
        public Deck(bool isAceHigh) :this()
        {
            Card.isAceHigh = isAceHigh;
        }

        /// <summary>
        /// Nondefault constructor. Allows a trump suit to be used.
        /// </summary>
        /// <param name="useTrumps"></param>
        /// <param name="trump"></param>
        public Deck(bool useTrumps,Suit trump) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        /// <summary>
        /// Nondefault constructor. Allows aces to be set high and a trump suit
        /// </summary>
        /// <param name="isAceHigh"></param>
        /// <param name="useTrumps"></param>
        /// <param name="trump"></param>
        public Deck(bool isAceHigh,bool useTrumps,Suit trump) :this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        /// <summary>
        /// 为指定的索引返回Card对象
        /// </summary>
        /// <param name="cardNum"></param>
        /// <returns></returns>
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                return cards[cardNum];
            }
            else
            {
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                       "Value must be between 0 and 51."));
            }
        }

        /// <summary>
        /// 创建一个临时的扑克牌数组，并且把扑克牌从现有的cards数组随机赋值到这个数组
        /// </summary>
        public void Shuffle()
        {
            //Card[] newDeck = new Card[52];
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for (int i = 0; i < 52; i++)
            {
                //int destCard = 0;
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    //destCard = sourceGen.Next(52);
                    //if (assigned[destCard] == false)
                    //foundCard = true;
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                //assigned[destCard] = true;
                //newDeck[destCard] = cards[i];
                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);
            }
            //newDeck.CopyTo(cards, 0);
            newDeck.CopyTo(cards);
        }
    }
}