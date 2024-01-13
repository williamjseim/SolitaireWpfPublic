using Solitaire_v2.UserControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Media.Imaging;

namespace Solitaire_v2
{
    public static class CardStacker
    {
        static string backfaceString = "\\Resources\\Backface.png";

        public static List<Card> CreateCardStack()
        {
            var cards = new List<Card>();
            BitmapImage backface = new BitmapImage(new Uri(backfaceString, UriKind.Relative));
            var files = Directory.GetFiles("../../../.\\Resources\\CardSprites\\");
            foreach (var item in files)
            {
                Card? card = new();
                var name = item.Split('\\').Last();
                BitmapImage Frontface = new BitmapImage(new Uri(item, UriKind.Relative));
                if (name.Contains('c'))
                {
                    int number = int.Parse(name.Replace("c", "").Replace(".png",""))-1;
                    card = new Card(CardSuit.Clubs, (CardValue)number, backface, Frontface);
                }
                if (name.Contains('s'))
                {
                    int number = int.Parse(name.Replace("s", "").Replace(".png", ""))-1;
                    card = new Card(CardSuit.Spades, (CardValue)number, backface, Frontface);
                }
                if (name.Contains('h'))
                {
                    int number = int.Parse(name.Replace("h", "").Replace(".png", ""))-1;
                    card = new Card(CardSuit.Hearts, (CardValue)number, backface, Frontface);
                }
                if (name.Contains('d'))
                {
                    int number = int.Parse(name.Replace("d", "").Replace(".png", ""))-1;
                    card = new Card(CardSuit.Diamonds, (CardValue)number, backface, Frontface);
                }
                if (card == null)
                    continue;
                cards.Add(card);
            }
            Shuffle(cards);
            Debug.WriteLine(cards.Count);
            return cards;
        }

        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
