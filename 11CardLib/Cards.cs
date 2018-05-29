using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11CardLib
{
    public class Cards : CollectionBase,ICloneable
    {
        public void Add(Card newCard)
        {
            List.Add(newCard);
        }

        public void Remove(Card oldCard)
        {
            List.Remove(oldCard);
        }

        public Cards()
        { }

        public Card this[int cardIndex]
        {
            get
            {
                return (Card)List[cardIndex];
            }
            set
            {
                List[cardIndex] = value;
            }
        }

        public object Clone()
        {
            Cards newCrads = new Cards();
            foreach(Card sourceCard in List)
            {
                newCrads.Add(sourceCard.Clone() as Card); 
            }
            return newCrads;
        }

        /// <summary>
        /// Utility method for copying card instance into another Cars
        /// instance-used in Deck.Shuffle(). This implementation assumes that
        /// source and target collection are the same size.
        /// </summary>
        /// <param name="targetCards"></param>
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        /// <summary>
        /// Check to see if the cards collection contains a particular card.
        /// This calls the Contains methed of the ArrayList for the collection,
        /// which you access through the InnerList property.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool Contains(Card card)
        {
            return InnerList.Contains(card);
        }
    }
}
