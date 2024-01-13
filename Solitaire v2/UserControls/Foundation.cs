using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire_v2.UserControls
{
    public class Foundation : Deck
    {

        public override bool AddChild(Card card)
        {
            if((int)card.Value == Children.Count && ( this.Children.Count == 0 || ((Card)this.Children[Children.Count -1]).Suit == card.Suit))
            {
                Card? c = card;
                while(c != null)
                {
                    ((Deck)c.Parent).RemoveChild(c);
                    this.Children.Add(c);
                    c = c.ConnectedCard;
                }
                Sort();
                return true;
            }
            return false;
        }
    }
}
