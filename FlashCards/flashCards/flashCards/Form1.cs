using System;
using System.Text;
using System.Windows.Forms;
using flashCards.Objects;
using flashCards.Run;

namespace flashCards
{
    public partial class Form1 : Form
    {
        private Handler handler;
        private bool flipped = false;
        private ICard currentCard;

        public Form1()
        {
            InitializeComponent();
            handler = Handler.Instance;
            handler.Start();
        }

        private void readFile_button_Click(object sender, EventArgs e)
        {
            var deckName = deckName_textBox.Text;
            var separator = separator_textBox.Text;
            var filePath = filePath_textBox.Text;

            if (string.IsNullOrEmpty(separator))
                return;

            handler.GetDeckFromFile(deckName, filePath, separator[0], Encoding.Default);
            reset_button_Click(null, null);
        }

        private void open_textBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath_textBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            DisplayCard(handler.GetCard(1));
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            DisplayCard(handler.GetCard(-1));
        }

        private void flip_button_Click(object sender, EventArgs e)
        {
            if (currentCard == null)
                return;

            if (flipped) content_textBox.Text = currentCard.GetFront();
            else content_textBox.Text = currentCard.GetBack();

            flipped = !flipped;
        }

        private void shuffle_button_Click(object sender, EventArgs e)
        {
            handler.Shuffle();
            reset_button_Click(null, null);
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            handler.ResetDeck();
            flipped = false;
            DisplayCard(handler.GetCard());
        }

        private void DisplayCard(ICard card)
        {
            if (card == null)
                return;

            currentCard = card;
            content_textBox.Text = currentCard.GetFront();
            flipped = false;
        }
    }
}
