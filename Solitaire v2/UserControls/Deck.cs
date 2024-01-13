using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Solitaire_v2.UserControls
{
    public class Deck : Canvas
    {
        /// <summary>
        /// Adds Card to deck inheriten if possible
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public virtual bool AddChild(Card card)
        {
            ((Deck)card.Parent).RemoveChild(card);
            this.Children.Add(card);
            Canvas.SetLeft(card, 0);
            Sort();
            return true;
        }

        /// <summary>
        /// Removes card from deck inheriten if possible
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public virtual bool RemoveChild(Card card)
        {
            if(card.Parent != null)
                this.Children.Remove(card);
            return true;
        }

        /// <summary>
        /// Sorts children of deck inheriten
        /// </summary>
        public virtual void Sort()
        {
            foreach (Card item in this.Children)
            {
                Canvas.SetLeft(item, 0);
                Canvas.SetTop(item, 0);
            }
        }
    }
}
