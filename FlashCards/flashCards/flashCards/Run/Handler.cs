using System;
using System.Text;
using System.IO;
using flashCards.Objects;

namespace flashCards.Run
{
    class Handler
    {
        #region Singleton

        private static Handler handler = new Handler();
        public static Handler Instance { get { return handler; } }

        private Handler() { }

        #endregion

        #region Properties

        private DeckHandler deckHandler;
        private ICard cardType;
        private bool started = false;

        #endregion

        #region General

        public void Start(ICard type)
        {
            deckHandler = DeckHandler.Instance;
            cardType = type;
            started = true;
        }

        public bool GetDeckFromFile(string deckName, string filePath, char separator, Encoding encoding)
        {
            if (!started)
                throw new Exception("Handler has not been started yet. Call Handler.Start() first!");

            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(separator.ToString()) || string.IsNullOrEmpty(deckName))
                return false;

            if (!File.Exists(filePath))
                return false;

            Deck deck = new Deck(deckName);

            try
            {
                using (StreamReader reader = new StreamReader(filePath, encoding))
                {
                    do
                    {
                        string line = reader.ReadLine();

                        if (string.IsNullOrEmpty(line) || string.IsNullOrWhiteSpace(line))
                            break;

                        ICard card = (ICard)Activator.CreateInstance(cardType.GetType());
                        bool result = card.CreateCard(line, separator);

                        if (!result)
                            return false;

                        deck.AddCard(card);

                    } while (reader.Peek() >= 0);
                }
            }
            catch { return false; }

            if (deck.CardCount == 0)
                return false;

            deckHandler.AddDeck(deck);
            deckHandler.SelectDeck(deckName);
            return true;
        }
        #endregion

        #region UI Commands
        public ICard GetCard(int direction = 0)
        {
            return deckHandler.SelectedDeck?.GetCard(direction);
        }

        public void Shuffle()
        {
            deckHandler.SelectedDeck?.Shuffle(true);
        }

        public void ResetDeck()
        {
            deckHandler.SelectedDeck?.ModifyCardIndex(0, true);
        }
        #endregion
    }
}