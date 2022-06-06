using flashCards.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashCards
{
    public partial class Form2 : Form
    {
        public Form2(ICard card)
        {
            InitializeComponent();

            if (card == null)
                return;

            other_textBox.Text = card.GetOther();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
