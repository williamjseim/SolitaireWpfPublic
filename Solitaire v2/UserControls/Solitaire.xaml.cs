using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Solitaire_v2.UserControls
{
    /// <summary>
    /// Interaction logic for Solitaire.xaml
    /// </summary>
    public partial class Solitaire : Gameboard
    {
        public Deck[] Foundations { get; private set; }
        public Deck[] Piles { get; private set; }
        public Solitaire()
        {
            InitializeComponent();
            this.Stock.waste = this.Waste;
            this.Stock.StockImage = this.StockImage;
            Foundations = new Deck[] { StackOne, StackTwo, StackThree, StackFour };
            Piles = new Deck[] { PileOne, PileTwo, PileThree, PileFour, PileFive, PileSix, PileSeven };
            var cards = CardStacker.CreateCardStack();
            foreach (var item in cards)
            {
                item.MouseEnter += this.EventMouseEnter;
                item.MouseLeave += this.EventMouseExit;
                item.MouseDown += CardPickup;
            }
            for (int i = 0; i < Piles.Length; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Card card = cards[0];
                    Piles[i].Children.Add(card);
                    card.Setup();
                    cards.RemoveAt(0);
                    Piles[i].Sort();
                }
                ((Card)Piles[i].Children[i]).RevealCard();
            }
            Card.CardRevealed += CheckIfComplete;
            this.Stock.InitiateQueue(cards);
        }

        public void CheckIfComplete()
        {
            for (int i = 0; i < Piles.Length; i++)
            {
                if (Piles[i].Children.Count > 0 && !((Card)Piles[i].Children[0]).Revealed)
                    return;
            }
            Debug.WriteLine("Complete");
        }
    }
}
