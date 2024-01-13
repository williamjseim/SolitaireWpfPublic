using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Solitaire_v2.UserControls
{
    /// <summary>
    /// Interaction logic for Card.xaml
    /// </summary>
    public enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }
    public enum CardSuit
    {
        Spades,
        Hearts,
        Diamonds,
        Clubs
    }
    public enum CardColor
    {
        Red,
        Black,
    }
    public partial class Card : UserControl
    {
        public static event Action? CardRevealed;
        public CardSuit Suit { get; private set; }
        public CardValue Value { get; private set; }

        public CardColor Color { get; private set; }

        private BitmapImage backface;
        private BitmapImage frontface;

        public bool Revealed { get; private set; } = false;

        public Card? ConnectedCard { get; set; }

        public Card()
        {
            InitializeComponent();
            Suit = CardSuit.Spades;
            Value = CardValue.Ace;
            Color = CardColor.Black;
            frontface = new BitmapImage();
            backface = new BitmapImage();
        }
        public Card(CardSuit suit, CardValue cardType, BitmapImage backface, BitmapImage frontface)
        {
            this.Suit = suit;
            this.Value = cardType;
            this.Color = (suit == CardSuit.Spades || suit == CardSuit.Clubs) ? CardColor.Black : CardColor.Red;
            this.backface = backface;
            this.frontface = frontface;
            this.IsHitTestVisible = false;
        }

        public void Setup()
        {
            InitializeComponent();
            Sprite.Source = this.backface;
        }

        public void RevealCard()
        {
            this.Sprite.Source = this.frontface;
            this.IsHitTestVisible = true;
            this.Revealed = true;
            CardRevealed?.Invoke();
        }
    }
}
