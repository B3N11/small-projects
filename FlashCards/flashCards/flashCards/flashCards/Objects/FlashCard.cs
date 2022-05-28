using System;

namespace flashCards.Objects
{
    class FlashCard : ICard
    {
        private string front;
        private string back;

        public FlashCard(string front, string back)
        {
            this.front = front;
            this.back = back;
        }

        public string GetBack()
        {
            return back;
        }

        public string GetFront()
        {
            return front;
        }
    }
}
