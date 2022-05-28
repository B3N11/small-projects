using System;

namespace flashCards.Objects
{
    interface ICard
    {
        public string GetFront();

        public string GetBack();

        public bool CreateCard(string line, char separator);
    }
}
