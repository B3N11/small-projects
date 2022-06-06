using System;
using System.Linq;
using System.Collections.Generic;

namespace flashCards.Objects
{
    class Deck
    {
        #region Properties
        private List<ICard> cards = new List<ICard>();
        public string DeckName { get; private set; }
        public int CardCount { get { return cards.Count; } }

        private int cardIndex = 0;

        public Deck(string deckName)
        {
            DeckName = deckName;
        }
        #endregion

        #region Methods
        public void AddCard(ICard card)
        {
            cards.Add(card);
        }

        public void EmptyDeck()
        {
            cards = new List<ICard>();
            ModifyCardIndex(0, true);
        }

        public void ModifyCardIndex(int value = 0, bool reset = false)
        {
            cardIndex += value;

            if (reset) cardIndex = 0;

            cardIndex = Math.Clamp(cardIndex, 0, cards.Count - 1);
        }

        public List<ICard> Shuffle()
        {
            if (cards.Count == 0)
                return null;

            return cards.OrderBy(c => new Random().Next()).ToList();
        }

        public bool Shuffle(bool permanent)
        {
            if (cards.Count == 0 || !permanent)
                return false;

            ModifyCardIndex(0, true);
            cards = cards.OrderBy(c => new Random().Next()).ToList();
            return true;
        }

        public GetCardResult GetCard(int direction = 0)
        {
            if (cards.Count == 0)
                return null;

            direction = Math.Clamp(direction, -1, 1);
            ModifyCardIndex(direction);

            var result = new GetCardResult();
            result.card = cards[cardIndex];
            result.index = cardIndex;
            result.deckSize = CardCount;

            return result;
        }
        #endregion
    }
}
