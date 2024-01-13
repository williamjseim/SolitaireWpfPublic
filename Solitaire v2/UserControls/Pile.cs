using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Solitaire_v2.UserControls
{
    public class Pile : Deck
    {
        public override bool AddChild(Card card)//should be rewritten
        {
            if(this.Children.Count == 0)
            {
                if(card.Value == CardValue.King)
                {
                    ((Deck)card.Parent).RemoveChild(card);
                    this.Children.Add(card);
                    Card? ConCard = card.ConnectedCard;
                    while(ConCard != null)
                    {
                        ((Deck)ConCard.Parent).RemoveChild(ConCard);
                        this.Children.Add((Card)ConCard);
                        ConCard = ConCard.ConnectedCard;
                    }
                    return true;
                }
                return false;
            }
            Card last = (Card)this.Children[this.Children.Count - 1];
            if (last.Color != card.Color && last.Value == card.Value + 1)
            {
                ((Deck)card.Parent).RemoveChild(card);

                if(last.Revealed)
                    last.ConnectedCard = card;

                this.Children.Add(card);
                Card? ConCard = card.ConnectedCard;
                while (ConCard != null)
                {
                    ((Deck)ConCard.Parent).RemoveChild(ConCard);
                    this.Children.Add((Card)ConCard);
                    ConCard = ConCard.ConnectedCard;
                }
                return true;
            }
            return false;
        }
        public override bool RemoveChild(Card card)
        {
            this.Children.Remove(card);
            if(this.Children.Count > 0)
            {
                ((Card)this.Children[Children.Count - 1]).RevealCard();
                ((Card)this.Children[this.Children.Count - 1]).ConnectedCard = null;
            }
            return true;
        }

        public override void Sort()
        {
            int i = 0;
            foreach (Card item in Children)
            {
                Canvas.SetTop(item, (50 - this.Children.Count * 2) * i);
                Canvas.SetLeft(item, 0);
                item.InitializeComponent();
                i++;
            }
        }
    }
}
