using System;
using System.Collections.Generic;
using System.Linq;

namespace flashCards.Objects
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
            decks.Add(deck);
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
        #endregion
    }
}
