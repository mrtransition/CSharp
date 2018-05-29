﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _10CardLib;

namespace _10DemoClinic
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for(int i = 0;i<52;i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.Write(tempCard.ToString());
                //if (i != 51)
                //    Console.Write(", ");
                //else
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
