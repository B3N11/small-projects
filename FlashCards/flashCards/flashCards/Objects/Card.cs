using System;

namespace flashCards.Objects
{
    public interface ICard
    {
        public string GetFront();

        public string GetBack();

        public string GetOther();

        public bool CreateCard(string line, char separator);
    }
}
