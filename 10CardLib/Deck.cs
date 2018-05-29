using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10CardLib
{
    public class Deck
    {
        private Card[] cards;

        public Deck()
        {
            cards = new Card[52];
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal,
                                                                 (Rank)rankVal);
                }
            }
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
            Card[] newDeck = new Card[52];
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for(int i = 0; i<52;i++)
            {
                int destCard = 0;
                bool foundCard = false;
                while(foundCard == false)
                {
                    destCard = sourceGen.Next(52);
                    if (assigned[destCard] == false)
                        foundCard = true;
                }
                assigned[destCard] = true;
                newDeck[destCard] = cards[i];
            }
            newDeck.CopyTo(cards, 0);
        }
    }
}