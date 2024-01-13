using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Solitaire_v2.UserControls
{
    public class Gameboard : UserControl
    {
        protected Card? SelectedCard = null;
        protected Deck? SelectedCanvas = null;

        protected virtual void CardPickup(object sender, MouseEventArgs e)
        {
            if(sender is Card card)
            {
                SelectedCard = card;
                Panel.SetZIndex((Panel)card.Parent, 1);
                card.IsHitTestVisible = false;
                Card? ConCard = card.ConnectedCard;
                while (ConCard != null)
                {
                    ConCard.IsHitTestVisible = false;
                    ConCard = ConCard.ConnectedCard;
                }
                ChangeCardPosition();
            }
        }

        protected virtual void ChangeCardPosition()
        {
            if (SelectedCard != null)
            {
                Point pos = Mouse.GetPosition((Panel)SelectedCard.Parent);
                Canvas.SetLeft(SelectedCard, pos.X - SelectedCard.ActualWidth / 2);
                Canvas.SetTop(SelectedCard, pos.Y - SelectedCard.ActualHeight / 2);
                Card? card = SelectedCard.ConnectedCard;
                int i = 1;
                while(card != null)
                {
                    Canvas.SetLeft(card, pos.X - card.ActualWidth / 2);
                    Canvas.SetTop(card, pos.Y - card.ActualHeight / 2 + 50 * i);
                    card = card.ConnectedCard;
                    i++;
                }
            }
        }

        protected virtual void CardMoved(object sender, MouseEventArgs e) 
        {
            ChangeCardPosition();
        }

        protected virtual void CardDragged(object sender, DragEventArgs e)
        {
            ChangeCardPosition();
        }

        protected virtual void CardDropped(object sender, MouseEventArgs e) 
        {
            if(SelectedCard != null)
            {
                Panel.SetZIndex((Panel)SelectedCard.Parent, 0);
                if(SelectedCanvas != null)
                {
                    if (!SelectedCanvas.AddChild(SelectedCard!))
                    {
                    }
                }
                ((Deck)SelectedCard.Parent).Sort();
                SelectedCard.IsHitTestVisible = true;
                Card? card = SelectedCard.ConnectedCard;
                while (card != null)
                {
                    card.IsHitTestVisible = true;
                    card = card.ConnectedCard;
                }
                SelectedCard = null;
            }
        }

        protected virtual void EventMouseEnter(object sender, MouseEventArgs e)
        {
            if(sender is Deck canvas)
            {
                this.SelectedCanvas = canvas;
            }
        }

        protected virtual void EventMouseExit(object sender, MouseEventArgs e)
        {
            if(sender is Deck canvas)
            {
                this.SelectedCanvas = null;
            }
        }
    }
}
