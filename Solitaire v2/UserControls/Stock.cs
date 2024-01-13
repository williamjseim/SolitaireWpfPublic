using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Solitaire_v2.UserControls
{
    public class Stock : Deck
    {
        public Stock()
        {
            this.MouseDown += DrawCards;
        }
        public int AmountToDraw { get; set; } = 1;
        public Waste waste { get; set; }
        private Image stockImage;
        public Image StockImage { get { return stockImage; } set
            {
                this.stockImage = value;
            }
        }
        public List<Card> CardQueue { get; set; } = new();
        public void InitiateQueue(ICollection<Card> cards)
        {
            this.CardQueue = new List<Card>(cards);
        }

        public void DrawCards(object sender, MouseEventArgs e)
        {
            if(CardQueue.Count == 0)
            {
                List<Card> temp = new List<Card>();
                for (int i = waste.Children.Count - 1; i >= 0; i--)
                {
                    Card card = (Card)waste.Children[i];
                    Panel.SetZIndex(card, 0);
                    temp.Add(card);
                    waste.RemoveChild(card);
                    this.StockImage.Visibility = System.Windows.Visibility.Visible;
                }
                temp.Reverse();
                this.CardQueue = new(temp);
                return;
            }
            for (int i = 0; i < Math.Clamp(CardQueue.Count, 0, AmountToDraw); i++) 
            {
                Card card = CardQueue.First();
                CardQueue.Remove(card);
                waste.AddChild(card);
                card.Setup();
                card.RevealCard();
            }
            if(CardQueue.Count == 0)
            {
                this.StockImage.Visibility = System.Windows.Visibility.Hidden;
            }
            waste.Sort();
        }

        public override bool RemoveChild(Card card)
        {
            try
            {
                if(card.Parent != null)
                    this.Children.Remove(card);
                CardQueue.Remove(card);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
