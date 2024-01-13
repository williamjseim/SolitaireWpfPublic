using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Solitaire_v2.UserControls
{
    public class Waste : Deck
    {
        public List<Card> cards { get; set; } = new();
        public override bool AddChild(Card card)
        {
            if (card.Parent == null || ((Deck)card.Parent).RemoveChild(card))
            {
                this.Children.Add(card);
                cards.Add(card);
                Sort();
                return true;
            }
            return false;
        }

        public override void Sort()
        {
            for (int j = 0, i = cards.Count - 1; i >= 0; i--, j++)
            {
                Card card = cards.ElementAt(i);
                if(j >= 3)
                {
                    card.Visibility = System.Windows.Visibility.Collapsed;
                    Panel.SetZIndex(card, j);
                    continue;
                }
                Canvas.SetTop(card, 0);
                Canvas.SetLeft(card, 50 * j);
                card.Visibility = System.Windows.Visibility.Visible;
            }
        }

        public override bool RemoveChild(Card card)
        {
            try
            {
                this.Children.Remove(card);
                cards.Remove(card);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
