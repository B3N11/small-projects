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
            decks_comboBox.SelectedValueChanged += Decks_comboBox_SelectedValueChanged;

            handler = Handler.Instance;
            handler.Start(new FlashCard());
        }

        private void Decks_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (decks_comboBox.SelectedItem == null)
                return;

            handler.SelectDeck(decks_comboBox.SelectedItem.ToString());
            reset_button_Click(null, null);
        }

        private void readFile_button_Click(object sender, EventArgs e)
        {
            var deckName = deckName_textBox.Text;
            var separator = separator_textBox.Text;
            var filePath = filePath_textBox.Text;

            if (string.IsNullOrEmpty(separator))
                return;

            string result = handler.CreateDeck(deckName, filePath, separator[0], Encoding.Default);

            if(result == null)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to select this flashcard deck?", "Select deck", MessageBoxButtons.YesNo);

                decks_comboBox.Items.Add(deckName);

                if (dialogResult == DialogResult.No)
                    return;

                handler.SelectDeck(deckName);                
                reset_button_Click(null, null);
            }

            else MessageBox.Show(result, "Error");
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

        private void DisplayCard(GetCardResult result)
        {
            if (result == null)
                return;

            currentCard = result.card;
            content_textBox.Text = currentCard.GetFront();
            cardCount_textBox.Text = (result.index + 1) + " / " + result.deckSize;
            flipped = false;
        }

        private void other_button_Click(object sender, EventArgs e)
        {
            if (currentCard == null)
                return; 

            Form2 otherForm = new Form2(currentCard);
            otherForm.Show();
        }

        private void deleteDeck_button_Click(object sender, EventArgs e)
        {
            string selectedDeck = handler.GetSelectedDeckName();

            if (selectedDeck == null)
                return;

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete the flashcard pack '{selectedDeck}'", "Delete deck", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                DeleteDeck();
        }

        private void DeleteDeck()
        {
            string selectedDeck = handler.GetSelectedDeckName();

            if (selectedDeck == null)
                return;

            handler.DeleteDeck(selectedDeck);
            currentCard = null;
            decks_comboBox.Items.Remove(selectedDeck);
            cardCount_textBox.Text = "0 / 0";
            content_textBox.Text = string.Empty;
        }
    }
}