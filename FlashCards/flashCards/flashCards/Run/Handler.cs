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

        private DeckHandler deckHandler;

        #region General

        public void Start()
        {
            deckHandler = DeckHandler.Instance;
        }

        public bool GetDeckFromFile(string deckName, string filePath, char separator, Encoding encoding)
        {
            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(separator.ToString()) || string.IsNullOrEmpty(deckName))
                return false;

            if (!File.Exists(filePath))
                return false;

            Deck deck = new Deck(deckName);
            using (StreamReader reader = new StreamReader(filePath, encoding))
            {
                do
                {
                    string[] line = reader.ReadLine().Split(separator);

                    if (line.Length == 0)
                        break;

                    FlashCard card = new FlashCard(line[0], line[1]);
                    deck.AddCard(card);

                } while (reader.Peek() >= 0);                                
            }

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
            return deckHandler.SelectedDeck.GetCard(direction);
        }

        public void Shuffle()
        {
            deckHandler.SelectedDeck.Shuffle(true);
        }

        public void ResetDeck()
        {
            deckHandler.SelectedDeck.ModifyCardIndex(0, true);
        }
        #endregion
    }
}