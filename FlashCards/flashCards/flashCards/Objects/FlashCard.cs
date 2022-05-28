using System;

namespace flashCards.Objects
{
    class FlashCard : ICard
    {
        private string front;
        private string back;

        public bool CreateCard(string line, char separator)
        {
            if (string.IsNullOrEmpty(separator.ToString()))
                return false;

            string[] split = line.Split(separator);
            front = split[0];
            back = split[1];

            return true;
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
