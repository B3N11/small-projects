using System;
using System.Collections.Generic;
using System.Linq;
using flashCards.Objects;

namespace flashCards.Run
{
    class DeckHandler
    {
        #region Singleton
        private static DeckHandler handler = new DeckHandler();
        public static DeckHandler Instance { get { return handler; } }

        private DeckHandler() { }
        #endregion

        #region Properties
        private List<Deck> decks = new List<Deck>();

        public Deck SelectedDeck { get; private set; }
        #endregion

        #region Methods
        public void AddDeck(Deck deck)
        {
            if (deck == null)
                return;

            decks.Add(deck);
        }

        public void RemoveDeck(string deckName)
        {
            if (string.IsNullOrEmpty(deckName))
                return;

            if (SelectedDeck.DeckName == deckName)
                SelectedDeck = null;

            decks.Remove(decks.First(d => d.DeckName == deckName));
        }

        public bool SelectDeck(string deckName)
        {
            if (string.IsNullOrEmpty(deckName))
                return false;

            if (!decks.Exists(d => d.DeckName == deckName))
                return false;

            SelectedDeck = decks.First(d => d.DeckName == deckName);
            return true;
        }

        public Deck GetDeck(string deckName)
        {
            if (string.IsNullOrEmpty(deckName))
                return null;

            if (decks.Exists(d => d.DeckName == deckName))
                return decks.First(d => d.DeckName == deckName);

            return null;
        }
        #endregion
    }
}
